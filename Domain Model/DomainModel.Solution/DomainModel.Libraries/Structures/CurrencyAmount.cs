using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Structures
{
    /// <summary>
    /// Public structure "CurrencyAmount"
    /// </summary>
    public struct CurrencyAmount
    {
        #region Fields and Properties

        /// <summary>
        /// Public decimal "Amount" field
        /// </summary>
        private decimal amount;

        public decimal Amount 
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Public decimal "Currency" field
        /// </summary>
        private string currency;

        public string Currency 
        {
            get { return currency; }
            set { currency = value; }
        }

        #endregion
    }
}
