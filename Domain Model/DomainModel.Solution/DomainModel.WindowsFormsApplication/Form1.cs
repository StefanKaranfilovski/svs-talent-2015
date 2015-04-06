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
            CreateAndPopulateTransactionAccount();
        }

        /// <summary>
        /// Handling the "Click" event on the "Create Deposit Account" button
        /// createDepositAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            CreateAndPopulateDepositAccount();
        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            //TODO Check method implementation
            ITransactionAccount transactonAccount = CreateTransactionAccount();
            IDepositAccount depositAccount = CreateDepositAccount();
            ILoanAccount loanAccount = CreateLoanAccount();
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = 20000;
            ca.Currency = "MKD";

            ITransactionProcessor transactionProcessor = new TransactionProcessor();
            transactionProcessor.ProcessTransaction(TransactionType.Transfer, ca, transactonAccount, depositAccount);

            PopulateTransactionAccountProperties(transactonAccount);
            PopulateDepositAccountProperties(depositAccount);
        }

        #endregion

        #region Account Methods

        private void PopulateAccountProperties(IAccount account)
        {
            CheckAccountType(account);
        }

        private void CheckAccountType(IAccount account)
        {
            if (account is ITransactionAccount)
            {
                PopulateTransactionAccountProperties(account);
            }

            if (account is IDepositAccount)
            {
                PopulateDepositAccountProperties((IDepositAccount)account);
            }
        }

        #endregion

        #region Transaction Account Methods4

        private ITransactionAccount CreateTransactionAccount()
        {
            string currency = txtTransactionAccountCurrency.MakeString();
            decimal amount = txtTransactionAccountLimit.MakeDecimal();

            ITransactionAccount transactionAccount = new TransactionAccount(currency, amount);
            return transactionAccount;
        }

        private void CreateAndPopulateTransactionAccount()
        {
            ITransactionAccount transactionAccount = CreateTransactionAccount();

            PopulateAccountProperties(transactionAccount);
        }

        private void ClearTransactionAccountProperties()
        {
            lblTransactionAccountPropertiesLimitAmount.Text = String.Empty;
            lblTransactionAccountPropertiesLimitCurrency.Text = String.Empty;
        }

        private void PopulateTransactionAccountProperties(IAccount account)
        {
            lblAccountFromPropertiesID.Text = account.ID.ToString();
            lblAccountFromPropertiesNumber.Text = account.Number.ToString();
            lblAccountFromPropertiesCurrencyAmount.Text = account.Currency.ToString();
            lblAccountFromPropertiesBalanceAmount.Text = account.Balance.Amount.ToString();
            lblAccountFromPropertiesBalanceCurrnecyBalance.Text = account.Balance.Currency.ToString();

            lblTransactionAccountPropertiesLimitAmount.Text = account.Balance.Amount.ToString();
            lblTransactionAccountPropertiesLimitCurrency.Text = account.Balance.Currency.ToString();
        }

        #endregion

        #region Deposit Account Methods

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

        private void CreateAndPopulateDepositAccount()
        {
            IDepositAccount depositAccount = CreateDepositAccount();
            PopulateAccountProperties(depositAccount);
        }

        private void ClearDepositAccountProperties()
        {
            lblDepositPropertiesTimePeriodPeriod.Text = String.Empty;
            lblDepositPropertiesTimePeriodUnitOfTime.Text = String.Empty;

            lblDepositPropertiesInterestRatePercent.Text = String.Empty;
            lblDepositPropertiesInterestRateUnitOfTime.Text = String.Empty;

            lblDepositPropertiesStartDate.Text = String.Empty;
            lblDepositPropertiesEndDate.Text = String.Empty;
        }

        private void PopulateDepositAccountProperties(IDepositAccount depositAccount)
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

        #endregion 

        #region Loan Account Methods

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

            return loanAccount;
        }

        #endregion

        #region Utility Methods

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

        #endregion
    }
}
