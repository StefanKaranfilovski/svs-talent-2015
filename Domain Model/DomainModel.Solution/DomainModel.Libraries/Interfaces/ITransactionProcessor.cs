using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Processors;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Interfaces
{
    public interface ITransactionProcessor
    {
        #region Fields and Properties

        TransactionLogger ExternalLogger { get; set; }

        TransactionLogEntry LastTransaction { get; }

        int TransactionCount { get; }

        TransactionLogEntry this[int i] { get; }

        #endregion

        #region Methods

        TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo);

        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);

        TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);

        #endregion
    }
}
