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
using FinanceManager.Modules.Structures;

namespace FinanceManager
{
    public partial class Explorer : MetroFramework.Forms.MetroForm
    {
        public Explorer()
        {
            InitializeComponent();

            TileManager.BankAccountsPage = this.BankAccountsPage;
            TileManager.PlasticCardsPage = this.PlasticCardsPage;

            TileManager.GlavnForm = this;
            Accounts.Init();
            Operations.Init();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            for(int index = 0; index < OperationsList.Columns.Count; index++)
            {
                OperationsList.Columns[index].Width = tabPage1.Width / OperationsList.Columns.Count;
            }
        }

        
        private void metroTabControl1_Resize(object sender, EventArgs e)
        {
            CheckRePaint(); 
        }

        private async Task CheckRePaint()
        {
            await Task.Run(() =>
            {
                if (TileManager.BankAccountsTab.RePaintAvailable())
                {
                    TileManager.BankAccountsTab.RePaint();
                }

                if (TileManager.PlasticCardsTab.RePaintAvailable())
                {
                    TileManager.PlasticCardsTab.RePaint();
                }
            });
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Accounts.SaveAll();
            Operations.SaveAll();
        }



        private void добавитьОперациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOperation operation = new AddOperation();
            operation.ShowDialog();
        }

        private void удалитьОперациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.OperationsList.SelectedItems.Count == 0) return;

            if(MetroFramework.MetroMessageBox.Show(this,"Вы уверены что хотите удалить операцию?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            foreach(ListViewItem item in this.OperationsList.SelectedItems)
            {
                Operations.DeleteOperation(item.Text);
                item.Remove();
            }
        }

        /*=========================================================*/
        public MetroFramework.Controls.MetroTile tile;

        public void MouseOnTile(object sender, EventArgs args)
        {
            tile = (MetroFramework.Controls.MetroTile)sender;
        }


        private void добавитьПластиковуюКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlasticCard addCardForm = new AddPlasticCard();

            //Добавление банковских счетов
            for (int index = 0; index < Accounts.List_BankAccounts.Count; index++)
                addCardForm.ComboBoxAccountNumber.Items.Add(Accounts.List_BankAccounts[index].AccountNumber);

            //Добавление валют
            for (CurrencyType currency = 0; currency <= CurrencyType.RUB; currency++)
                addCardForm.CardCurrency.Items.Add(currency);

            addCardForm.ShowDialog();

            CurrencyType CardCurrency = CurrencyType.USD;
            Enum.TryParse(addCardForm.CardCurrency.Text, out CardCurrency);

            if (addCardForm.OK)
            {
                Accounts.PlasticCards.AddPlasticCard(
                    addCardForm.CardName.Text,
                    addCardForm.AccountNotSaved.Checked ? addCardForm.TextBox_AccountNumber.Text : addCardForm.ComboBoxAccountNumber.Text,
                    addCardForm.CardHolder.Text,
                    addCardForm.CardNumber.Text,
                    addCardForm.CardDate.Text,
                    CardCurrency,
                    decimal.Parse(addCardForm.Amount.Text)
                );

                TileManager.PlasticCardsTab.AddTile(addCardForm.CardName.Text);
            }
        }

        private void удалитьПластиковуюКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounts.PlasticCards.DeleteAccount(tile);
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
                    decimal.Parse(addBankAccountForm.SummOnAccount.Text)
                );
            }
        }

        private void удалитьСчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounts.BankAccounts.DeleteAccount(this.tile);
        }
        
        private void информацияОКартеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вывести информацию по карте
            PlasticCard cardInfo = Accounts.PlasticCards.GetPlasticCardByTile(tile);
            FinanceManager.Forms.InformationsForms.Show_CardInfo InfoForm =
                new Forms.InformationsForms.Show_CardInfo(cardInfo.CardNumber,
                cardInfo.Date,
                cardInfo.CardHolder,
                "123",
                cardInfo.AccountAmount,
                cardInfo.Currency.ToString());

            InfoForm.ShowDialog();
        }

        private void показатьИнформациюПоСчетуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Информация о счете
        }
    }
}
