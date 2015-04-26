using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Processors;
using DomainModel.Libraries.Structures;
using DomainModel.WindowsFormsApplication.Extension_Metods;
using DomainModel.Libraries.Extension_Methods;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DomainModel.Libraries.Party;
using System.Text;

namespace DomainModel.WindowsFormsApplication
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Holds the number of calls to the anonymous method
        /// </summary>
        private int countAnonymousMethodCalls = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// Handling the "Click" event on the "Create Person" button
        /// Creates new Person object and populates the specific textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            Person person = CreatePerson();

            PopulatePerson(person);
        }

        /// <summary>
        /// Handling the "Click" event on the "Create Transaction Account" button
        /// CreateTransactionAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            CreateAndPopulateTransactionAccount();
        }

        /// <summary>
        /// Handling the "Click" event on the "Create Deposit Account" button
        /// CreateDepositAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            CreateAndPopulateDepositAccount();
        }

        /// <summary>
        /// Handling the "Click" event on the "Make Transaction" button
        /// MakeTransaction method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            MakeTransaction();
        }

        /// <summary>
        /// Handling the "Click" event on the "Charge Fee" button
        /// ChargeFee method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            ChargeFee();
        }

        /// <summary>
        /// Handling the "Click" event on the "Make Group Transaction" button
        /// MakeGroupTransaction method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            MakeGroupTransaction();
        }

        #endregion

        #region Account Methods

        /// <summary>
        /// This method checks the account type and calls the appropriate method to populate the account
        /// </summary>
        /// <param type="IAccount" name="account"></param>
        private void PopulateAccountProperties(IAccount account)
        {
            if (account is ITransactionAccount)
            {
                PopulateAccountFromProperties(account);
            }

            if (account is IDepositAccount)
            {
                PopulateAccountToProperties((IDepositAccount)account);
            }
        }

        /// <summary>
        /// This method fills the Account To specific labels
        /// </summary>
        /// <param type="IDepositAccount" name="depositAccount"></param>
        private void PopulateAccountToProperties(IDepositAccount depositAccount)
        {
            lblAccountToPropertiesID.Text = depositAccount.ID.ToString();
            lblAccountToPropertiesNumber.Text = depositAccount.Number.ToString();
            lblAccountToPropertiesCurrencyAmount.Text = depositAccount.Currency.ToString();
            lblAccountToPropertiesBalanceAmount.Text = depositAccount.Balance.Amount.ToString();
            lblAccountToPropertiesBalanceCurrencyBalance.Text = depositAccount.Balance.Currency.ToString();

            lblDepositPropertiesTimePeriodPeriod.Text = depositAccount.Period.Period.ToString();
            lblDepositPropertiesTimePeriodUnitOfTime.Text = depositAccount.Period.Unit.ToString();

            lblDepositPropertiesInterestRatePercent.Text = depositAccount.Interest.Percent.ToString();
            lblDepositPropertiesInterestRateUnitOfTime.Text = depositAccount.Interest.Unit.ToString();

            lblDepositPropertiesStartDate.Text = depositAccount.StartDate.ToShortDateString();
            lblDepositPropertiesEndDate.Text = depositAccount.EndDate.ToShortDateString();
        }

        /// <summary>
        /// This method fills the Account From specific labels
        /// </summary>
        /// <param type="IAccount" name="account"></param>
        private void PopulateAccountFromProperties(IAccount account)
        {
            lblAccountFromPropertiesID.Text = account.ID.ToString();
            lblAccountFromPropertiesNumber.Text = account.Number.ToString();
            lblAccountFromPropertiesCurrencyAmount.Text = account.Currency.ToString();
            lblAccountFromPropertiesBalanceAmount.Text = account.Balance.Amount.ToString();
            lblAccountFromPropertiesBalanceCurrnecyBalance.Text = account.Balance.Currency.ToString();

            lblTransactionAccountPropertiesLimitAmount.Text = account.Balance.Amount.ToString();
            lblTransactionAccountPropertiesLimitCurrency.Text = account.Balance.Currency.ToString();
        }

        /// <summary>
        /// This method creates the accounts that are specified in the flags enum by checking which types are checked in the enum
        /// </summary>
        /// <param type="CreateAccountType" name="typesToCreate"></param>
        /// <returns>Dictionary<CreateAccountType, IAccount></returns>
        //TODO What is the second parameter used for?
        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType typesToCreate)
        {
            var createAccounts = new Dictionary<CreateAccountType, IAccount>();

            if (typesToCreate.HasFlag(CreateAccountType.TransactionAccount))
            {
                ITransactionAccount newTransactionAccount = CreateTransactionAccount();
                createAccounts.Add(CreateAccountType.TransactionAccount, newTransactionAccount);
            }
            if (typesToCreate.HasFlag(CreateAccountType.DepositAccount))
            {
                IDepositAccount newDepositAccount = CreateDepositAccount();
                createAccounts.Add(CreateAccountType.DepositAccount, newDepositAccount);
            }
            if (typesToCreate.HasFlag(CreateAccountType.LoanAccount))
            {
                ILoanAccount newLoanAccount = CreateLoanAccount();
                createAccounts.Add(CreateAccountType.LoanAccount, newLoanAccount);
            }
            return createAccounts;
        }

        #endregion

        #region Transaction Account Methods

        /// <summary>
        /// Creates new ITransactionAccount account
        /// </summary>
        /// <returns>ITransactionAccount</returns>
        private ITransactionAccount CreateTransactionAccount()
        {
            string currency = txtTransactionAccountCurrency.MakeString();
            decimal amount = txtTransactionAccountLimit.MakeDecimal();

            ITransactionAccount transactionAccount = new TransactionAccount(currency, amount);
            return transactionAccount;
        }

        /// <summary>
        /// Creates new ITransactionAccount by calling the CreateTransactionAccount(), and calls PopulateAccountProperties() to populate the specific labels
        /// </summary>
        private void CreateAndPopulateTransactionAccount()
        {
            ITransactionAccount transactionAccount = CreateTransactionAccount();

            PopulateAccountProperties(transactionAccount);
        }

        /// <summary>
        /// Clears the Transactin Account specific labels
        /// </summary>
        private void ClearTransactionAccountProperties()
        {
            lblTransactionAccountPropertiesLimitAmount.Text = String.Empty;
            lblTransactionAccountPropertiesLimitCurrency.Text = String.Empty;
        }

        #endregion

        #region Deposit Account Methods

        /// <summary>
        /// Creates new IDepositAccount account
        /// </summary>
        /// <returns>IDepositAccount</returns>
        private IDepositAccount CreateDepositAccount()
        {
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Period = txtDepositAccountTimePeriodPeriod.MakeInt32();
            timePeriod.Unit = SetUnitOfTimeFromComboBox(cbDepositAccountTimePeriodUnit.MakeString());

            InterestRate interestRate = new InterestRate();
            interestRate.Percent = txtDepositAccountInterestRatePercent.MakeDecimal();
            interestRate.Unit = SetUnitOfTimeFromComboBox(cbDepositAccountInterestRateUnit.MakeString());

            string currency = txtTransactionAccountCurrency.MakeString();
            DateTime startDate = dtpDepositAccountStartDate.MakeDateTime();
            DateTime endDate = dtpDepositAccountEndDate.MakeDateTime();
            ITransactionAccount transactionAccount = CreateTransactionAccount();
            IDepositAccount depositAccount = new DepositAccount(currency, timePeriod, interestRate, startDate, endDate, transactionAccount);

            return depositAccount;
        }

        /// <summary>
        /// Creates new IDepositAccount account by calling the CreateDepositAccount(), and calls the PopulateAccountProperties() to populate the specific labels
        /// </summary>
        private void CreateAndPopulateDepositAccount()
        {
            IDepositAccount depositAccount = CreateDepositAccount();
            PopulateAccountProperties(depositAccount);
        }

        /// <summary>
        /// Clears the Deposit Account specific labels
        /// </summary>
        private void ClearDepositAccountProperties()
        {
            lblDepositPropertiesTimePeriodPeriod.Text = String.Empty;
            lblDepositPropertiesTimePeriodUnitOfTime.Text = String.Empty;

            lblDepositPropertiesInterestRatePercent.Text = String.Empty;
            lblDepositPropertiesInterestRateUnitOfTime.Text = String.Empty;

            lblDepositPropertiesStartDate.Text = String.Empty;
            lblDepositPropertiesEndDate.Text = String.Empty;
        }

        #endregion 

        #region Loan Account Methods

        /// <summary>
        /// Creates new ILoanAccount accoung
        /// </summary>
        /// <returns>ILoanAccount</returns>
        private ILoanAccount CreateLoanAccount()
        {
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Period = txtDepositAccountTimePeriodPeriod.MakeInt32();
            timePeriod.Unit = SetUnitOfTimeFromComboBox(cbDepositAccountTimePeriodUnit.MakeString());
            
            InterestRate interestRate = new InterestRate();
            interestRate.Percent = txtDepositAccountInterestRatePercent.MakeDecimal();
            interestRate.Unit = SetUnitOfTimeFromComboBox(cbDepositAccountInterestRateUnit.MakeString());

            string currency = txtTransactionAccountCurrency.MakeString();
            DateTime startDate = dtpDepositAccountStartDate.MakeDateTime();
            DateTime endDate = dtpDepositAccountEndDate.MakeDateTime();
            ITransactionAccount transactionAccount = CreateTransactionAccount();
            ILoanAccount loanAccount = new LoanAccount(currency, timePeriod, interestRate, startDate, endDate, transactionAccount);
            
            // Setting an anonymous method on the OnBalanceChanged event
            loanAccount.OnBalanceChanged += delegate
            {
                Debug.WriteLine("The balance of the loan account has been changed.");
                countAnonymousMethodCalls++;
                Debug.WriteLine("The anonymous method has been called " + countAnonymousMethodCalls + " times");
            };

            return loanAccount;
        }

        #endregion

        #region Utility Methods

        /// <summary>
        /// Returns Unit of time value depending on the text in the combobox
        /// </summary>
        /// <param type=string name="s"></param>
        /// <returns>UnitOfTime</returns>
        private UnitOfTime SetUnitOfTimeFromComboBox(string s)
        {
            switch (s.ToLower())
            {
                case "day":
                    return UnitOfTime.Day;
                case "month":
                    return UnitOfTime.Month;
                case "year":
                    return UnitOfTime.Year;
                default:
                    return UnitOfTime.NothingSelected;
            }
        }

        /// <summary>
        /// Charges fee to DepositAccount and LoanAccount using the ChargeProcessingFee() extension method on the TransactionProcessor class
        /// </summary>
        //TODO Check the method implementation
        private void ChargeFee()
        {
            IAccount[] accounts = new IAccount[2];

            CreateAccountType types = CreateAccountType.DepositAccount | CreateAccountType.LoanAccount;
            Dictionary<CreateAccountType, IAccount> accountsFromDictionary = CreateAccounts(types);

            CurrencyAmount amount = new CurrencyAmount { Amount = 15, Currency = "MKD" };

            accounts[0] = accountsFromDictionary[CreateAccountType.DepositAccount];
            accounts[1] = accountsFromDictionary[CreateAccountType.LoanAccount];

            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            transactionProcessor.ChargeProcessingFee(amount, accounts);
            DisplayLastTransactionDetails();
        }

        #endregion

        #region Transactions

        /// <summary>
        /// Makes a transaction between two accounts and displays the Last Transaction in the specific labels using the DisplayLastTransactionDetails()
        /// </summary>
        private void MakeTransaction()
        {
            ITransactionAccount transactonAccount = CreateTransactionAccount();
            IDepositAccount depositAccount = CreateDepositAccount();
            ILoanAccount loanAccount = CreateLoanAccount();
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = txtTransactionDetailsAmount.MakeDecimal();
            ca.Currency = txtTransactionDetailsCurrency.MakeString();

            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();

            bool _errorOccured = false;
            string _errorMsg = "No error";

            try
            {
                transactionProcessor.ProcessTransaction(TransactionType.Transfer, ca, transactonAccount, depositAccount);
            }
            catch (CurrencyMismatchException ex)
            {
                _errorOccured = true;
                _errorMsg = ex.Message;
            }
            catch (ApplicationException)
            {
                throw;
            }
            finally
            {
                //if (_errorOccured)
                //{
                //    MessageBox.Show(_errorMsg);
                //}
            }
            var anonymousVariable = new { FromAccount = transactonAccount, ToAccount = depositAccount, 
                                          Amount = ca, HasError = _errorOccured, ErrorMessage = _errorMsg };

            if (anonymousVariable.HasError) 
            {
                MessageBox.Show(anonymousVariable.ErrorMessage);
            }
            else
            {
                var msgbox = "Account from: " + anonymousVariable.FromAccount + " \nAccount to: " + anonymousVariable.ToAccount + " \nTransaction amount: " + anonymousVariable.Amount.Amount;
                MessageBox.Show(msgbox);
            }

            DisplayLastTransactionDetails();
        }

        /// <summary>
        /// Makes a group transaction using flags enum and displays the Last Transaction details using the DisplayLastTransactionDetails()
        /// </summary>
        private void MakeGroupTransaction()
        {
            //CreateAccountType types = CreateAccountType.TransactionAccount;
            //CreateAccounts(types);
            IAccount[] accounts = new IAccount[2];

            CreateAccountType types = CreateAccountType.DepositAccount | CreateAccountType.LoanAccount;
            Dictionary<CreateAccountType, IAccount> accountsFromDictionary = CreateAccounts(types);

            //IDepositAccount depositAccount = CreateDepositAccount();
            //ILoanAccount loanAccount = CreateLoanAccount();
            CurrencyAmount amount = new CurrencyAmount { Amount = 12345, Currency = "MKD" };

            accounts[0] = accountsFromDictionary[CreateAccountType.DepositAccount];
            accounts[1] = accountsFromDictionary[CreateAccountType.LoanAccount];

            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            transactionProcessor.ProcessGroupTransaction(TransactionType.Debit, amount, accounts);
            DisplayLastTransactionDetails();
        }

        /// <summary>
        /// It takes the last transaction in TransactionProcessor with indexer and displays its details in the specific labels
        /// </summary>
        private void DisplayLastTransactionDetails()
        {
            ITransactionProcessor processor = TransactionProcessor.GetTransactionProcessor();
            TransactionLogEntry lastEntry = processor[processor.TransactionCount -1];

            lblLogEntryType.Text = lastEntry.TransactionType.ToString();
            lblLogEntryStatus.Text = lastEntry.Status.ToString();
            lblLogEntryCurrencyAmountAmount.Text = lastEntry.Amount.Amount.ToString();
            lblLogEntryCurrnecyAmountCurrency.Text = lastEntry.Amount.Currency.ToString();

            lblTransactionCount.Text = processor.TransactionCount.ToString();

            IAccount[] accounts = lastEntry.Accounts;
            PopulateAccountFromProperties(accounts[0]);
            PopulateAccountToProperties((IDepositAccount)accounts[1]);
        }

        #endregion
        
        #region Person Methods

        /// <summary>
        /// Populates the Person object specific textboxes
        /// </summary>
        /// <param type=Person name="person"></param>
        private void PopulatePerson(Person person)
        {
            txtPersonFirstName.Text = person.FirstName;
            txtPersonLastName.Text = person.LastName;
            txtPersonBirthDate.Text = person.BirthDate;
            txtPersonIdNumber.Text = person.IdentificationNumber;

            txtPersonTransactionAmount.Text = person.TransactionAccount.Limit.Amount.ToString();
            txtPersonTransactionCurrency.Text = person.TransactionAccount.Limit.Currency.ToString();

            // Foreach account in Accounts it adds new anonymous object to the listbox
            foreach (IAccount account in person.Accounts)
            {
                lbPersonAccounts.Items.Add(new { account.ID, account.Number });
            }
        }

        /// <summary>
        /// Creates new Person object using object and collection initiliazers
        /// </summary>
        /// <returns>Person</returns>
        private Person CreatePerson()
        {
            var accounts = new List<IAccount> { CreateDepositAccount(), CreateLoanAccount() };
            var person = new Person
            {
                FirstName = "Stefan",
                LastName = "Karanfilovski",
                BirthDate = "13/08/1990",
                IdentificationNumber = "1",
                TransactionAccount = CreateTransactionAccount(),
                Accounts = accounts
            };
            return person;
        }

        #endregion
    }
}
