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
            TileManager.BankAccountsTab.AddTile("123");
        }
    }
}
