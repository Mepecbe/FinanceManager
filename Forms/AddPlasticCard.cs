using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class AddPlasticCard : MetroFramework.Forms.MetroForm
    {
        public bool OK = false;

        public AddPlasticCard()
        {
            InitializeComponent();
        }

        private void AccountNotSaved_Click(object sender, EventArgs e)
        {
            if (AccountNotSaved.Checked)
            {
                TextBox_AccountNumber.Visible = true;
                ComboBoxAccountNumber.Visible = false;
            }
            else
            {
                TextBox_AccountNumber.Visible = false;
                ComboBoxAccountNumber.Visible = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!AccountNotSaved.Checked)
            {
                if(ComboBoxAccountNumber.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать счет", "Внимание");
                    return;
                }
            }

            if(CardCurrency.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать валюту", "Внимание");
                return;
            }

            OK = true;
            this.Close();
        }
    }
}
