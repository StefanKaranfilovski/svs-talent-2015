using DomainModel.Libraries.Enumerations;
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

        /// <summary>
        /// Event handler for the OnBalanceChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //TODO Where to put the handler
        private void onBalanceChanged(object sender, BalanceChangedEventArguments e)
        {
            Debug.WriteLine("{0} \n{1} \n{2}", e.Account.ID, e.Account.Number, e.Change.Amount);
        }

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
        /// Has FormatRestriction attribute
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
        /// In the setter checks if the amount and currency of the new and the old value are the same, if not throws an exeption
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
        /// It checks the currency with CheckAmountCurrency(), if they are the same it reduses the Amount
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
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
        /// It checks the currency with CheckAmountCurrency(), if they are the same it increases the Amount
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
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

        /// <summary>
        /// Checks the currency of the old and the new value, if they are different it throws an exeption
        /// </summary>
        /// <param type=CurrencyAmount name="amount"></param>
        /// <returns>TransactionStatus</returns>
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