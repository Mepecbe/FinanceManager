namespace FinanceManager
{
    partial class AddBankAccount
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AccountCurrency = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.AccountName = new MetroFramework.Controls.MetroTextBox();
            this.AccountNumber = new MetroFramework.Controls.MetroTextBox();
            this.SummOnAccount = new MetroFramework.Controls.MetroTextBox();
            this.AddClick = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Наименование счета";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Номер счета";
            // 
            // AccountCurrency
            // 
            this.AccountCurrency.FormattingEnabled = true;
            this.AccountCurrency.ItemHeight = 23;
            this.AccountCurrency.Location = new System.Drawing.Point(206, 164);
            this.AccountCurrency.Name = "AccountCurrency";
            this.AccountCurrency.Size = new System.Drawing.Size(155, 29);
            this.AccountCurrency.TabIndex = 2;
            this.AccountCurrency.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Валюта";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 216);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Сумма на счету";
            // 
            // AccountName
            // 
            // 
            // 
            // 
            this.AccountName.CustomButton.Image = null;
            this.AccountName.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.AccountName.CustomButton.Name = "";
            this.AccountName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AccountName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AccountName.CustomButton.TabIndex = 1;
            this.AccountName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AccountName.CustomButton.UseSelectable = true;
            this.AccountName.CustomButton.Visible = false;
            this.AccountName.Lines = new string[] {
        "Счет для отладки"};
            this.AccountName.Location = new System.Drawing.Point(207, 81);
            this.AccountName.MaxLength = 32767;
            this.AccountName.Name = "AccountName";
            this.AccountName.PasswordChar = '\0';
            this.AccountName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountName.SelectedText = "";
            this.AccountName.SelectionLength = 0;
            this.AccountName.SelectionStart = 0;
            this.AccountName.ShortcutsEnabled = true;
            this.AccountName.Size = new System.Drawing.Size(154, 23);
            this.AccountName.TabIndex = 5;
            this.AccountName.Text = "Счет для отладки";
            this.AccountName.UseSelectable = true;
            this.AccountName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AccountName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AccountNumber
            // 
            // 
            // 
            // 
            this.AccountNumber.CustomButton.Image = null;
            this.AccountNumber.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.AccountNumber.CustomButton.Name = "";
            this.AccountNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AccountNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AccountNumber.CustomButton.TabIndex = 1;
            this.AccountNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AccountNumber.CustomButton.UseSelectable = true;
            this.AccountNumber.CustomButton.Visible = false;
            this.AccountNumber.Lines = new string[] {
        "4255 6200 6"};
            this.AccountNumber.Location = new System.Drawing.Point(206, 127);
            this.AccountNumber.MaxLength = 32767;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.PasswordChar = '\0';
            this.AccountNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountNumber.SelectedText = "";
            this.AccountNumber.SelectionLength = 0;
            this.AccountNumber.SelectionStart = 0;
            this.AccountNumber.ShortcutsEnabled = true;
            this.AccountNumber.Size = new System.Drawing.Size(154, 23);
            this.AccountNumber.TabIndex = 6;
            this.AccountNumber.Text = "4255 6200 6";
            this.AccountNumber.UseSelectable = true;
            this.AccountNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AccountNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SummOnAccount
            // 
            // 
            // 
            // 
            this.SummOnAccount.CustomButton.Image = null;
            this.SummOnAccount.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.SummOnAccount.CustomButton.Name = "";
            this.SummOnAccount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SummOnAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SummOnAccount.CustomButton.TabIndex = 1;
            this.SummOnAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SummOnAccount.CustomButton.UseSelectable = true;
            this.SummOnAccount.CustomButton.Visible = false;
            this.SummOnAccount.Lines = new string[] {
        "200,34"};
            this.SummOnAccount.Location = new System.Drawing.Point(205, 212);
            this.SummOnAccount.MaxLength = 32767;
            this.SummOnAccount.Name = "SummOnAccount";
            this.SummOnAccount.PasswordChar = '\0';
            this.SummOnAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SummOnAccount.SelectedText = "";
            this.SummOnAccount.SelectionLength = 0;
            this.SummOnAccount.SelectionStart = 0;
            this.SummOnAccount.ShortcutsEnabled = true;
            this.SummOnAccount.Size = new System.Drawing.Size(156, 23);
            this.SummOnAccount.TabIndex = 7;
            this.SummOnAccount.Text = "200,34";
            this.SummOnAccount.UseSelectable = true;
            this.SummOnAccount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SummOnAccount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddClick
            // 
            this.AddClick.Location = new System.Drawing.Point(126, 275);
            this.AddClick.Name = "AddClick";
            this.AddClick.Size = new System.Drawing.Size(148, 37);
            this.AddClick.TabIndex = 8;
            this.AddClick.Text = "Добавить ";
            this.AddClick.UseSelectable = true;
            this.AddClick.Click += new System.EventHandler(this.AddClick_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AddBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 371);
            this.Controls.Add(this.AddClick);
            this.Controls.Add(this.SummOnAccount);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.AccountCurrency);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBankAccount";
            this.Text = "Добавление банковского счета";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.AddBankAccount_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton AddClick;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroComboBox AccountCurrency;
        public MetroFramework.Controls.MetroTextBox AccountName;
        public MetroFramework.Controls.MetroTextBox AccountNumber;
        public MetroFramework.Controls.MetroTextBox SummOnAccount;
    }
}