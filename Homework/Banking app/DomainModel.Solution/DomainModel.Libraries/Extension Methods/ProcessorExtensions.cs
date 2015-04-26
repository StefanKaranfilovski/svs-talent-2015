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
        /// <summary>
        /// Extension method on the Transaction Processor class
        /// </summary>
        /// <param type=ITransactionProcessor name="processor"></param>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <param type=IEnumerable<IAccount> name="accounts"></param>
        /// <returns>TransactionStatus</returns>
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts) 
        {
            processor.ProcessGroupTransaction(TransactionType.Debit, amount, accounts.ToArray());
            return TransactionStatus.Completed;
        }
    }
}
