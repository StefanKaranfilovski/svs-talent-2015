using DomainModel.Libraries.Enumerations;
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
        #region Methods

        TransactionStatus ProcessTransaction(TransactionType TransactionType, 
                                             CurrencyAmount Amount, 
                                             IAccount AccountFrom, 
                                             IAccount AccountTo);

        #endregion
    }
}
