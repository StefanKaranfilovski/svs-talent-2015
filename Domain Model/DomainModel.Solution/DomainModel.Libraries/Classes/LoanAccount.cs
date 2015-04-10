using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Helpers;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Classes
{
    [AccountMetadata]
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        #region Constructors

        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                            DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {

        }

        #endregion

        #region Methods

        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            base.CreditAmount(amount);
            return TransactionStatus.Completed;
        }

        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            base.DebitAmount(amount);
            return TransactionStatus.Completed;
        }

        protected override string GenerateAccountNumber()
        {
            string number = AccountHelper.GenerateAccountNumber<ILoanAccount>(this.ID);
            return number;
        }

        #endregion
    }
}
