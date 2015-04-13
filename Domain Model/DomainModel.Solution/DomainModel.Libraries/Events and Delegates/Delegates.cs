using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;

/// <summary>
/// TransactionLogger delegate with 3 parameters 
/// </summary>
/// <param type=IAccount name="account"></param>
/// <param type=TransactionType name="transactionType"></param>
/// <param type= name=CurrencyAmount"amount"></param>
public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);

/// <summary>
/// BalanceChanged delegate with 2 parameters
/// </summary>
/// <param type=object name="sender"></param>
/// <param type=BalanceChangedEventArguments name="eventArgs"></param>
public delegate void BalanceChanged(object sender, BalanceChangedEventArguments eventArgs);

/// <summary>
/// Custom event arguments class that inherits from EventArgs
/// </summary>
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
