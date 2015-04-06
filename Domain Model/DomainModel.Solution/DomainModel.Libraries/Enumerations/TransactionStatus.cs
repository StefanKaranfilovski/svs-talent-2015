using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Enumerations
{
    /// <summary>
    /// Public enumerator "TransactionStatus" with 5 members { NothingSelected, InProcess, Completed, CompletedWithWarning, Failed }
    /// </summary>
    public enum TransactionStatus
    {
        NothingSelected,
        InProcess,
        Completed,
        CompletedWithWarning,
        Failed
    }
}