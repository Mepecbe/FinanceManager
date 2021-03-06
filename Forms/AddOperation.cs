﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinanceManager.Modules;
using FinanceManager.Modules.Enums;
using FinanceManager.Modules.Structures;

namespace FinanceManager
{
    public partial class AddOperation : MetroFramework.Forms.MetroForm
    {
        public AddOperation()
        {
            InitializeComponent();

            //Дублирование пунктов выбора 
            foreach(string item in FromAccountTypeComboBox.Items)
                ToAccountTypeComboBox.Items.Add(item);

            //Добавление пунктов выбора валюты
            for (CurrencyType currency = 0; currency < CurrencyType.RUB; currency++)
                CurrencyComboBox.Items.Add(currency);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Добавить
            CurrencyType type = CurrencyType.BYN;
            Enum.TryParse<CurrencyType>(CurrencyComboBox.Text, out type);

            string fromType = "";
            string from = "";

            string toType = "";
            string to   = ""; 

            {
                if (EnterManuallyFromCheckBox.Checked)
                {
                    fromType = "*MANUALLY*";
                    from = FromTextBox.Text;
                }
                else
                {
                    fromType = FromAccountTypeComboBox.Text;
                    from = FromComboBox.Text;
                }

                if (EnterManuallyToCheckBox.Checked)
                {
                    toType = "*MANUALLY*";
                    to = ToTextBox.Text;
                }
                else
                {
                    toType = ToAccountTypeComboBox.Text;
                    to = ToAccountComboBox.Text;
                }
            }
                       
            Operations.AddOperation(this.OperationName.Text,
                                    fromType,
                                    from,
                                    toType,
                                    to,
                                    decimal.Parse(SummaTextBox.Text),
                                    type);
                      

            MetroFramework.MetroMessageBox.Show(this, "Операция добавлена!");
            this.Close();
        }


        private void FromAccountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //"ОТКУДА" Изменение выбранного типа счета 
            ComboBoxFromAndTo_UPDATE_ITEMS(FromComboBox, FromAccountTypeComboBox.Text);
        }

        private void ToAccountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //"КУДА" Изменение выбранного типа счета 
            ComboBoxFromAndTo_UPDATE_ITEMS(ToAccountComboBox, ToAccountTypeComboBox.Text);
        }

        private void ComboBoxFromAndTo_UPDATE_ITEMS(MetroFramework.Controls.MetroComboBox ComboBox, string Selected)
        {
            ComboBox.Items.Clear();

            switch (Selected)
            {
                case "Банковский счет":
                    {
                        for (int index = 0; index < Accounts.List_BankAccounts.Count; index++)
                        {
                            ComboBox.Items.Add(Accounts.List_BankAccounts[index].AccountName);
                        }

                        break;
                    }

                case "Пластиковая карта":
                    {
                        for (int index = 0; index < Accounts.List_PlasticCards.Count; index++)
                        {
                            ComboBox.Items.Add(Accounts.List_PlasticCards[index].Name);
                        }

                        break;
                    }

                case "Криптовалютный кошелек":
                    {
                        for (int index = 0; index < Accounts.List_CryptoWallets.Count; index++)
                        {
                            ComboBox.Items.Add(Accounts.List_CryptoWallets[index].Name);
                        }

                        break;
                    }
            }
        }


        private void FromCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FromComboBox.Visible = FromAccountTypeComboBox.Visible = !EnterManuallyFromCheckBox.Checked;
        }

        private void EnterManuallyToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ToAccountComboBox.Visible = ToAccountTypeComboBox.Visible = !EnterManuallyToCheckBox.Checked;
        }        
    }
}
