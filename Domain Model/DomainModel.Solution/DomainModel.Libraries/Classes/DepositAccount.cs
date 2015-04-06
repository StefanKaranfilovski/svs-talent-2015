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
    /// Public class "DepositAccount" who inherits from "Account" base class
    /// </summary>
    public class DepositAccount : Account, IDepositAccount
    {
        #region Fields and Properties

        /// <summary>
        /// Private TimePeriod "period" field
        /// </summary>
        private TimePeriod period;

        /// <summary>
        /// Public TimePeriod "Period" property for the "period" field
        /// Public getter and private setter
        /// </summary>
        public TimePeriod Period
        {
            get { return period; }
            private set { period = value; }
        }

        /// <summary>
        /// Private InterestRate "interest" field
        /// </summary>
        private InterestRate interest;

        /// <summary>
        /// Public InterestRate "Interest" property for the "interest" field
        /// Public getter and private setter
        /// </summary>
        public InterestRate Interest
        {
            get { return interest; }
            private set { interest = value; }
        }

        /// <summary>
        /// Private DateTime "startDate" field
        /// </summary>
        private DateTime startDate;

        /// <summary>
        /// Public DateTime "StartDate" property for the "startDate" field
        /// Public getter and setter
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            private set { startDate = value; }
        }

        /// <summary>
        /// Private DateTime "endDate" field
        /// </summary>
        private DateTime endDate;

        /// <summary>
        /// Public DateTime "EndDate" property for the "endDate" field
        /// </summary>
        public DateTime EndDate
        {
            get { return endDate; }
            private set { endDate = value; }
        }

        /// <summary>
        /// Private TransactionAccount "transactionAccount" field
        /// </summary>
        private ITransactionAccount transactionAccount;

        /// <summary>
        /// Public TransactionAccount "TransactionAccount" property for the "transactionAccount" field
        /// </summary>
        public ITransactionAccount TransactionAccount
        {
            get { return transactionAccount; }
            private set { transactionAccount = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// "DepositAccount" constructor who takes 6 parameters and calls the base class constructor with one string parameter
        /// </summary>
        /// <param type="string" name="currency"></param>
        /// <param type="TimePeriod" name="depositPeriod"></param>
        /// <param type="InterestRate" name="interestRate"></param>
        /// <param type="DateTime" name="startDate"></param>
        /// <param type="DateTime" name="endDate"></param>
        /// <param type="TransactionAccount" name="transactionAccount"></param>
        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                              DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }

        #endregion

        #region Methods

        protected override string GenerateAccountNumber()
        {
            Type type = GetType();
            string number = AccountHelper.GenerateAccountNumber(type, this.ID);
            return number;
        }

        #endregion
    }
}