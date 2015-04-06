using DomainModel.Libraries.Classes;
using DomainModel.Libraries.Enumerations;
using DomainModel.Libraries.Interfaces;
using DomainModel.Libraries.Processors;
using DomainModel.Libraries.Structures;
using DomainModel.WindowsFormsApplication.Extension_Metods;
using System;
using System.Windows.Forms;

namespace DomainModel.WindowsFormsApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// Handling the "Click" event on the "Create Transaction Account" button
        /// createTransactionAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            createAndPopulateTransactionAccount();
        }

        /// <summary>
        /// Handling the "Click" event on the "Create Deposit Account" button
        /// createDepositAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            createAndPopulateDepositAccount();
        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            //TODO Check method implementation
            ITransactionAccount transactonAccount = createTransactionAccount();
            IDepositAccount depositAccount = createDepositAccount();
            ILoanAccount loanAccount = createLoanAccount();
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = 20000;
            ca.Currency = "MKD";

            ITransactionProcessor transactionProcessor = new TransactionProcessor();
            transactionProcessor.ProcessTransaction(TransactionType.Transfer, ca, loanAccount, depositAccount);

            populateTransactionAccountProperties(transactonAccount);
            populateDepositAccountProperties(depositAccount);
        }

        #endregion

        #region Account Methods

        private void populateAccountProperties(IAccount account)
        {
            //TODO Ask about the implementation
            lblAccountFromPropertiesID.Text = account.ID.ToString();
            lblAccountFromPropertiesNumber.Text = account.Number.ToString();
            lblAccountFromPropertiesCurrencyAmount.Text = account.Currency.ToString();
            lblAccountFromPropertiesBalanceAmount.Text = account.Balance.Amount.ToString();
            lblAccountFromPropertiesBalanceCurrnecyBalance.Text = account.Balance.Currency.ToString();
            
            checkAccountType(account);
        }

        private void checkAccountType(IAccount account)
        {
            if (account is ITransactionAccount)
            {
                populateTransactionAccountProperties(account);
                clearDepositAccountProperties();
            }
            else if (account is IDepositAccount)
            {
                populateDepositAccountProperties((IDepositAccount)account);
                clearTransactionAccountProperties();
            }
        }


        #endregion

        #region Transaction Account Methods4

        private ITransactionAccount createTransactionAccount()
        {
            string currency = txtTransactionAccountCurrency.MakeString();
            decimal amount = txtTransactionAccountLimit.MakeDecimal();

            ITransactionAccount transactionAccount = new TransactionAccount(currency, amount);
            return transactionAccount;
        }

        private void createAndPopulateTransactionAccount()
        {
            ITransactionAccount transactionAccount = createTransactionAccount();

            populateAccountProperties(transactionAccount);
        }

        private void clearTransactionAccountProperties()
        {
            lblTransactionAccountPropertiesLimitAmount.Text = String.Empty;
            lblTransactionAccountPropertiesLimitCurrency.Text = String.Empty;
        }

        private void populateTransactionAccountProperties(IAccount account)
        {
            lblTransactionAccountPropertiesLimitAmount.Text = account.Balance.Amount.ToString();
            lblTransactionAccountPropertiesLimitCurrency.Text = account.Balance.Currency.ToString();
        }

        #endregion

        #region Deposit Account Methods

        private IDepositAccount createDepositAccount()
        {
            //TODO Should I use "new" with structs
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Period = txtDepositAccountTimePeriodPeriod.MakeInt32();
            timePeriod.Unit = setUnitOfTimeFromComboBox(cbDepositAccountTimePeriodUnit.MakeString());

            InterestRate interestRate = new InterestRate();
            interestRate.Percent = txtDepositAccountInterestRatePercent.MakeDecimal();
            interestRate.Unit = setUnitOfTimeFromComboBox(cbDepositAccountInterestRateUnit.MakeString());

            string currency = txtTransactionAccountCurrency.MakeString();
            DateTime startDate = dtpDepositAccountStartDate.MakeDateTime();
            DateTime endDate = dtpDepositAccountEndDate.MakeDateTime();
            ITransactionAccount transactionAccount = createTransactionAccount();
            IDepositAccount depositAccount = new DepositAccount(currency, timePeriod, interestRate, startDate, endDate, transactionAccount);

            return depositAccount;
        }

        private void createAndPopulateDepositAccount()
        {

            IDepositAccount depositAccount = createDepositAccount();
            populateAccountProperties(depositAccount);
        }

        private void clearDepositAccountProperties()
        {
            lblDepositPropertiesTimePeriodPeriod.Text = String.Empty;
            lblDepositPropertiesTimePeriodUnitOfTime.Text = String.Empty;

            lblDepositPropertiesInterestRatePercent.Text = String.Empty;
            lblDepositPropertiesInterestRateUnitOfTime.Text = String.Empty;

            lblDepositPropertiesStartDate.Text = String.Empty;
            lblDepositPropertiesEndDate.Text = String.Empty;
        }

        private void populateDepositAccountProperties(IDepositAccount depositAccount)
        {
            lblDepositPropertiesTimePeriodPeriod.Text = depositAccount.Period.Period.ToString();
            lblDepositPropertiesTimePeriodUnitOfTime.Text = depositAccount.Period.Unit.ToString();

            lblDepositPropertiesInterestRatePercent.Text = depositAccount.Interest.Percent.ToString();
            lblDepositPropertiesInterestRateUnitOfTime.Text = depositAccount.Interest.Unit.ToString();

            lblDepositPropertiesStartDate.Text = depositAccount.StartDate.ToShortDateString();
            lblDepositPropertiesEndDate.Text = depositAccount.EndDate.ToShortDateString();
        }

        #endregion 

        #region Loan Account Methods

        private ILoanAccount createLoanAccount()
        {
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Period = txtDepositAccountTimePeriodPeriod.MakeInt32();
            timePeriod.Unit = setUnitOfTimeFromComboBox(cbDepositAccountTimePeriodUnit.MakeString());

            InterestRate interestRate = new InterestRate();
            interestRate.Percent = txtDepositAccountInterestRatePercent.MakeDecimal();
            interestRate.Unit = setUnitOfTimeFromComboBox(cbDepositAccountInterestRateUnit.MakeString());

            string currency = txtTransactionAccountCurrency.MakeString();
            DateTime startDate = dtpDepositAccountStartDate.MakeDateTime();
            DateTime endDate = dtpDepositAccountEndDate.MakeDateTime();
            ITransactionAccount transactionAccount = createTransactionAccount();
            ILoanAccount loanAccount = new LoanAccount(currency, timePeriod, interestRate, startDate, endDate, transactionAccount);

            return loanAccount;
        }

        #endregion

        #region Utility Methods

        private UnitOfTime setUnitOfTimeFromComboBox(string s)
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

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
