using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinanceManager.Modules.Enums;
using FinanceManager.Modules.Structures;

namespace FinanceManager
{
    public partial class AddBankAccount : MetroFramework.Forms.MetroForm
    {
        public bool OK = false;

        public AddBankAccount()
        {
            InitializeComponent();
        }

        private void AddBankAccount_Shown(object sender, EventArgs e)
        {
            for (CurrencyType currency = 0; currency <= CurrencyType.RUB; currency++)
            {
                this.AccountCurrency.Items.Add(currency);
            }
        }

        private void AddClick_Click(object sender, EventArgs e)
        {
            if(this.AccountCurrency.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать валюту", "Внимание");
                return;
            }

            OK = true;
            this.Close();
        }
    }
}
