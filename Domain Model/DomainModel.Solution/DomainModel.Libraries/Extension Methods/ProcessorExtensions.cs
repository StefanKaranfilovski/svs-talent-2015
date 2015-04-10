using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Extension_Methods
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts) 
        {
            processor.ProcessGroupTransaction(TransactionType.Debit, amount, accounts.ToArray());
            return TransactionStatus.Completed;
        }
    }
}
