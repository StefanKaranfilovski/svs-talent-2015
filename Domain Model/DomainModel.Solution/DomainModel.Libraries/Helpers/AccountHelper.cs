using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (accountType.Name == "TransactionAccount") 
            {
                accountNumber = "TR0000" + accountId.ToString();
            }
            else if (accountType.Name == "DepositAccount") 
            {
                accountNumber = "DP0000" + accountId.ToString();
            }
            else if (accountType.Name == "LoanAccount")
            {
                accountNumber = "LN0000" + accountId.ToString();
            }
            return accountNumber;
        }
    }
}
