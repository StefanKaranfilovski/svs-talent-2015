using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Interfaces
{
    public interface ITransactionAccount : IAccount
    {
        #region Properties

        CurrencyAmount Limit { get; }

        #endregion
    }
}
