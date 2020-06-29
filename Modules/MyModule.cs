using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using FinanceManager.Modules.Enums;
using FinanceManager.Modules.Structures;

using MetroFramework.Controls;

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
    /// Класс для работы со счетами
    /// </summary>
    public static class Accounts
    {
        public static List<BankAccount>  List_BankAccounts  = new List<BankAccount>();
        public static List<PlasticCard>  List_PlasticCards  = new List<PlasticCard>();
        public static List<CryptoWallet> List_CryptoWallets = new List<CryptoWallet>();
        public static List<OtherAccount> List_OtherAccounts = new List<OtherAccount>();

        private static XmlDocument XmlAccountsDocument = new XmlDocument();

        /// <summary>
        /// Загрузка информации о счетах, карточках, кошельках и т.д. из файла
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
                            newAccount.AccountAmount = float.Parse(node.ChildNodes[3].InnerText);

                            List_BankAccounts.Add(newAccount);
                            TileManager.BankAccountsTab.AddTile(newAccount.AccountName);
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
                            newCard.AccountAmount = float.Parse(node.ChildNodes[6].InnerText);

                            List_PlasticCards.Add(newCard);
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

                            List_CryptoWallets.Add(newCryptoWallet);
                            break;
                        }

                    case "Other":
                        {
                            OtherAccount newOtherAccount = new OtherAccount();
                            newOtherAccount.AccountName = node.ChildNodes[0].InnerText;
                            Enum.TryParse(node.ChildNodes[1].InnerText, out newOtherAccount.Currency);
                            newOtherAccount.AccountAmount = float.Parse(node.ChildNodes[2].InnerText);

                            List_OtherAccounts.Add(newOtherAccount);
                            break;
                        }
                }
            }
        }                      

        ///<summary>
        ///Класс для работы с банковскими аккаунтами
        /// </summary>
        public static class BankAccounts
        {
            public static void AddBankAccount(string AccountName, string AccountNumber, CurrencyType Currency, float AccountAmount)
            {
                {
                    //Добавление в лист счетов
                    BankAccount NewBankAccount = new BankAccount();

                    NewBankAccount.AccountName = AccountName;
                    NewBankAccount.AccountNumber = AccountNumber;
                    NewBankAccount.Currency = Currency;
                    NewBankAccount.AccountAmount = AccountAmount;

                    List_BankAccounts.Add(NewBankAccount);
                }

                {
                    //Сохранение счета в файл
                    XmlElement newAccount = XmlAccountsDocument.CreateElement("account");
                    XmlAttribute attribute = XmlAccountsDocument.CreateAttribute("type");
                    attribute.Value = "Bank";

                    newAccount.Attributes.Append(attribute);

                    XmlElement XmlAccountName = XmlAccountsDocument.CreateElement("name");
                    XmlAccountName.InnerText = AccountName;

                    XmlElement XmlAccountNumber = XmlAccountsDocument.CreateElement("number");
                    XmlAccountNumber.InnerText = AccountNumber;

                    XmlElement XmlAccountCurrency = XmlAccountsDocument.CreateElement("currency");
                    XmlAccountCurrency.InnerText = Currency.ToString();

                    XmlElement XmlAccountAmount = XmlAccountsDocument.CreateElement("AccountAmount");
                    XmlAccountAmount.InnerText = AccountAmount.ToString();

                    newAccount.AppendChild(XmlAccountName);
                    newAccount.AppendChild(XmlAccountNumber);
                    newAccount.AppendChild(XmlAccountCurrency);
                    newAccount.AppendChild(XmlAccountAmount);

                    XmlAccountsDocument.DocumentElement.AppendChild(newAccount);
                }


                TileManager.BankAccountsTab.AddTile(AccountName);
            }
        }

        public static void Save()
        {
            XmlAccountsDocument.Save(Properties.Resources.AccountsFile);
        }
    }


    ///<summary>
    /// Класс, который отвечает за элементы 'Tile' на форме
    /// </summary>
    public static class TileManager
    {
        public static MetroTabPage Page;
        public static Form GlavnForm;

        ///<summary>
        /// Класс, для работы с элементами Tile вкладки банковских счетов
        /// </summary>
        public static class BankAccountsTab
        {
            private static List<MetroTile> TileList = new List<MetroTile>();

            public static void DeleteTile(string TileText)
            {
                for(int index = 0; index < TileList.Count; index++)
                {
                    if(TileList[index].Text == TileText)
                    {
                        GlavnForm.Controls.Remove(TileList[index]);
                        TileList.RemoveAt(index);
                        RePaint();
                    }
                }
            }

            public static void DeleteTile(MetroTile tile)
            {                
                GlavnForm.Controls.Remove(tile);
                TileList.Remove(tile);
                RePaint();
            }

            

            public static MetroTile AddTile(string TileText)
            {
                MetroTile newTile = new MetroTile();

                newTile.ActiveControl = null;
                newTile.Location = new System.Drawing.Point(0,0);
                newTile.Name = "BMetroTile"+(TileList.Count+1).ToString();
                newTile.Size = new System.Drawing.Size(184, 136);
                newTile.TabIndex = TileList.Count+1;
                newTile.Text = TileText;
                newTile.Theme = Page.Theme;
                newTile.TileImage = global::FinanceManager.Properties.Resources.Coins;
                newTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                newTile.UseSelectable = true;
                newTile.UseTileImage = true;


                Page.Controls.Add(newTile);
                TileList.Add(newTile);

                RePaint();

                return newTile;
            }


            //Хранит в себе количество элементов в строке ДО изменения размера окна пользователем
            private static byte CountTileInRow = 0;

            public static bool RePaintAvailable()
            {
                if ((byte)Math.Ceiling(Page.Width / (184f + 85)) != CountTileInRow) return true;
                return false;
            }

            public static void RePaint()
            {
                //Расстояние между блоками 'Tile' на форме по горизонтали(в строке), 
                //ОТСТУП ТАК ЖЕ ПРИМЕНЯЕТСЯ ДЛЯ ПЕРВОГО ЭЛЕМЕНТА В СТРОКЕ
                byte horisontalOffset = 20;

                //Расстояние между блоками 'Tile' на форме по вертикали(т.е. между строками)
                byte verticalOffset   = 20;

                //Перерисовка/пересчитывание расположения элементов 'Tile' на форме
                CountTileInRow = (byte)Math.Ceiling(Page.Width / (184f + 85)); //+ 50));
                byte CountRows      = (byte)Math.Ceiling(Page.Height / 136f);
                byte TileIndex      = 0; //Индекс элемента, положение которого выставляется
                 

                //Высота для каждого блока и расстояний между блоками
                //GlavnForm.Height = (CountRows * 136) + (CountRows * verticalOffset);

                //ONLY DEBUG
                //MessageBox.Show($"Для размеров формы {GlavnForm.Width},{GlavnForm.Height}\nСтрок {CountRows}\nЭлементов в строке {CountTileInRow}");


                int Y = 18; //Координата по Y для строки
                for (byte Row = 0; Row < CountRows && TileIndex < TileList.Count; Row++)
                {
                    for(byte TileNumber = 0; TileNumber < CountTileInRow && TileIndex < TileList.Count; TileNumber++)
                    {
                        int X = ((horisontalOffset * TileNumber+1) + (TileNumber * 184)); //Координата по X для этого элемента

                        TileList[TileIndex].Location = new System.Drawing.Point(X, Y);
                        TileIndex++;

                        //ONLY DEBUG
                        //MessageBox.Show($" Установка форматирования для Строка {Row} Элемент {TileNumber}\n Координаты X,Y {X},{Y}");
                    }

                    Y += verticalOffset + 136;
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
