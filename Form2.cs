using System;
using System.Xml;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

using FinanceManager.Modules;
using FinanceManager.Modules.Enums;

namespace FinanceManager
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();

            TileManager.Page = this.BankAccountsPage;
            TileManager.GlavnForm = this;
            Accounts.Init();          
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            for(int index = 0; index < OperationsList.Columns.Count; index++)
            {
                OperationsList.Columns[index].Width = tabPage1.Width / OperationsList.Columns.Count;
            }
        }

        private void добавитьСчетToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            AddBankAccount addBankAccountForm = new AddBankAccount();
            addBankAccountForm.ShowDialog();

            if (addBankAccountForm.OK)
            {
                CurrencyType type;

                Enum.TryParse(addBankAccountForm.AccountCurrency.Text, out type);

                Accounts.BankAccounts.AddBankAccount(
                    addBankAccountForm.AccountName.Text,
                    addBankAccountForm.AccountNumber.Text,
                    type,
                    float.Parse(addBankAccountForm.SummOnAccount.Text)
                );
            }
        }

        private void metroTabControl1_Resize(object sender, EventArgs e)
        {
            if (TileManager.BankAccountsTab.RePaintAvailable())
            {
                TileManager.BankAccountsTab.RePaint();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Accounts.SaveAll();
        }

        public MetroFramework.Controls.MetroTile tile;
        public void MouseOnTile(object sender, EventArgs args)
        {
            tile = (MetroFramework.Controls.MetroTile)sender;
        }

        private void удалитьСчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounts.BankAccounts.DeleteAccount(this.tile);
        }
    }
}
