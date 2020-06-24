using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using FinanceManager.Modules.Enums;
using FinanceManager.Modules.Structures;

namespace FinanceManager.Modules
{
    /// <summary>
    /// Класс, для работы с операциями
    /// </summary>
    public static class Operations
    {
        public static void Init()
        {
            if (!File.Exists(Properties.Resources.OperationsFile))
            {
                StreamWriter fileWriter = File.CreateText(Properties.Resources.OperationsFile);
                fileWriter.WriteLine("<?xml version=\"1.0\"?>\n<operations>\n</operations>>  ");
                fileWriter.Close();
                return;
            }
        }
    }


    /// <summary>
    /// Класс, для работы со счетами
    /// </summary>
    public static class Accounts
    {
        public static List<BankAccount> BankAccounts = new List<BankAccount>();
        public static List<PlasticCard> PlasticCards = new List<PlasticCard>();
        public static List<CryptoWallet> CryptoWallets = new List<CryptoWallet>();
        public static List<OtherAccount> OtherAccounts = new List<OtherAccount>();

        private static XmlDocument XmlAccountsDocument = new XmlDocument();

        /// <summary>
        /// Загрузка аккаунтов из файла
        /// </summary>
        public static void Init()
        {
            if(!File.Exists(Properties.Resources.AccountsFile))
            {
                StreamWriter fileWriter = File.CreateText(Properties.Resources.AccountsFile);
                fileWriter.WriteLine("<?xml version=\"1.0\"?>\n<accounts>\n</accounts>  ");
                fileWriter.Close();
                return;
            }


            XmlAccountsDocument.Load(Properties.Resources.AccountsFile);

            XmlElement rootXmlAccountsDocument = XmlAccountsDocument.DocumentElement;
            foreach (XmlNode node in rootXmlAccountsDocument)
            {
                switch (node.Attributes["type"].Value)
                {

                    case "Bank":        
                        {
                            BankAccount newAccount   = new BankAccount();
                            newAccount.AccountName   = node.ChildNodes[0].InnerText;
                            newAccount.AccountNumber = node.ChildNodes[1].InnerText;
                            Enum.TryParse(node.ChildNodes[2].InnerText, out newAccount.Currency);
                            newAccount.Money = float.Parse(node.ChildNodes[3].InnerText);
                            
                            BankAccounts.Add(newAccount);
                            break; 
                        }

                    case "PlasticCard": 
                        {
                            PlasticCard newCard = new PlasticCard();
                            newCard.Name = node.ChildNodes[0].InnerText;
                            newCard.BankAccount = node.ChildNodes[1].InnerText;
                            newCard.CardHolder = node.ChildNodes[2].InnerText;
                            newCard.CardNumber = node.ChildNodes[3].InnerText;
                            newCard.Date = node.ChildNodes[4].InnerText;
                            Enum.TryParse(node.ChildNodes[5].InnerText, out newCard.Currency);
                            newCard.Money = float.Parse(node.ChildNodes[6].InnerText);

                            PlasticCards.Add(newCard);
                            break; 
                        }

                    case "Crypto":      
                        {
                            CryptoWallet newCryptoWallet = new CryptoWallet();
                            newCryptoWallet.Name = node.ChildNodes[0].InnerText;
                            newCryptoWallet.WalletID = node.ChildNodes[1].InnerText;
                            newCryptoWallet.WalletAddress = node.ChildNodes[2].InnerText;
                            newCryptoWallet.WalletPassword = node.ChildNodes[3].InnerText;
                            Enum.TryParse(node.ChildNodes[4].InnerText, out newCryptoWallet.CryptoCurrency);

                            CryptoWallets.Add(newCryptoWallet);
                            break;
                        }

                    case "Other":
                        {
                            OtherAccount newOtherAccount = new OtherAccount();
                            newOtherAccount.AccountName = node.ChildNodes[0].InnerText;
                            Enum.TryParse(node.ChildNodes[1].InnerText, out newOtherAccount.Currency);
                            newOtherAccount.Money = float.Parse(node.ChildNodes[2].InnerText);

                            OtherAccounts.Add(newOtherAccount);
                            break;
                        }
                }
            }
        }


       
    }



    /// <summary>
    /// Класс, для работы с внешней базой данных 
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// Проверка доступности 
        /// </summary>
        public static bool CheckAvailability()
        {
            return true;
        }
    }

    /// <summary>
    /// Класс, для работы с курсами валют
    /// </summary>
    public static class ExchangeRates
    {

    }

}
