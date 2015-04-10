﻿using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Helpers;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Structures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Classes
{
    /// <summary>
    /// Public abstract class "Account" for all the accounts in the bank
    /// </summary>
    public abstract class Account : IAccount
    {
        protected abstract string GenerateAccountNumber();

        public event BalanceChanged OnBalanceChanged;

        #region Fields and Properties

        /// <summary>
        /// Private long "id" field
        /// </summary>
        private long id;

        /// <summary>
        /// Public long "ID" property for the "id" field
        /// Public getter and private setter
        /// </summary>
        public long ID
        {
            get { return id; }
            private set { id = value; }
        }

        /// <summary>
        /// Private string "number" field
        /// </summary>
        [FormatRestriction(MaxLength=16, FormatString="XXXX-XXXX-XXXX-XXXX")]
        private string number;

        /// <summary>
        /// Public string "Number" property for the "number" field
        /// Public getter and private setter
        /// </summary>
        public string Number
        {
            get { return number; }
            private set { number = value; }
        }

        /// <summary>
        /// Private string "currency" field
        /// </summary>
        private string currency;

        /// <summary>
        /// Public string "Currency" property for the "currency" field
        /// Public getter and private setter
        /// </summary>
        public string Currency
        {
            get { return currency; }
            private set { currency = value; }
        }

        /// <summary>
        /// Private CurrencyAmount "balance" field
        /// </summary>
        private CurrencyAmount balance;

        /// <summary>
        /// Public CurrencyAmount "Balance" property for the "balance" field
        /// Public getter and private setter
        /// </summary>
        public CurrencyAmount Balance
        {
            get { return balance; }
            private set 
            {
                if ((balance.Amount != value.Amount) || (balance.Currency != value.Currency)) 
                {
                    balance = value;

                    BalanceChangedEventArguments e = new BalanceChangedEventArguments(this, Balance);
                    OnBalanceChanged(this, e);
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// "Account" constructor with 3 parameters (int id, string number, string currency)
        /// </summary>
        /// <param type="int" name="id"></param>
        /// <param type="string" name="number"></param>
        /// <param type="string" name="currency"></param>
        public Account(int id, string number, string currency)
        {
            //TODO Where to attach the handler to the event
            this.OnBalanceChanged += onBalanceChanged;
            this.ID = id;
            this.Number = number;
            this.Currency = currency;

            CurrencyAmount a = new CurrencyAmount();
            a.Amount = 0;
            a.Currency = currency;
            this.Balance = a;
        }

        /// <summary>
        /// "Account" constructor with one parameter who calls the constructor with three parameters (-1, "X", currency)
        /// </summary>
        /// <param type="string" name="currency"></param>
        public Account(string currency)
            : this(-1, "X", currency)
        {
            this.ID = AccountHelper.GenerateAccountId();
            this.Number = GenerateAccountNumber();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Public method "DebitAmount" which returns TransactionStatus and takes one parametar of type CurrencyAmount
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (CheckAmountCurrency(amount) == TransactionStatus.InProcess)
            {
                CurrencyAmount a = this.Balance;
                a.Amount -= amount.Amount;
                this.Balance = a;
                return TransactionStatus.Completed;
            }
            else 
            {
                return TransactionStatus.Failed;
            }
        }

        /// <summary>
        /// Public method CreditAmount which returns TransactionStatus and takes one parameter of type CurrencyAmount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (CheckAmountCurrency(amount) == TransactionStatus.InProcess)
            {
                CurrencyAmount a = this.Balance;
                a.Amount += amount.Amount;
                this.Balance = a;
                return TransactionStatus.Completed;
            }
            else 
            {
                return TransactionStatus.Failed;
            }
        }

        #endregion

        #region Private methods

        //TODO Where to put the OnBalanceChangedHandler
        private void onBalanceChanged(object sender, BalanceChangedEventArguments e)
        {
            Debug.WriteLine("{0} \n{1} \n{2}", e.Account.ID, e.Account.Number, e.Change.Amount);
        }

        /// <summary>
        /// Private method "checkAmountCurrency" which returns TransactionStatus and takes one parameter of type CurrencyAmount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private TransactionStatus CheckAmountCurrency(CurrencyAmount amount)
        {
            if (this.Currency != amount.Currency)
            {
                string ex = string.Format("First currency:{0} \nSecond currency:{1}", this.Currency, amount.Currency);
                throw new CurrencyMismatchException(message: ex);
            }
            return TransactionStatus.InProcess;
        }

        #endregion
    }
}