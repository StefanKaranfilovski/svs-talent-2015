using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Party
{
    /// <summary>
    /// Class that will represent a Person
    /// </summary>
    public class Person
    {
        #region Fields and Properties

        /// <summary>
        /// Each public propertie has a private backing field
        /// </summary>

        private string firstName;
        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string birthDate;
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private string identificationNumber;
        public string IdentificationNumber
        {
            get { return identificationNumber; }
            set { identificationNumber = value; }
        }

        private ITransactionAccount transactionAccount;
        public ITransactionAccount TransactionAccount
        {
            get { return transactionAccount; }
            set { transactionAccount = value; }
        }

        private List<IAccount> accounts;
        public List<IAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        #endregion
    }
}
