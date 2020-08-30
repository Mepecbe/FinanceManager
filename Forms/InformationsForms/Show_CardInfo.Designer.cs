namespace FinanceManager.Forms.InformationsForms
{
    partial class Show_CardInfo
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Card_Number = new MetroFramework.Controls.MetroLabel();
            this.ShowAll = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Card_Date = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Card_Holder = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Card_CVV = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Card_Amount = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(72, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Номер карты";
            // 
            // Card_Number
            // 
            this.Card_Number.AutoSize = true;
            this.Card_Number.Location = new System.Drawing.Point(183, 74);
            this.Card_Number.Name = "Card_Number";
            this.Card_Number.Size = new System.Drawing.Size(125, 19);
            this.Card_Number.TabIndex = 1;
            this.Card_Number.Text = "1234 1234 1234 1234";
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(72, 260);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(150, 23);
            this.ShowAll.TabIndex = 2;
            this.ShowAll.Text = "Показать полные данные";
            this.ShowAll.UseSelectable = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(72, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Срок действия";
            // 
            // Card_Date
            // 
            this.Card_Date.AutoSize = true;
            this.Card_Date.Location = new System.Drawing.Point(183, 108);
            this.Card_Date.Name = "Card_Date";
            this.Card_Date.Size = new System.Drawing.Size(38, 19);
            this.Card_Date.TabIndex = 4;
            this.Card_Date.Text = "01/21";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(72, 145);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Держатель";
            // 
            // Card_Holder
            // 
            this.Card_Holder.AutoSize = true;
            this.Card_Holder.Location = new System.Drawing.Point(183, 145);
            this.Card_Holder.Name = "Card_Holder";
            this.Card_Holder.Size = new System.Drawing.Size(116, 19);
            this.Card_Holder.TabIndex = 6;
            this.Card_Holder.Text = "MIKITA VALODZKA";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(72, 185);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "CVV(CVC)";
            // 
            // Card_CVV
            // 
            this.Card_CVV.AutoSize = true;
            this.Card_CVV.Location = new System.Drawing.Point(183, 184);
            this.Card_CVV.Name = "Card_CVV";
            this.Card_CVV.Size = new System.Drawing.Size(33, 19);
            this.Card_CVV.TabIndex = 8;
            this.Card_CVV.Text = "****";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(72, 219);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(117, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Доступно средств";
            // 
            // Card_Amount
            // 
            this.Card_Amount.AutoSize = true;
            this.Card_Amount.Location = new System.Drawing.Point(183, 219);
            this.Card_Amount.Name = "Card_Amount";
            this.Card_Amount.Size = new System.Drawing.Size(56, 19);
            this.Card_Amount.TabIndex = 10;
            this.Card_Amount.Text = "*** BYN";
            // 
            // Show_CardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 316);
            this.Controls.Add(this.Card_Amount);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.Card_CVV);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.Card_Holder);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Card_Date);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Card_Number);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Show_CardInfo";
            this.Text = "Информация о карте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Card_Number;
        private MetroFramework.Controls.MetroButton ShowAll;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Card_Date;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel Card_Holder;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel Card_CVV;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel Card_Amount;
    }
}