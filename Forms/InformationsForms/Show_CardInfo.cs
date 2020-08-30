using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager.Forms.InformationsForms
{
    public partial class Show_CardInfo : MetroFramework.Forms.MetroForm
    {
        decimal Amount = 0.0m;
        string cvv = "";

        public Show_CardInfo(string CardNumber, string Date, string Holder, string cvv, decimal Amount, string currency)
        {
            InitializeComponent();

            {
                this.Card_Number.Text = CardNumber;
                this.Card_Date.Text   = Date;
                this.Card_Holder.Text = Holder;
                //CVV не пишем
                this.Card_Amount.Text = "*** " + currency;
            }

            {
                this.Amount = Amount;
                this.cvv = cvv;
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            //Показать полные данные(возможна авторизация)
            //Выводим CVV и кол-во денег на карте
            this.Card_Amount.Text = this.Amount + this.Card_Amount.Text.Substring(this.Card_Amount.Text.Length - 4);
            this.Card_CVV.Text    = cvv;
        }
    }
}
