using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using DomainModel.Libraries.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DomainModel.Libraries.Helpers
{
    public static class AccountHelper
    {
        private static int s_AccountId;

        static AccountHelper()
        {
            s_AccountId = 0;
        }

        public static int GenerateAccountId() 
        {
            s_AccountId += 1;
            return s_AccountId;
        }

        public static string GenerateAccountNumber(Type accountType, long accountId) 
        {
            string accountNumber = "No number";

            if (accountType.Name == "ITransactionAccount") 
            {
                accountNumber = "TR0000" + accountId.ToString();
            }
            else if (accountType.Name == "IDepositAccount") 
            {
                accountNumber = "DP0000" + accountId.ToString();
            }
            else if (accountType.Name == "ILoanAccount")
            {
                accountNumber = "LN0000" + accountId.ToString();
            }
            return accountNumber;
        }

        public static string GenerateAccountNumber<T>(long accountId) where T :IAccount
        {
            Type type = typeof(T);
            return GenerateAccountNumber(type, accountId);
        }

        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if(amount.Amount > 20000 && amount.Currency == "MKD")
            {
                Debug.WriteLine("Number:{0}\n Transaction type:{1}\n Amount:{2}\n Currency:{3}\n", account.Number, transactionType, amount.Amount, amount.Currency);
            }
        }

        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount > 25000 && amount.Currency == "MKD")
            {
                Debug.WriteLine("The amount exceedes 25000 MKD.");
            }
        }
    }
}
