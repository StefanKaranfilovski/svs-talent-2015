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
    /// <summary>
    /// AccountHelper static class used to store static helper methods
    /// </summary>
    public static class AccountHelper
    {
        private static int s_AccountId;

        /// <summary>
        /// Static constructor that sets the s_AccountId field to 0
        /// </summary>
        static AccountHelper()
        {
            s_AccountId = 0;
        }

        /// <summary>
        /// Increments the s_AccountId value by 1 each time
        /// </summary>
        /// <returns>int</returns>
        public static int GenerateAccountId() 
        {
            s_AccountId += 1;
            return s_AccountId;
        }

        /// <summary>
        /// Generates account number according to the Account type
        /// </summary>
        /// <param type=Type name="accountType"></param>
        /// <param type=long name="accountId"></param>
        /// <returns>string</returns>
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

        /// <summary>
        /// Generates account number by determing the Account type in run-time and calls the non-generic method to create the number
        /// It only works on types that are implementing IAccount interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static string GenerateAccountNumber<T>(long accountId) where T : IAccount
        {
            return GenerateAccountNumber(typeof(T), accountId);
        }

        /// <summary>
        /// If the transfer amount is bigger than 20000 it writes the details to the debug console
        /// </summary>
        /// <param type=IAccount name="account"></param>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if(amount.Amount > 20000 && amount.Currency == "MKD")
            {
                Debug.WriteLine("Number:{0} \nTransaction type:{1} \nAmount:{2} \nCurrency:{3}", account.Number, transactionType, amount.Amount, amount.Currency);
            }
        }

        /// <summary>
        /// If the transfer amount is bigger than 25000 it writes a message to the debug console
        /// </summary>
        /// <param type=IAccount name="account"></param>
        /// <param type=TransactionType name="transactionType"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount > 25000 && amount.Currency == "MKD")
            {
                Debug.WriteLine("The amount exceedes 25000 MKD.");
            }
        }
    }
}
