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
    /// <summary>
    /// Public sealed class LoanAccount that inherits DepositAccount, and implements the ILoanAccount interface
    /// </summary>
    [AccountMetadata]
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        #region Constructors

        /// <summary>
        /// Constructor with 6 parameters that are passed to the base class constructor
        /// </summary>
        /// <param type=string name="currency"></param>
        /// <param type=TimePeriod name="depositPeriod"></param>
        /// <param type=InterestRate name="interestRate"></param>
        /// <param type=DateTime name="startDate"></param>
        /// <param type=DateTime name="endDate"></param>
        /// <param type=ITransactionAccount name="transactionAccount"></param>
        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                            DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// DebitAmount() override that calls the base class CreditAmount()
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            base.CreditAmount(amount);
            return TransactionStatus.Completed;
        }

        /// <summary>
        /// CreditAmount() override that calls the base class DebitAmount()
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            base.DebitAmount(amount);
            return TransactionStatus.Completed;
        }

        /// <summary>
        /// GenerateAccountNumber() override that generates Account number using the GenerateAccountNumber() generic method
        /// </summary>
        /// <returns>string</returns>
        protected override string GenerateAccountNumber()
        {
            string number = AccountHelper.GenerateAccountNumber<ILoanAccount>(this.ID);
            return number;
        }

        #endregion
    }
}
