﻿using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Helpers;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Classes
{
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        #region Constructors

        //TODO Check the implementation of the constructor
        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                            DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {

        }

        #endregion

        #region Methods

        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            CurrencyAmount a = base.Balance;
            a.Amount += amount.Amount;
            //TODO How to access the base property?
            //this.Balance = a;
            return TransactionStatus.Completed;
        }

        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            CurrencyAmount a = base.Balance;
            a.Amount -= amount.Amount;
            //TODO How to access the base property?
            //this.Balance = a;
            return TransactionStatus.Completed;
        }

        protected override string GenerateAccountNumber()
        {
            Type type = GetType();
            string number = AccountHelper.GenerateAccountNumber(type, this.ID);
            return number;
        }

        #endregion
    }
}