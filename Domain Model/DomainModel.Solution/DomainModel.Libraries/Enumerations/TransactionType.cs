using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Enumerations
{
    /// <summary>
    /// Public enumerator "TransactionType" with 4 members { NothingSelected, Transfer, Debit, Credit }
    /// </summary>
    public enum TransactionType
    {
        NothingSelected,
        Transfer,
        Debit,
        Credit
    }
}