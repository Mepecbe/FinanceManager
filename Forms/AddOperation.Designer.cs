namespace FinanceManager
{
    partial class AddOperation
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
            this.OperationName = new MetroFramework.Controls.MetroTextBox();
            this.EnterManuallyFromCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.FromTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.EnterManuallyToCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ToTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.CurrencyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FromComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ToAccountComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SummaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.FromAccountTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ToAccountTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(69, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(168, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Наименование операции";
            // 
            // OperationName
            // 
            // 
            // 
            // 
            this.OperationName.CustomButton.Image = null;
            this.OperationName.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.OperationName.CustomButton.Name = "";
            this.OperationName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.OperationName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OperationName.CustomButton.TabIndex = 1;
            this.OperationName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OperationName.CustomButton.UseSelectable = true;
            this.OperationName.CustomButton.Visible = false;
            this.OperationName.Lines = new string[0];
            this.OperationName.Location = new System.Drawing.Point(269, 84);
            this.OperationName.MaxLength = 32767;
            this.OperationName.Name = "OperationName";
            this.OperationName.PasswordChar = '\0';
            this.OperationName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OperationName.SelectedText = "";
            this.OperationName.SelectionLength = 0;
            this.OperationName.SelectionStart = 0;
            this.OperationName.ShortcutsEnabled = true;
            this.OperationName.Size = new System.Drawing.Size(176, 23);
            this.OperationName.TabIndex = 1;
            this.OperationName.UseSelectable = true;
            this.OperationName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OperationName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EnterManuallyFromCheckBox
            // 
            this.EnterManuallyFromCheckBox.AutoSize = true;
            this.EnterManuallyFromCheckBox.Location = new System.Drawing.Point(74, 155);
            this.EnterManuallyFromCheckBox.Name = "EnterManuallyFromCheckBox";
            this.EnterManuallyFromCheckBox.Size = new System.Drawing.Size(112, 15);
            this.EnterManuallyFromCheckBox.TabIndex = 2;
            this.EnterManuallyFromCheckBox.Text = "Ввести вручную";
            this.EnterManuallyFromCheckBox.UseSelectable = true;
            this.EnterManuallyFromCheckBox.CheckedChanged += new System.EventHandler(this.FromCheckBox_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Откуда";
            // 
            // FromTextBox
            // 
            // 
            // 
            // 
            this.FromTextBox.CustomButton.Image = null;
            this.FromTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.FromTextBox.CustomButton.Name = "";
            this.FromTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FromTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FromTextBox.CustomButton.TabIndex = 1;
            this.FromTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FromTextBox.CustomButton.UseSelectable = true;
            this.FromTextBox.CustomButton.Visible = false;
            this.FromTextBox.Lines = new string[0];
            this.FromTextBox.Location = new System.Drawing.Point(269, 135);
            this.FromTextBox.MaxLength = 32767;
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.PasswordChar = '\0';
            this.FromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FromTextBox.SelectedText = "";
            this.FromTextBox.SelectionLength = 0;
            this.FromTextBox.SelectionStart = 0;
            this.FromTextBox.ShortcutsEnabled = true;
            this.FromTextBox.Size = new System.Drawing.Size(176, 23);
            this.FromTextBox.TabIndex = 4;
            this.FromTextBox.UseSelectable = true;
            this.FromTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FromTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FromTextBox.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(69, 216);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Куда";
            // 
            // EnterManuallyToCheckBox
            // 
            this.EnterManuallyToCheckBox.AutoSize = true;
            this.EnterManuallyToCheckBox.Location = new System.Drawing.Point(74, 237);
            this.EnterManuallyToCheckBox.Name = "EnterManuallyToCheckBox";
            this.EnterManuallyToCheckBox.Size = new System.Drawing.Size(112, 15);
            this.EnterManuallyToCheckBox.TabIndex = 6;
            this.EnterManuallyToCheckBox.Text = "Ввести вручную";
            this.EnterManuallyToCheckBox.UseSelectable = true;
            this.EnterManuallyToCheckBox.CheckedChanged += new System.EventHandler(this.EnterManuallyToCheckBox_CheckedChanged);
            // 
            // ToTextBox
            // 
            // 
            // 
            // 
            this.ToTextBox.CustomButton.Image = null;
            this.ToTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.ToTextBox.CustomButton.Name = "";
            this.ToTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ToTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToTextBox.CustomButton.TabIndex = 1;
            this.ToTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ToTextBox.CustomButton.UseSelectable = true;
            this.ToTextBox.CustomButton.Visible = false;
            this.ToTextBox.Lines = new string[0];
            this.ToTextBox.Location = new System.Drawing.Point(269, 216);
            this.ToTextBox.MaxLength = 32767;
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.PasswordChar = '\0';
            this.ToTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ToTextBox.SelectedText = "";
            this.ToTextBox.SelectionLength = 0;
            this.ToTextBox.SelectionStart = 0;
            this.ToTextBox.ShortcutsEnabled = true;
            this.ToTextBox.Size = new System.Drawing.Size(176, 23);
            this.ToTextBox.TabIndex = 7;
            this.ToTextBox.UseSelectable = true;
            this.ToTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ToTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(69, 301);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Сумма";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(69, 349);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Валюта";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.ItemHeight = 23;
            this.CurrencyComboBox.Location = new System.Drawing.Point(269, 349);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(176, 29);
            this.CurrencyComboBox.TabIndex = 10;
            this.CurrencyComboBox.UseSelectable = true;
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.ItemHeight = 23;
            this.FromComboBox.Location = new System.Drawing.Point(269, 170);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(176, 29);
            this.FromComboBox.TabIndex = 11;
            this.FromComboBox.UseSelectable = true;
            // 
            // ToAccountComboBox
            // 
            this.ToAccountComboBox.FormattingEnabled = true;
            this.ToAccountComboBox.ItemHeight = 23;
            this.ToAccountComboBox.Location = new System.Drawing.Point(269, 251);
            this.ToAccountComboBox.Name = "ToAccountComboBox";
            this.ToAccountComboBox.Size = new System.Drawing.Size(176, 29);
            this.ToAccountComboBox.TabIndex = 12;
            this.ToAccountComboBox.UseSelectable = true;
            // 
            // SummaTextBox
            // 
            // 
            // 
            // 
            this.SummaTextBox.CustomButton.Image = null;
            this.SummaTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.SummaTextBox.CustomButton.Name = "";
            this.SummaTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SummaTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SummaTextBox.CustomButton.TabIndex = 1;
            this.SummaTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SummaTextBox.CustomButton.UseSelectable = true;
            this.SummaTextBox.CustomButton.Visible = false;
            this.SummaTextBox.Lines = new string[0];
            this.SummaTextBox.Location = new System.Drawing.Point(269, 301);
            this.SummaTextBox.MaxLength = 32767;
            this.SummaTextBox.Name = "SummaTextBox";
            this.SummaTextBox.PasswordChar = '\0';
            this.SummaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SummaTextBox.SelectedText = "";
            this.SummaTextBox.SelectionLength = 0;
            this.SummaTextBox.SelectionStart = 0;
            this.SummaTextBox.ShortcutsEnabled = true;
            this.SummaTextBox.Size = new System.Drawing.Size(176, 23);
            this.SummaTextBox.TabIndex = 13;
            this.SummaTextBox.UseSelectable = true;
            this.SummaTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SummaTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(194, 409);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FromAccountTypeComboBox
            // 
            this.FromAccountTypeComboBox.FormattingEnabled = true;
            this.FromAccountTypeComboBox.ItemHeight = 23;
            this.FromAccountTypeComboBox.Items.AddRange(new object[] {
            "Банковский счет",
            "Пластиковая карта",
            "Криптовалютный кошелек",
            "Другое"});
            this.FromAccountTypeComboBox.Location = new System.Drawing.Point(269, 135);
            this.FromAccountTypeComboBox.Name = "FromAccountTypeComboBox";
            this.FromAccountTypeComboBox.Size = new System.Drawing.Size(176, 29);
            this.FromAccountTypeComboBox.TabIndex = 15;
            this.FromAccountTypeComboBox.UseSelectable = true;
            this.FromAccountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FromAccountTypeComboBox_SelectedIndexChanged);
            // 
            // ToAccountTypeComboBox
            // 
            this.ToAccountTypeComboBox.FormattingEnabled = true;
            this.ToAccountTypeComboBox.ItemHeight = 23;
            this.ToAccountTypeComboBox.Location = new System.Drawing.Point(269, 216);
            this.ToAccountTypeComboBox.Name = "ToAccountTypeComboBox";
            this.ToAccountTypeComboBox.Size = new System.Drawing.Size(176, 29);
            this.ToAccountTypeComboBox.TabIndex = 16;
            this.ToAccountTypeComboBox.UseSelectable = true;
            this.ToAccountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ToAccountTypeComboBox_SelectedIndexChanged);
            // 
            // AddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 455);
            this.Controls.Add(this.ToAccountTypeComboBox);
            this.Controls.Add(this.FromAccountTypeComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SummaTextBox);
            this.Controls.Add(this.ToAccountComboBox);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.EnterManuallyToCheckBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.EnterManuallyFromCheckBox);
            this.Controls.Add(this.OperationName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddOperation";
            this.Text = "Добавление операции";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox EnterManuallyToCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox EnterManuallyFromCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton AddButton;
        public MetroFramework.Controls.MetroTextBox OperationName;
        public MetroFramework.Controls.MetroTextBox FromTextBox;
        public MetroFramework.Controls.MetroTextBox ToTextBox;
        public MetroFramework.Controls.MetroComboBox CurrencyComboBox;
        public MetroFramework.Controls.MetroComboBox FromComboBox;
        public MetroFramework.Controls.MetroComboBox ToAccountComboBox;
        public MetroFramework.Controls.MetroTextBox SummaTextBox;
        private MetroFramework.Controls.MetroComboBox FromAccountTypeComboBox;
        private MetroFramework.Controls.MetroComboBox ToAccountTypeComboBox;
    }
}