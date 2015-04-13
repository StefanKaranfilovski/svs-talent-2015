using System;

/// <summary>
/// CreateAccountType enumerator that inherits from int and has the Flags attribute
/// </summary>
[Flags]
public enum CreateAccountType : int 
{
    None = 0,
    TransactionAccount = 1,
    DepositAccount = 2,
    LoanAccount = 4
}