namespace DomainModel.WindowsFormsApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtTransactionAccountCurrency = new System.Windows.Forms.TextBox();
            this.txtTransactionAccountLimit = new System.Windows.Forms.TextBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.gbCreateDepositAccount = new System.Windows.Forms.GroupBox();
            this.gbInterestRateDepositAccount = new System.Windows.Forms.GroupBox();
            this.lblUnitOfTimeInterestRate = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.cbDepositAccountInterestRateUnit = new System.Windows.Forms.ComboBox();
            this.txtDepositAccountInterestRatePercent = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpDepositAccountEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepositAccountStartDate = new System.Windows.Forms.DateTimePicker();
            this.gbTimePeriodDepositAccount = new System.Windows.Forms.GroupBox();
            this.lblUnitOfTimeTimePeriod = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cbDepositAccountTimePeriodUnit = new System.Windows.Forms.ComboBox();
            this.txtDepositAccountTimePeriodPeriod = new System.Windows.Forms.TextBox();
            this.gbAccountFromProperties = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBalance = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccountFromPropertiesBalanceCurrnecyBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountFromPropertiesBalanceAmount = new System.Windows.Forms.Label();
            this.lblAccountFromPropertiesCurrencyAmount = new System.Windows.Forms.Label();
            this.lblAccountFromPropertiesNumber = new System.Windows.Forms.Label();
            this.lblAccountFromPropertiesID = new System.Windows.Forms.Label();
            this.gbTransactionAccountProperties = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTransactionAccountPropertiesLimitCurrency = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTransactionAccountPropertiesLimitAmount = new System.Windows.Forms.Label();
            this.gbDepositAccountProperties = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDepositPropertiesEndDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDepositPropertiesStartDate = new System.Windows.Forms.Label();
            this.gbInterestRateDepositProperties = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDepositPropertiesInterestRateUnitOfTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDepositPropertiesInterestRatePercent = new System.Windows.Forms.Label();
            this.gbTImePeriodDepositProperties = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDepositPropertiesTimePeriodUnitOfTime = new System.Windows.Forms.Label();
            this.lblDepositPropertiesTimePeriodPeriod = new System.Windows.Forms.Label();
            this.gbCreateTransactionAccount = new System.Windows.Forms.GroupBox();
            this.gbAccountToProperties = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAccountToPropertiesBalanceCurrencyBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAccountToPropertiesBalanceAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAccountToPropertiesCurrencyAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccountToPropertiesNumber = new System.Windows.Forms.Label();
            this.lblAccountToPropertiesID = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTransactionCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblLogEntryCurrnecyAmountCurrency = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblLogEntryCurrencyAmountAmount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblLogEntryStatus = new System.Windows.Forms.Label();
            this.lblLogEntryType = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTransactionDetailsAmount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTransactionDetailsCurrency = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnChargeFee = new System.Windows.Forms.Button();
            this.gbCreateDepositAccount.SuspendLayout();
            this.gbInterestRateDepositAccount.SuspendLayout();
            this.gbTimePeriodDepositAccount.SuspendLayout();
            this.gbAccountFromProperties.SuspendLayout();
            this.gbBalance.SuspendLayout();
            this.gbTransactionAccountProperties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDepositAccountProperties.SuspendLayout();
            this.gbInterestRateDepositProperties.SuspendLayout();
            this.gbTImePeriodDepositProperties.SuspendLayout();
            this.gbCreateTransactionAccount.SuspendLayout();
            this.gbAccountToProperties.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(6, 71);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(168, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(6, 219);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(168, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtTransactionAccountCurrency
            // 
            this.txtTransactionAccountCurrency.Location = new System.Drawing.Point(12, 41);
            this.txtTransactionAccountCurrency.Name = "txtTransactionAccountCurrency";
            this.txtTransactionAccountCurrency.Size = new System.Drawing.Size(94, 20);
            this.txtTransactionAccountCurrency.TabIndex = 2;
            this.txtTransactionAccountCurrency.Text = "MKD";
            this.txtTransactionAccountCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransactionAccountLimit
            // 
            this.txtTransactionAccountLimit.Location = new System.Drawing.Point(12, 17);
            this.txtTransactionAccountLimit.Name = "txtTransactionAccountLimit";
            this.txtTransactionAccountLimit.Size = new System.Drawing.Size(94, 20);
            this.txtTransactionAccountLimit.TabIndex = 3;
            this.txtTransactionAccountLimit.Text = "10000";
            this.txtTransactionAccountLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(112, 20);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(28, 13);
            this.lblLimit.TabIndex = 4;
            this.lblLimit.Text = "Limit";
            this.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(112, 44);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 5;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCreateDepositAccount
            // 
            this.gbCreateDepositAccount.Controls.Add(this.gbInterestRateDepositAccount);
            this.gbCreateDepositAccount.Controls.Add(this.lblEndDate);
            this.gbCreateDepositAccount.Controls.Add(this.lblStartDate);
            this.gbCreateDepositAccount.Controls.Add(this.dtpDepositAccountEndDate);
            this.gbCreateDepositAccount.Controls.Add(this.dtpDepositAccountStartDate);
            this.gbCreateDepositAccount.Controls.Add(this.btnCreateDepositAccount);
            this.gbCreateDepositAccount.Controls.Add(this.gbTimePeriodDepositAccount);
            this.gbCreateDepositAccount.Location = new System.Drawing.Point(12, 118);
            this.gbCreateDepositAccount.Name = "gbCreateDepositAccount";
            this.gbCreateDepositAccount.Size = new System.Drawing.Size(181, 249);
            this.gbCreateDepositAccount.TabIndex = 6;
            this.gbCreateDepositAccount.TabStop = false;
            this.gbCreateDepositAccount.Text = "Create deposit account:";
            // 
            // gbInterestRateDepositAccount
            // 
            this.gbInterestRateDepositAccount.Controls.Add(this.lblUnitOfTimeInterestRate);
            this.gbInterestRateDepositAccount.Controls.Add(this.lblPercent);
            this.gbInterestRateDepositAccount.Controls.Add(this.cbDepositAccountInterestRateUnit);
            this.gbInterestRateDepositAccount.Controls.Add(this.txtDepositAccountInterestRatePercent);
            this.gbInterestRateDepositAccount.Location = new System.Drawing.Point(6, 93);
            this.gbInterestRateDepositAccount.Name = "gbInterestRateDepositAccount";
            this.gbInterestRateDepositAccount.Size = new System.Drawing.Size(168, 68);
            this.gbInterestRateDepositAccount.TabIndex = 8;
            this.gbInterestRateDepositAccount.TabStop = false;
            this.gbInterestRateDepositAccount.Text = "Interest rate:";
            // 
            // lblUnitOfTimeInterestRate
            // 
            this.lblUnitOfTimeInterestRate.AutoSize = true;
            this.lblUnitOfTimeInterestRate.Location = new System.Drawing.Point(106, 44);
            this.lblUnitOfTimeInterestRate.Name = "lblUnitOfTimeInterestRate";
            this.lblUnitOfTimeInterestRate.Size = new System.Drawing.Size(60, 13);
            this.lblUnitOfTimeInterestRate.TabIndex = 7;
            this.lblUnitOfTimeInterestRate.Text = "Unit of time";
            this.lblUnitOfTimeInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(106, 20);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(44, 13);
            this.lblPercent.TabIndex = 6;
            this.lblPercent.Text = "Percent";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDepositAccountInterestRateUnit
            // 
            this.cbDepositAccountInterestRateUnit.FormattingEnabled = true;
            this.cbDepositAccountInterestRateUnit.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbDepositAccountInterestRateUnit.Location = new System.Drawing.Point(6, 41);
            this.cbDepositAccountInterestRateUnit.Name = "cbDepositAccountInterestRateUnit";
            this.cbDepositAccountInterestRateUnit.Size = new System.Drawing.Size(94, 21);
            this.cbDepositAccountInterestRateUnit.TabIndex = 5;
            // 
            // txtDepositAccountInterestRatePercent
            // 
            this.txtDepositAccountInterestRatePercent.Location = new System.Drawing.Point(6, 17);
            this.txtDepositAccountInterestRatePercent.Name = "txtDepositAccountInterestRatePercent";
            this.txtDepositAccountInterestRatePercent.Size = new System.Drawing.Size(94, 20);
            this.txtDepositAccountInterestRatePercent.TabIndex = 4;
            this.txtDepositAccountInterestRatePercent.Text = "2";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(112, 199);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(50, 13);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End date";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(112, 173);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(53, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDepositAccountEndDate
            // 
            this.dtpDepositAccountEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepositAccountEndDate.Location = new System.Drawing.Point(12, 193);
            this.dtpDepositAccountEndDate.Name = "dtpDepositAccountEndDate";
            this.dtpDepositAccountEndDate.Size = new System.Drawing.Size(94, 20);
            this.dtpDepositAccountEndDate.TabIndex = 5;
            // 
            // dtpDepositAccountStartDate
            // 
            this.dtpDepositAccountStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepositAccountStartDate.Location = new System.Drawing.Point(12, 167);
            this.dtpDepositAccountStartDate.Name = "dtpDepositAccountStartDate";
            this.dtpDepositAccountStartDate.Size = new System.Drawing.Size(94, 20);
            this.dtpDepositAccountStartDate.TabIndex = 4;
            // 
            // gbTimePeriodDepositAccount
            // 
            this.gbTimePeriodDepositAccount.Controls.Add(this.lblUnitOfTimeTimePeriod);
            this.gbTimePeriodDepositAccount.Controls.Add(this.lblPeriod);
            this.gbTimePeriodDepositAccount.Controls.Add(this.cbDepositAccountTimePeriodUnit);
            this.gbTimePeriodDepositAccount.Controls.Add(this.txtDepositAccountTimePeriodPeriod);
            this.gbTimePeriodDepositAccount.Location = new System.Drawing.Point(6, 19);
            this.gbTimePeriodDepositAccount.Name = "gbTimePeriodDepositAccount";
            this.gbTimePeriodDepositAccount.Size = new System.Drawing.Size(168, 68);
            this.gbTimePeriodDepositAccount.TabIndex = 0;
            this.gbTimePeriodDepositAccount.TabStop = false;
            this.gbTimePeriodDepositAccount.Text = "Time period:";
            // 
            // lblUnitOfTimeTimePeriod
            // 
            this.lblUnitOfTimeTimePeriod.AutoSize = true;
            this.lblUnitOfTimeTimePeriod.Location = new System.Drawing.Point(106, 44);
            this.lblUnitOfTimeTimePeriod.Name = "lblUnitOfTimeTimePeriod";
            this.lblUnitOfTimeTimePeriod.Size = new System.Drawing.Size(60, 13);
            this.lblUnitOfTimeTimePeriod.TabIndex = 3;
            this.lblUnitOfTimeTimePeriod.Text = "Unit of time";
            this.lblUnitOfTimeTimePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(106, 20);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(37, 13);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Period";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDepositAccountTimePeriodUnit
            // 
            this.cbDepositAccountTimePeriodUnit.FormattingEnabled = true;
            this.cbDepositAccountTimePeriodUnit.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbDepositAccountTimePeriodUnit.Location = new System.Drawing.Point(6, 41);
            this.cbDepositAccountTimePeriodUnit.Name = "cbDepositAccountTimePeriodUnit";
            this.cbDepositAccountTimePeriodUnit.Size = new System.Drawing.Size(94, 21);
            this.cbDepositAccountTimePeriodUnit.TabIndex = 1;
            // 
            // txtDepositAccountTimePeriodPeriod
            // 
            this.txtDepositAccountTimePeriodPeriod.Location = new System.Drawing.Point(6, 17);
            this.txtDepositAccountTimePeriodPeriod.Name = "txtDepositAccountTimePeriodPeriod";
            this.txtDepositAccountTimePeriodPeriod.Size = new System.Drawing.Size(94, 20);
            this.txtDepositAccountTimePeriodPeriod.TabIndex = 0;
            this.txtDepositAccountTimePeriodPeriod.Text = "1";
            // 
            // gbAccountFromProperties
            // 
            this.gbAccountFromProperties.Controls.Add(this.label3);
            this.gbAccountFromProperties.Controls.Add(this.label2);
            this.gbAccountFromProperties.Controls.Add(this.label1);
            this.gbAccountFromProperties.Controls.Add(this.gbBalance);
            this.gbAccountFromProperties.Controls.Add(this.lblAccountFromPropertiesCurrencyAmount);
            this.gbAccountFromProperties.Controls.Add(this.lblAccountFromPropertiesNumber);
            this.gbAccountFromProperties.Controls.Add(this.lblAccountFromPropertiesID);
            this.gbAccountFromProperties.Location = new System.Drawing.Point(377, 12);
            this.gbAccountFromProperties.Name = "gbAccountFromProperties";
            this.gbAccountFromProperties.Size = new System.Drawing.Size(172, 142);
            this.gbAccountFromProperties.TabIndex = 7;
            this.gbAccountFromProperties.TabStop = false;
            this.gbAccountFromProperties.Text = "Account From properties:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Currency";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBalance
            // 
            this.gbBalance.Controls.Add(this.label5);
            this.gbBalance.Controls.Add(this.lblAccountFromPropertiesBalanceCurrnecyBalance);
            this.gbBalance.Controls.Add(this.label4);
            this.gbBalance.Controls.Add(this.lblAccountFromPropertiesBalanceAmount);
            this.gbBalance.Location = new System.Drawing.Point(6, 80);
            this.gbBalance.Name = "gbBalance";
            this.gbBalance.Size = new System.Drawing.Size(160, 56);
            this.gbBalance.TabIndex = 3;
            this.gbBalance.TabStop = false;
            this.gbBalance.Text = "Balance:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Currency";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountFromPropertiesBalanceCurrnecyBalance
            // 
            this.lblAccountFromPropertiesBalanceCurrnecyBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountFromPropertiesBalanceCurrnecyBalance.Location = new System.Drawing.Point(62, 36);
            this.lblAccountFromPropertiesBalanceCurrnecyBalance.Name = "lblAccountFromPropertiesBalanceCurrnecyBalance";
            this.lblAccountFromPropertiesBalanceCurrnecyBalance.Size = new System.Drawing.Size(94, 15);
            this.lblAccountFromPropertiesBalanceCurrnecyBalance.TabIndex = 4;
            this.lblAccountFromPropertiesBalanceCurrnecyBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountFromPropertiesBalanceAmount
            // 
            this.lblAccountFromPropertiesBalanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountFromPropertiesBalanceAmount.Location = new System.Drawing.Point(62, 16);
            this.lblAccountFromPropertiesBalanceAmount.Name = "lblAccountFromPropertiesBalanceAmount";
            this.lblAccountFromPropertiesBalanceAmount.Size = new System.Drawing.Size(94, 15);
            this.lblAccountFromPropertiesBalanceAmount.TabIndex = 3;
            this.lblAccountFromPropertiesBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountFromPropertiesCurrencyAmount
            // 
            this.lblAccountFromPropertiesCurrencyAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountFromPropertiesCurrencyAmount.Location = new System.Drawing.Point(68, 56);
            this.lblAccountFromPropertiesCurrencyAmount.Name = "lblAccountFromPropertiesCurrencyAmount";
            this.lblAccountFromPropertiesCurrencyAmount.Size = new System.Drawing.Size(94, 15);
            this.lblAccountFromPropertiesCurrencyAmount.TabIndex = 2;
            this.lblAccountFromPropertiesCurrencyAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountFromPropertiesNumber
            // 
            this.lblAccountFromPropertiesNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountFromPropertiesNumber.Location = new System.Drawing.Point(68, 36);
            this.lblAccountFromPropertiesNumber.Name = "lblAccountFromPropertiesNumber";
            this.lblAccountFromPropertiesNumber.Size = new System.Drawing.Size(94, 15);
            this.lblAccountFromPropertiesNumber.TabIndex = 1;
            this.lblAccountFromPropertiesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountFromPropertiesID
            // 
            this.lblAccountFromPropertiesID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountFromPropertiesID.Location = new System.Drawing.Point(68, 16);
            this.lblAccountFromPropertiesID.Name = "lblAccountFromPropertiesID";
            this.lblAccountFromPropertiesID.Size = new System.Drawing.Size(94, 15);
            this.lblAccountFromPropertiesID.TabIndex = 0;
            this.lblAccountFromPropertiesID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbTransactionAccountProperties
            // 
            this.gbTransactionAccountProperties.Controls.Add(this.groupBox1);
            this.gbTransactionAccountProperties.Location = new System.Drawing.Point(199, 12);
            this.gbTransactionAccountProperties.Name = "gbTransactionAccountProperties";
            this.gbTransactionAccountProperties.Size = new System.Drawing.Size(172, 79);
            this.gbTransactionAccountProperties.TabIndex = 8;
            this.gbTransactionAccountProperties.TabStop = false;
            this.gbTransactionAccountProperties.Text = "Transaction account properties:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblTransactionAccountPropertiesLimitCurrency);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblTransactionAccountPropertiesLimitAmount);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency amount:";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Currency";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransactionAccountPropertiesLimitCurrency
            // 
            this.lblTransactionAccountPropertiesLimitCurrency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransactionAccountPropertiesLimitCurrency.Location = new System.Drawing.Point(62, 36);
            this.lblTransactionAccountPropertiesLimitCurrency.Name = "lblTransactionAccountPropertiesLimitCurrency";
            this.lblTransactionAccountPropertiesLimitCurrency.Size = new System.Drawing.Size(94, 15);
            this.lblTransactionAccountPropertiesLimitCurrency.TabIndex = 1;
            this.lblTransactionAccountPropertiesLimitCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Amount";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransactionAccountPropertiesLimitAmount
            // 
            this.lblTransactionAccountPropertiesLimitAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransactionAccountPropertiesLimitAmount.Location = new System.Drawing.Point(62, 16);
            this.lblTransactionAccountPropertiesLimitAmount.Name = "lblTransactionAccountPropertiesLimitAmount";
            this.lblTransactionAccountPropertiesLimitAmount.Size = new System.Drawing.Size(94, 15);
            this.lblTransactionAccountPropertiesLimitAmount.TabIndex = 0;
            this.lblTransactionAccountPropertiesLimitAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDepositAccountProperties
            // 
            this.gbDepositAccountProperties.Controls.Add(this.label15);
            this.gbDepositAccountProperties.Controls.Add(this.lblDepositPropertiesEndDate);
            this.gbDepositAccountProperties.Controls.Add(this.label16);
            this.gbDepositAccountProperties.Controls.Add(this.lblDepositPropertiesStartDate);
            this.gbDepositAccountProperties.Controls.Add(this.gbInterestRateDepositProperties);
            this.gbDepositAccountProperties.Controls.Add(this.gbTImePeriodDepositProperties);
            this.gbDepositAccountProperties.Location = new System.Drawing.Point(199, 118);
            this.gbDepositAccountProperties.Name = "gbDepositAccountProperties";
            this.gbDepositAccountProperties.Size = new System.Drawing.Size(172, 180);
            this.gbDepositAccountProperties.TabIndex = 9;
            this.gbDepositAccountProperties.TabStop = false;
            this.gbDepositAccountProperties.Text = "Deposit account properties:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "End";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepositPropertiesEndDate
            // 
            this.lblDepositPropertiesEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositPropertiesEndDate.Location = new System.Drawing.Point(68, 160);
            this.lblDepositPropertiesEndDate.Name = "lblDepositPropertiesEndDate";
            this.lblDepositPropertiesEndDate.Size = new System.Drawing.Size(94, 15);
            this.lblDepositPropertiesEndDate.TabIndex = 3;
            this.lblDepositPropertiesEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Start";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepositPropertiesStartDate
            // 
            this.lblDepositPropertiesStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositPropertiesStartDate.Location = new System.Drawing.Point(68, 140);
            this.lblDepositPropertiesStartDate.Name = "lblDepositPropertiesStartDate";
            this.lblDepositPropertiesStartDate.Size = new System.Drawing.Size(94, 15);
            this.lblDepositPropertiesStartDate.TabIndex = 2;
            this.lblDepositPropertiesStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbInterestRateDepositProperties
            // 
            this.gbInterestRateDepositProperties.Controls.Add(this.label13);
            this.gbInterestRateDepositProperties.Controls.Add(this.lblDepositPropertiesInterestRateUnitOfTime);
            this.gbInterestRateDepositProperties.Controls.Add(this.label14);
            this.gbInterestRateDepositProperties.Controls.Add(this.lblDepositPropertiesInterestRatePercent);
            this.gbInterestRateDepositProperties.Location = new System.Drawing.Point(6, 75);
            this.gbInterestRateDepositProperties.Name = "gbInterestRateDepositProperties";
            this.gbInterestRateDepositProperties.Size = new System.Drawing.Size(160, 56);
            this.gbInterestRateDepositProperties.TabIndex = 1;
            this.gbInterestRateDepositProperties.TabStop = false;
            this.gbInterestRateDepositProperties.Text = "Interest rate:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Unit";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepositPropertiesInterestRateUnitOfTime
            // 
            this.lblDepositPropertiesInterestRateUnitOfTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositPropertiesInterestRateUnitOfTime.Location = new System.Drawing.Point(62, 36);
            this.lblDepositPropertiesInterestRateUnitOfTime.Name = "lblDepositPropertiesInterestRateUnitOfTime";
            this.lblDepositPropertiesInterestRateUnitOfTime.Size = new System.Drawing.Size(94, 15);
            this.lblDepositPropertiesInterestRateUnitOfTime.TabIndex = 3;
            this.lblDepositPropertiesInterestRateUnitOfTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Percent";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepositPropertiesInterestRatePercent
            // 
            this.lblDepositPropertiesInterestRatePercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositPropertiesInterestRatePercent.Location = new System.Drawing.Point(62, 16);
            this.lblDepositPropertiesInterestRatePercent.Name = "lblDepositPropertiesInterestRatePercent";
            this.lblDepositPropertiesInterestRatePercent.Size = new System.Drawing.Size(94, 15);
            this.lblDepositPropertiesInterestRatePercent.TabIndex = 2;
            this.lblDepositPropertiesInterestRatePercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbTImePeriodDepositProperties
            // 
            this.gbTImePeriodDepositProperties.Controls.Add(this.label12);
            this.gbTImePeriodDepositProperties.Controls.Add(this.label11);
            this.gbTImePeriodDepositProperties.Controls.Add(this.lblDepositPropertiesTimePeriodUnitOfTime);
            this.gbTImePeriodDepositProperties.Controls.Add(this.lblDepositPropertiesTimePeriodPeriod);
            this.gbTImePeriodDepositProperties.Location = new System.Drawing.Point(6, 17);
            this.gbTImePeriodDepositProperties.Name = "gbTImePeriodDepositProperties";
            this.gbTImePeriodDepositProperties.Size = new System.Drawing.Size(160, 56);
            this.gbTImePeriodDepositProperties.TabIndex = 0;
            this.gbTImePeriodDepositProperties.TabStop = false;
            this.gbTImePeriodDepositProperties.Text = "Time period:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Unit";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Period";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepositPropertiesTimePeriodUnitOfTime
            // 
            this.lblDepositPropertiesTimePeriodUnitOfTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositPropertiesTimePeriodUnitOfTime.Location = new System.Drawing.Point(62, 36);
            this.lblDepositPropertiesTimePeriodUnitOfTime.Name = "lblDepositPropertiesTimePeriodUnitOfTime";
            this.lblDepositPropertiesTimePeriodUnitOfTime.Size = new System.Drawing.Size(94, 15);
            this.lblDepositPropertiesTimePeriodUnitOfTime.TabIndex = 1;
            this.lblDepositPropertiesTimePeriodUnitOfTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepositPropertiesTimePeriodPeriod
            // 
            this.lblDepositPropertiesTimePeriodPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositPropertiesTimePeriodPeriod.Location = new System.Drawing.Point(62, 16);
            this.lblDepositPropertiesTimePeriodPeriod.Name = "lblDepositPropertiesTimePeriodPeriod";
            this.lblDepositPropertiesTimePeriodPeriod.Size = new System.Drawing.Size(94, 15);
            this.lblDepositPropertiesTimePeriodPeriod.TabIndex = 0;
            this.lblDepositPropertiesTimePeriodPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCreateTransactionAccount
            // 
            this.gbCreateTransactionAccount.Controls.Add(this.txtTransactionAccountLimit);
            this.gbCreateTransactionAccount.Controls.Add(this.lblLimit);
            this.gbCreateTransactionAccount.Controls.Add(this.txtTransactionAccountCurrency);
            this.gbCreateTransactionAccount.Controls.Add(this.lblCurrency);
            this.gbCreateTransactionAccount.Controls.Add(this.btnCreateTransactionAccount);
            this.gbCreateTransactionAccount.Location = new System.Drawing.Point(12, 12);
            this.gbCreateTransactionAccount.Name = "gbCreateTransactionAccount";
            this.gbCreateTransactionAccount.Size = new System.Drawing.Size(181, 100);
            this.gbCreateTransactionAccount.TabIndex = 10;
            this.gbCreateTransactionAccount.TabStop = false;
            this.gbCreateTransactionAccount.Text = "Create transaction account:";
            // 
            // gbAccountToProperties
            // 
            this.gbAccountToProperties.Controls.Add(this.label6);
            this.gbAccountToProperties.Controls.Add(this.groupBox2);
            this.gbAccountToProperties.Controls.Add(this.label7);
            this.gbAccountToProperties.Controls.Add(this.lblAccountToPropertiesCurrencyAmount);
            this.gbAccountToProperties.Controls.Add(this.label8);
            this.gbAccountToProperties.Controls.Add(this.lblAccountToPropertiesNumber);
            this.gbAccountToProperties.Controls.Add(this.lblAccountToPropertiesID);
            this.gbAccountToProperties.Location = new System.Drawing.Point(377, 321);
            this.gbAccountToProperties.Name = "gbAccountToProperties";
            this.gbAccountToProperties.Size = new System.Drawing.Size(172, 142);
            this.gbAccountToProperties.TabIndex = 11;
            this.gbAccountToProperties.TabStop = false;
            this.gbAccountToProperties.Text = "Account To properties:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Currency";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblAccountToPropertiesBalanceCurrencyBalance);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblAccountToPropertiesBalanceAmount);
            this.groupBox2.Location = new System.Drawing.Point(6, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Currency";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountToPropertiesBalanceCurrencyBalance
            // 
            this.lblAccountToPropertiesBalanceCurrencyBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountToPropertiesBalanceCurrencyBalance.Location = new System.Drawing.Point(62, 36);
            this.lblAccountToPropertiesBalanceCurrencyBalance.Name = "lblAccountToPropertiesBalanceCurrencyBalance";
            this.lblAccountToPropertiesBalanceCurrencyBalance.Size = new System.Drawing.Size(94, 15);
            this.lblAccountToPropertiesBalanceCurrencyBalance.TabIndex = 4;
            this.lblAccountToPropertiesBalanceCurrencyBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Amount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountToPropertiesBalanceAmount
            // 
            this.lblAccountToPropertiesBalanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountToPropertiesBalanceAmount.Location = new System.Drawing.Point(62, 16);
            this.lblAccountToPropertiesBalanceAmount.Name = "lblAccountToPropertiesBalanceAmount";
            this.lblAccountToPropertiesBalanceAmount.Size = new System.Drawing.Size(94, 15);
            this.lblAccountToPropertiesBalanceAmount.TabIndex = 3;
            this.lblAccountToPropertiesBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountToPropertiesCurrencyAmount
            // 
            this.lblAccountToPropertiesCurrencyAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountToPropertiesCurrencyAmount.Location = new System.Drawing.Point(68, 56);
            this.lblAccountToPropertiesCurrencyAmount.Name = "lblAccountToPropertiesCurrencyAmount";
            this.lblAccountToPropertiesCurrencyAmount.Size = new System.Drawing.Size(94, 15);
            this.lblAccountToPropertiesCurrencyAmount.TabIndex = 2;
            this.lblAccountToPropertiesCurrencyAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountToPropertiesNumber
            // 
            this.lblAccountToPropertiesNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountToPropertiesNumber.Location = new System.Drawing.Point(68, 36);
            this.lblAccountToPropertiesNumber.Name = "lblAccountToPropertiesNumber";
            this.lblAccountToPropertiesNumber.Size = new System.Drawing.Size(94, 15);
            this.lblAccountToPropertiesNumber.TabIndex = 1;
            this.lblAccountToPropertiesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountToPropertiesID
            // 
            this.lblAccountToPropertiesID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountToPropertiesID.Location = new System.Drawing.Point(68, 16);
            this.lblAccountToPropertiesID.Name = "lblAccountToPropertiesID";
            this.lblAccountToPropertiesID.Size = new System.Drawing.Size(94, 15);
            this.lblAccountToPropertiesID.TabIndex = 0;
            this.lblAccountToPropertiesID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(6, 67);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(156, 23);
            this.btnMakeTransaction.TabIndex = 12;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // btnMakeGroupTransaction
            // 
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(377, 292);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(172, 23);
            this.btnMakeGroupTransaction.TabIndex = 13;
            this.btnMakeGroupTransaction.Text = "Make Group Transaction";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(202, 311);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "Transaction count";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransactionCount
            // 
            this.lblTransactionCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransactionCount.Location = new System.Drawing.Point(302, 311);
            this.lblTransactionCount.Name = "lblTransactionCount";
            this.lblTransactionCount.Size = new System.Drawing.Size(59, 15);
            this.lblTransactionCount.TabIndex = 17;
            this.lblTransactionCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.lblLogEntryStatus);
            this.groupBox3.Controls.Add(this.lblLogEntryType);
            this.groupBox3.Location = new System.Drawing.Point(199, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 116);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction log entry details:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lblLogEntryCurrnecyAmountCurrency);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lblLogEntryCurrencyAmountAmount);
            this.groupBox4.Location = new System.Drawing.Point(6, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 56);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Currency amount:";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(6, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Currency";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogEntryCurrnecyAmountCurrency
            // 
            this.lblLogEntryCurrnecyAmountCurrency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLogEntryCurrnecyAmountCurrency.Location = new System.Drawing.Point(62, 36);
            this.lblLogEntryCurrnecyAmountCurrency.Name = "lblLogEntryCurrnecyAmountCurrency";
            this.lblLogEntryCurrnecyAmountCurrency.Size = new System.Drawing.Size(94, 15);
            this.lblLogEntryCurrnecyAmountCurrency.TabIndex = 4;
            this.lblLogEntryCurrnecyAmountCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(6, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Amount";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogEntryCurrencyAmountAmount
            // 
            this.lblLogEntryCurrencyAmountAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLogEntryCurrencyAmountAmount.Location = new System.Drawing.Point(62, 16);
            this.lblLogEntryCurrencyAmountAmount.Name = "lblLogEntryCurrencyAmountAmount";
            this.lblLogEntryCurrencyAmountAmount.Size = new System.Drawing.Size(94, 15);
            this.lblLogEntryCurrencyAmountAmount.TabIndex = 3;
            this.lblLogEntryCurrencyAmountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(12, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "Status";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(12, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Type";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogEntryStatus
            // 
            this.lblLogEntryStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLogEntryStatus.Location = new System.Drawing.Point(68, 36);
            this.lblLogEntryStatus.Name = "lblLogEntryStatus";
            this.lblLogEntryStatus.Size = new System.Drawing.Size(94, 15);
            this.lblLogEntryStatus.TabIndex = 1;
            this.lblLogEntryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLogEntryType
            // 
            this.lblLogEntryType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLogEntryType.Location = new System.Drawing.Point(68, 16);
            this.lblLogEntryType.Name = "lblLogEntryType";
            this.lblLogEntryType.Size = new System.Drawing.Size(94, 15);
            this.lblLogEntryType.TabIndex = 0;
            this.lblLogEntryType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTransactionDetailsAmount);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtTransactionDetailsCurrency);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.btnMakeTransaction);
            this.groupBox5.Location = new System.Drawing.Point(377, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 97);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Enter transaction details";
            // 
            // txtTransactionDetailsAmount
            // 
            this.txtTransactionDetailsAmount.Location = new System.Drawing.Point(12, 17);
            this.txtTransactionDetailsAmount.Name = "txtTransactionDetailsAmount";
            this.txtTransactionDetailsAmount.Size = new System.Drawing.Size(94, 20);
            this.txtTransactionDetailsAmount.TabIndex = 3;
            this.txtTransactionDetailsAmount.Text = "10000";
            this.txtTransactionDetailsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(112, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Amount";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTransactionDetailsCurrency
            // 
            this.txtTransactionDetailsCurrency.Location = new System.Drawing.Point(12, 41);
            this.txtTransactionDetailsCurrency.Name = "txtTransactionDetailsCurrency";
            this.txtTransactionDetailsCurrency.Size = new System.Drawing.Size(94, 20);
            this.txtTransactionDetailsCurrency.TabIndex = 2;
            this.txtTransactionDetailsCurrency.Text = "MKD";
            this.txtTransactionDetailsCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(112, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Currency";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChargeFee
            // 
            this.btnChargeFee.Location = new System.Drawing.Point(377, 263);
            this.btnChargeFee.Name = "btnChargeFee";
            this.btnChargeFee.Size = new System.Drawing.Size(172, 23);
            this.btnChargeFee.TabIndex = 21;
            this.btnChargeFee.Text = "Charge Fee";
            this.btnChargeFee.UseVisualStyleBackColor = true;
            this.btnChargeFee.Click += new System.EventHandler(this.btnChargeFee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 550);
            this.Controls.Add(this.btnChargeFee);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTransactionCount);
            this.Controls.Add(this.btnMakeGroupTransaction);
            this.Controls.Add(this.gbAccountToProperties);
            this.Controls.Add(this.gbCreateTransactionAccount);
            this.Controls.Add(this.gbDepositAccountProperties);
            this.Controls.Add(this.gbTransactionAccountProperties);
            this.Controls.Add(this.gbAccountFromProperties);
            this.Controls.Add(this.gbCreateDepositAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.gbCreateDepositAccount.ResumeLayout(false);
            this.gbCreateDepositAccount.PerformLayout();
            this.gbInterestRateDepositAccount.ResumeLayout(false);
            this.gbInterestRateDepositAccount.PerformLayout();
            this.gbTimePeriodDepositAccount.ResumeLayout(false);
            this.gbTimePeriodDepositAccount.PerformLayout();
            this.gbAccountFromProperties.ResumeLayout(false);
            this.gbBalance.ResumeLayout(false);
            this.gbTransactionAccountProperties.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbDepositAccountProperties.ResumeLayout(false);
            this.gbInterestRateDepositProperties.ResumeLayout(false);
            this.gbTImePeriodDepositProperties.ResumeLayout(false);
            this.gbCreateTransactionAccount.ResumeLayout(false);
            this.gbCreateTransactionAccount.PerformLayout();
            this.gbAccountToProperties.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtTransactionAccountCurrency;
        private System.Windows.Forms.TextBox txtTransactionAccountLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.GroupBox gbCreateDepositAccount;
        private System.Windows.Forms.GroupBox gbTimePeriodDepositAccount;
        private System.Windows.Forms.Label lblUnitOfTimeTimePeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cbDepositAccountTimePeriodUnit;
        private System.Windows.Forms.TextBox txtDepositAccountTimePeriodPeriod;
        private System.Windows.Forms.GroupBox gbInterestRateDepositAccount;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpDepositAccountEndDate;
        private System.Windows.Forms.DateTimePicker dtpDepositAccountStartDate;
        private System.Windows.Forms.Label lblUnitOfTimeInterestRate;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ComboBox cbDepositAccountInterestRateUnit;
        private System.Windows.Forms.TextBox txtDepositAccountInterestRatePercent;
        private System.Windows.Forms.GroupBox gbAccountFromProperties;
        private System.Windows.Forms.Label lblAccountFromPropertiesBalanceAmount;
        private System.Windows.Forms.Label lblAccountFromPropertiesCurrencyAmount;
        private System.Windows.Forms.Label lblAccountFromPropertiesNumber;
        private System.Windows.Forms.Label lblAccountFromPropertiesID;
        private System.Windows.Forms.GroupBox gbBalance;
        private System.Windows.Forms.Label lblAccountFromPropertiesBalanceCurrnecyBalance;
        private System.Windows.Forms.GroupBox gbTransactionAccountProperties;
        private System.Windows.Forms.Label lblTransactionAccountPropertiesLimitCurrency;
        private System.Windows.Forms.Label lblTransactionAccountPropertiesLimitAmount;
        private System.Windows.Forms.GroupBox gbDepositAccountProperties;
        private System.Windows.Forms.GroupBox gbTImePeriodDepositProperties;
        private System.Windows.Forms.Label lblDepositPropertiesTimePeriodUnitOfTime;
        private System.Windows.Forms.Label lblDepositPropertiesTimePeriodPeriod;
        private System.Windows.Forms.GroupBox gbInterestRateDepositProperties;
        private System.Windows.Forms.Label lblDepositPropertiesInterestRateUnitOfTime;
        private System.Windows.Forms.Label lblDepositPropertiesInterestRatePercent;
        private System.Windows.Forms.Label lblDepositPropertiesEndDate;
        private System.Windows.Forms.Label lblDepositPropertiesStartDate;
        private System.Windows.Forms.GroupBox gbCreateTransactionAccount;
        private System.Windows.Forms.GroupBox gbAccountToProperties;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAccountToPropertiesBalanceCurrencyBalance;
        private System.Windows.Forms.Label lblAccountToPropertiesBalanceAmount;
        private System.Windows.Forms.Label lblAccountToPropertiesCurrencyAmount;
        private System.Windows.Forms.Label lblAccountToPropertiesNumber;
        private System.Windows.Forms.Label lblAccountToPropertiesID;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnMakeGroupTransaction;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTransactionCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblLogEntryCurrnecyAmountCurrency;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblLogEntryCurrencyAmountAmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblLogEntryStatus;
        private System.Windows.Forms.Label lblLogEntryType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTransactionDetailsAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTransactionDetailsCurrency;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnChargeFee;
    }
}

