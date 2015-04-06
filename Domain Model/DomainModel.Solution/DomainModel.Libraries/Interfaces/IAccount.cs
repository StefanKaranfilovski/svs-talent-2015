using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Interfaces
{
    public interface IAccount
    {
        #region Properties

        long ID { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }

        #endregion

        #region Methods

        TransactionStatus DebitAmount(CurrencyAmount amount);
        TransactionStatus CreditAmount(CurrencyAmount amount);

        #endregion
    }
}
