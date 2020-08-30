using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Http;

namespace FinanceManager.Forms.Settings_Forms
{
    public partial class Setting_Exchanger : MetroFramework.Forms.MetroForm
    {
        public Setting_Exchanger()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest Req = HttpWebRequest.CreateHttp($"https://belarusbank.by/api/kursExchange?city={this.City.Text}");
            HttpWebResponse Response = (HttpWebResponse)Req.GetResponse();

            StreamReader reader = new StreamReader(Response.GetResponseStream());
            
            if(reader.BaseStream.Length < 30)
            {
                MetroFramework.MetroMessageBox.Show(this, "Невозможно получить информацию об обменниках в этому городе");
            }

            MessageBox.Show(reader.ReadLine().Substring(0,30));
        }
    }
}
