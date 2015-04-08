using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Helpers;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        private IList<TransactionLogEntry> transactionLog;

        private TransactionLogEntry lastTransaction;
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if(transactionLog != null)
                {
                    lastTransaction = transactionLog[transactionLog.Count - 1];
                    return lastTransaction;
                }
                return null;
            }
        }

        public int TransactionCount
        {
            get
            {
                return transactionLog.Count;
            }
        }

        public TransactionLogger ExternalLogger
        {
            get;

            set;
        }

        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account, transactionType, amount);
        }

        public TransactionLogEntry this[int i]
        {
            get
            {
                if(i >= 0 && i < transactionLog.Count)
                {
                    return transactionLog[i];
                }
                return null;
            }
        }

        private static readonly TransactionProcessor instance;

        private TransactionProcessor()
        {
            transactionLog = new List<TransactionLogEntry>();
            ExternalLogger += AccountHelper.LogTransaction;
            ExternalLogger += AccountHelper.NotifyNationalBank;
        }

        static TransactionProcessor()
        {
            instance = new TransactionProcessor();
        }

        public static TransactionProcessor GetTransactionProcessor()
        {
            return instance;
        }

        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            TransactionLogEntry log = new TransactionLogEntry();
            log.TransactionType = transactionType;
            log.Amount = amount;
            log.Accounts = accounts;
            log.Status = transactionStatus;

            transactionLog.Add(log);
        }

        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            TransactionStatus status = new TransactionStatus();
            if (transactionType == TransactionType.Credit)
            {
                foreach (IAccount account in accounts)
                {
                    account.CreditAmount(amount);
                    CallExternalLogger(account, transactionType, amount);
                }
                status = TransactionStatus.Completed;
            }
            if (transactionType == TransactionType.Debit)
            {
                foreach (IAccount account in accounts)
                {
                    account.DebitAmount(amount);
                    CallExternalLogger(account, transactionType, amount);
                }
                status = TransactionStatus.Completed;
            }
            else
            {
                status = TransactionStatus.Failed;
            }
            LogTransaction(transactionType, amount, accounts, status);
            return status;
        }

        public TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
        {
            TransactionStatus status = new TransactionStatus();
            IAccount[] accounts = new IAccount[2];
            accounts[0] = accountFrom;
            accounts[1] = accountTo;

            switch (transactionType)
            {
                case TransactionType.Transfer:
                    accountFrom.DebitAmount(amount);
                    accountTo.CreditAmount(amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    CallExternalLogger(accountTo, transactionType, amount);
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;

                case TransactionType.Debit:
                    accountFrom.DebitAmount(amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;

                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    status = TransactionStatus.Completed;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;

                default:
                    status = TransactionStatus.NothingSelected;
                    LogTransaction(transactionType, amount, accounts, status);
                    return status;
            }  
        }
    }
}
