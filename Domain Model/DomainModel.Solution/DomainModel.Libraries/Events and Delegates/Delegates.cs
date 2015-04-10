using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);

public delegate void BalanceChanged(object sender, BalanceChangedEventArguments eventArgs);

public class BalanceChangedEventArguments : EventArgs
{
    public IAccount Account { get; private set; }

    public CurrencyAmount Change { get; private set; }

    public BalanceChangedEventArguments(IAccount constructorAccount, CurrencyAmount constructorChange)
    {
        this.Account = constructorAccount;
        this.Change = constructorChange;
    }
}
