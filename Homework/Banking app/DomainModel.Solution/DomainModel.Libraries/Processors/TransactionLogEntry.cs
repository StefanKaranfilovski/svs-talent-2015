using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Processors
{
    public class TransactionLogEntry
    {
        #region Field and Properties

        /// <summary>
        /// Each property has a backing private field
        /// </summary>

        private TransactionType transactionType;
        public TransactionType TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        private CurrencyAmount amount;
        public CurrencyAmount Amount
        {
            get { return amount; }
            set{ amount = value; }
        }

        private IAccount[] accounts;
        public IAccount[] Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        private TransactionStatus status;
        public TransactionStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion
    }
}
