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
    /// <summary>
    /// Implements ITransactionProcessor interface
    /// </summary>
    public class TransactionProcessor : ITransactionProcessor
    {
        #region Field and Properties

        private IList<TransactionLogEntry> transactionLog;

        private TransactionLogEntry lastTransaction;

        /// <summary>
        /// Returns the last transaction in the transactionLog list, if the list is empty returns null
        /// </summary>
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

        /// <summary>
        /// Returns the number of transactions, counts the elements in the transactionLog list
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return transactionLog.Count;
            }
        }

        /// <summary>
        /// Auto-implemented property of TransactionLogger delegate type
        /// </summary>
        public TransactionLogger ExternalLogger { get; set; }

        /// <summary>
        /// This indexer is used for getting the last transaction in the transactionLog list
        /// </summary>
        /// <param type=int name="i"></param>
        /// <returns>TransactionLogEntry</returns>
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

        #endregion

        #region Singleton pattern

        /// <summary>
        /// This field will hold the only instance of TransactionProcessor
        /// </summary>
        private static readonly TransactionProcessor instance;

        /// <summary>
        /// The default constructor needs to be private so we cant call it manualy
        /// </summary>
        private TransactionProcessor()
        {
            transactionLog = new List<TransactionLogEntry>();
            ExternalLogger += AccountHelper.LogTransaction;
            ExternalLogger += AccountHelper.NotifyNationalBank;
        }

        /// <summary>
        /// The default static constructor initializes the TransactionProcessor instance and is called only once
        /// </summary>
        static TransactionProcessor()
        {
            instance = new TransactionProcessor();
        }

        /// <summary>
        /// We use this method to get the instance of TransactionProcessor
        /// </summary>
        /// <returns>TransactionProcessor</returns>
        public static TransactionProcessor GetTransactionProcessor()
        {
            return instance;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Passes the parameters to the ExternalLogger delegate property
        /// </summary>
        /// <param type=IAccount name="account"></param>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account, transactionType, amount);
        }

        /// <summary>
        /// Overrides the extension method and throws NotImplementedExeption
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IEnumerable<IAccount> name="accounts"></param>
        /// <returns></returns>
        public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates new TransactionLogEntry and puts it in the transactionLog list
        /// </summary>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IAccount[] name="accounts"></param>
        /// <param type=TransactionStatus name="transactionStatus"></param>
        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            TransactionLogEntry log = new TransactionLogEntry();
            log.TransactionType = transactionType;
            log.Amount = amount;
            log.Accounts = accounts;
            log.Status = transactionStatus;

            transactionLog.Add(log);
        }

        /// <summary>
        /// Executes multiple transaction and executes the appropriate action depending on the transaction type
        /// </summary>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IAccount[] name="accounts"></param>
        /// <returns>TransactionStatus</returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            TransactionStatus status = new TransactionStatus();
            if (transactionType == TransactionType.Credit)
            {
                foreach (var account in accounts)
                {
                    account.CreditAmount(amount);
                    //Calls the delegate foreach action
                    CallExternalLogger(account, transactionType, amount);
                }
                status = TransactionStatus.Completed;
            }
            else if (transactionType == TransactionType.Debit)
            {
                foreach (var account in accounts)
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
            //Logs the transaction
            LogTransaction(transactionType, amount, accounts, status);
            return status;
        }

        /// <summary>
        /// Makes a single transaction from one account to another, and according to the type of transaction executes the appropriate operation
        /// </summary>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IAccount name="accountFrom"></param>
        /// <param type=IAccount name="accountTo"></param>
        /// <returns>TransactionStatus</returns>
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
                    //Calls the delegate foreach action
                    CallExternalLogger(accountFrom, transactionType, amount);
                    accountTo.CreditAmount(amount);
                    CallExternalLogger(accountTo, transactionType, amount);
                    status = TransactionStatus.Completed;
                    //Log the transaction
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
                    LogTransaction(transactionType, amount, null, status);
                    return status;
            }
        }

        #endregion
    }
}
