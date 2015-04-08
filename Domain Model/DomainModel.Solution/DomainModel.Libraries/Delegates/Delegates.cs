using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);