namespace FinanceManager
{
    partial class AddPlasticCard
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AccountNotSaved = new MetroFramework.Controls.MetroCheckBox();
            this.ComboBoxAccountNumber = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.CardName = new MetroFramework.Controls.MetroTextBox();
            this.CardHolder = new MetroFramework.Controls.MetroTextBox();
            this.CardNumber = new MetroFramework.Controls.MetroTextBox();
            this.CardDate = new MetroFramework.Controls.MetroTextBox();
            this.Amount = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.CardCurrency = new MetroFramework.Controls.MetroComboBox();
            this.TextBox_AccountNumber = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(72, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Наименование";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(72, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Номер счета";
            // 
            // AccountNotSaved
            // 
            this.AccountNotSaved.AutoSize = true;
            this.AccountNotSaved.Location = new System.Drawing.Point(74, 142);
            this.AccountNotSaved.Name = "AccountNotSaved";
            this.AccountNotSaved.Size = new System.Drawing.Size(120, 15);
            this.AccountNotSaved.TabIndex = 2;
            this.AccountNotSaved.Text = "Счет не сохранен";
            this.AccountNotSaved.UseSelectable = true;
            this.AccountNotSaved.Click += new System.EventHandler(this.AccountNotSaved_Click);
            // 
            // ComboBoxAccountNumber
            // 
            this.ComboBoxAccountNumber.FormattingEnabled = true;
            this.ComboBoxAccountNumber.ItemHeight = 23;
            this.ComboBoxAccountNumber.Location = new System.Drawing.Point(198, 120);
            this.ComboBoxAccountNumber.Name = "ComboBoxAccountNumber";
            this.ComboBoxAccountNumber.Size = new System.Drawing.Size(146, 29);
            this.ComboBoxAccountNumber.TabIndex = 3;
            this.ComboBoxAccountNumber.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(72, 177);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Держатель карты";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(72, 216);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Номер карты";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(72, 258);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Дата действия";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(72, 303);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Валюта";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(72, 353);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(103, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Сумма на счету";
            // 
            // CardName
            // 
            // 
            // 
            // 
            this.CardName.CustomButton.Image = null;
            this.CardName.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.CardName.CustomButton.Name = "";
            this.CardName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CardName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CardName.CustomButton.TabIndex = 1;
            this.CardName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CardName.CustomButton.UseSelectable = true;
            this.CardName.CustomButton.Visible = false;
            this.CardName.Lines = new string[] {
        "ОтладочнаяКарта1"};
            this.CardName.Location = new System.Drawing.Point(198, 77);
            this.CardName.MaxLength = 32767;
            this.CardName.Name = "CardName";
            this.CardName.PasswordChar = '\0';
            this.CardName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CardName.SelectedText = "";
            this.CardName.SelectionLength = 0;
            this.CardName.SelectionStart = 0;
            this.CardName.ShortcutsEnabled = true;
            this.CardName.Size = new System.Drawing.Size(146, 23);
            this.CardName.TabIndex = 9;
            this.CardName.Text = "ОтладочнаяКарта1";
            this.CardName.UseSelectable = true;
            this.CardName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CardName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CardHolder
            // 
            // 
            // 
            // 
            this.CardHolder.CustomButton.Image = null;
            this.CardHolder.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.CardHolder.CustomButton.Name = "";
            this.CardHolder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CardHolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CardHolder.CustomButton.TabIndex = 1;
            this.CardHolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CardHolder.CustomButton.UseSelectable = true;
            this.CardHolder.CustomButton.Visible = false;
            this.CardHolder.Lines = new string[] {
        "MIKITA VALODZKA"};
            this.CardHolder.Location = new System.Drawing.Point(198, 177);
            this.CardHolder.MaxLength = 32767;
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.PasswordChar = '\0';
            this.CardHolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CardHolder.SelectedText = "";
            this.CardHolder.SelectionLength = 0;
            this.CardHolder.SelectionStart = 0;
            this.CardHolder.ShortcutsEnabled = true;
            this.CardHolder.Size = new System.Drawing.Size(146, 23);
            this.CardHolder.TabIndex = 10;
            this.CardHolder.Text = "MIKITA VALODZKA";
            this.CardHolder.UseSelectable = true;
            this.CardHolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CardHolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CardNumber
            // 
            // 
            // 
            // 
            this.CardNumber.CustomButton.Image = null;
            this.CardNumber.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.CardNumber.CustomButton.Name = "";
            this.CardNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CardNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CardNumber.CustomButton.TabIndex = 1;
            this.CardNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CardNumber.CustomButton.UseSelectable = true;
            this.CardNumber.CustomButton.Visible = false;
            this.CardNumber.Lines = new string[] {
        "4255 2525 0"};
            this.CardNumber.Location = new System.Drawing.Point(198, 216);
            this.CardNumber.MaxLength = 32767;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.PasswordChar = '\0';
            this.CardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CardNumber.SelectedText = "";
            this.CardNumber.SelectionLength = 0;
            this.CardNumber.SelectionStart = 0;
            this.CardNumber.ShortcutsEnabled = true;
            this.CardNumber.Size = new System.Drawing.Size(146, 23);
            this.CardNumber.TabIndex = 11;
            this.CardNumber.Text = "4255 2525 0";
            this.CardNumber.UseSelectable = true;
            this.CardNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CardNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CardDate
            // 
            // 
            // 
            // 
            this.CardDate.CustomButton.Image = null;
            this.CardDate.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.CardDate.CustomButton.Name = "";
            this.CardDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CardDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CardDate.CustomButton.TabIndex = 1;
            this.CardDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CardDate.CustomButton.UseSelectable = true;
            this.CardDate.CustomButton.Visible = false;
            this.CardDate.Lines = new string[] {
        "08/22"};
            this.CardDate.Location = new System.Drawing.Point(198, 258);
            this.CardDate.MaxLength = 32767;
            this.CardDate.Name = "CardDate";
            this.CardDate.PasswordChar = '\0';
            this.CardDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CardDate.SelectedText = "";
            this.CardDate.SelectionLength = 0;
            this.CardDate.SelectionStart = 0;
            this.CardDate.ShortcutsEnabled = true;
            this.CardDate.Size = new System.Drawing.Size(146, 23);
            this.CardDate.TabIndex = 12;
            this.CardDate.Text = "08/22";
            this.CardDate.UseSelectable = true;
            this.CardDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CardDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Amount
            // 
            // 
            // 
            // 
            this.Amount.CustomButton.Image = null;
            this.Amount.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.Amount.CustomButton.Name = "";
            this.Amount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Amount.CustomButton.TabIndex = 1;
            this.Amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Amount.CustomButton.UseSelectable = true;
            this.Amount.CustomButton.Visible = false;
            this.Amount.Lines = new string[] {
        "990,34"};
            this.Amount.Location = new System.Drawing.Point(198, 353);
            this.Amount.MaxLength = 32767;
            this.Amount.Name = "Amount";
            this.Amount.PasswordChar = '\0';
            this.Amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Amount.SelectedText = "";
            this.Amount.SelectionLength = 0;
            this.Amount.SelectionStart = 0;
            this.Amount.ShortcutsEnabled = true;
            this.Amount.Size = new System.Drawing.Size(146, 23);
            this.Amount.TabIndex = 14;
            this.Amount.Text = "990,34";
            this.Amount.UseSelectable = true;
            this.Amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(151, 399);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CardCurrency
            // 
            this.CardCurrency.FormattingEnabled = true;
            this.CardCurrency.ItemHeight = 23;
            this.CardCurrency.Location = new System.Drawing.Point(198, 304);
            this.CardCurrency.Name = "CardCurrency";
            this.CardCurrency.Size = new System.Drawing.Size(146, 29);
            this.CardCurrency.TabIndex = 16;
            this.CardCurrency.UseSelectable = true;
            // 
            // TextBox_AccountNumber
            // 
            // 
            // 
            // 
            this.TextBox_AccountNumber.CustomButton.Image = null;
            this.TextBox_AccountNumber.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.TextBox_AccountNumber.CustomButton.Name = "";
            this.TextBox_AccountNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_AccountNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_AccountNumber.CustomButton.TabIndex = 1;
            this.TextBox_AccountNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_AccountNumber.CustomButton.UseSelectable = true;
            this.TextBox_AccountNumber.CustomButton.Visible = false;
            this.TextBox_AccountNumber.Lines = new string[0];
            this.TextBox_AccountNumber.Location = new System.Drawing.Point(198, 120);
            this.TextBox_AccountNumber.MaxLength = 32767;
            this.TextBox_AccountNumber.Name = "TextBox_AccountNumber";
            this.TextBox_AccountNumber.PasswordChar = '\0';
            this.TextBox_AccountNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_AccountNumber.SelectedText = "";
            this.TextBox_AccountNumber.SelectionLength = 0;
            this.TextBox_AccountNumber.SelectionStart = 0;
            this.TextBox_AccountNumber.ShortcutsEnabled = true;
            this.TextBox_AccountNumber.Size = new System.Drawing.Size(146, 23);
            this.TextBox_AccountNumber.TabIndex = 17;
            this.TextBox_AccountNumber.UseSelectable = true;
            this.TextBox_AccountNumber.Visible = false;
            this.TextBox_AccountNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_AccountNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddPlasticCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 445);
            this.Controls.Add(this.TextBox_AccountNumber);
            this.Controls.Add(this.CardCurrency);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CardDate);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.CardHolder);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ComboBoxAccountNumber);
            this.Controls.Add(this.AccountNotSaved);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddPlasticCard";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Добавление пластиковой карты";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox Amount;
        public MetroFramework.Controls.MetroTextBox CardDate;
        public MetroFramework.Controls.MetroTextBox CardNumber;
        public MetroFramework.Controls.MetroTextBox CardHolder;
        public MetroFramework.Controls.MetroTextBox CardName;
        public MetroFramework.Controls.MetroComboBox ComboBoxAccountNumber;
        public MetroFramework.Controls.MetroCheckBox AccountNotSaved;
        public MetroFramework.Controls.MetroComboBox CardCurrency;
        public MetroFramework.Controls.MetroTextBox TextBox_AccountNumber;
    }
}