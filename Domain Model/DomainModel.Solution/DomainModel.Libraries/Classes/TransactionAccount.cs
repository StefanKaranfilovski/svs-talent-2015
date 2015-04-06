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
    /// Public class "TransactionAccount" who inherits from "Account" base class
    /// </summary>
    public class TransactionAccount : Account, ITransactionAccount
    {
        #region Fields and Properties

        /// <summary>
        /// Private CurrencyAmount "limit" field
        /// </summary>
        private CurrencyAmount limit;

        /// <summary>
        /// Public CurrencyAmount "Limit" property for the "limit" field
        /// Public getter and private setter
        /// </summary>
        public CurrencyAmount Limit
        {
            get { return limit; }
            private set { limit = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// "TransactionAccount" constructor for TransactionAccount who takes 2 parametersand calls the base class constructor with one string parameter
        /// </summary>
        /// <param type="string" name="currency"></param>
        /// <param type="decimal" name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount)
            : base(currency)
        {
            CurrencyAmount c = new CurrencyAmount();
            c.Amount = limitAmount;
            this.Limit = c;
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