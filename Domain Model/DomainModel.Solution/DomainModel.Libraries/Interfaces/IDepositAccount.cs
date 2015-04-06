using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Interfaces
{
    public interface IDepositAccount : IAccount
    {
        #region Properties

        TimePeriod Period { get; }
        InterestRate Interest { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        ITransactionAccount TransactionAccount { get; }

        #endregion
    }
}
