using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using FinanceManager.Modules.Enums;
using FinanceManager.Modules.Structures;

using MetroFramework.Controls;
using System.Text;

namespace FinanceManager.Modules
{
    /// <summary>
    /// Класс, для работы с операциями
    /// </summary>
    public static class Operations
    {
        private static XmlDocument XmlOperationsDocument = new XmlDocument();
        private static List<Operation> List_Operations = new List<Operation>();

        public static void Init()
        {
            if (!File.Exists(Properties.Resources.OperationsFile))
            {
                StreamWriter fileWriter = File.CreateText(Properties.Resources.OperationsFile);
                fileWriter.WriteLine("<?xml version=\"1.0\"?>\n<operations>\n</operations>  ");
                fileWriter.Close();
            }

            XmlOperationsDocument.Load(Properties.Resources.OperationsFile);

            foreach (XmlElement element in XmlOperationsDocument.DocumentElement)
            {
                Operation newOperation = new Operation();
                newOperation.OperationNumber = UInt16.Parse(element.ChildNodes[0].InnerText);
                newOperation.OperationName = element.ChildNodes[1].InnerText;
                newOperation.From = element.ChildNodes[2].InnerText;
                newOperation.To = element.ChildNodes[3].InnerText;
                newOperation.Sum = decimal.Parse(element.ChildNodes[4].InnerText);
                
                CurrencyType currency = CurrencyType.USD;
                Enum.TryParse(element.ChildNodes[5].InnerText, out currency);

                newOperation.Currency = currency;
                newOperation.Balance = decimal.Parse(element.ChildNodes[6].InnerText);

                List_Operations.Add(newOperation);

                /*В табличку на форме*/
                ListViewItem OperationItem = TileManager.GlavnForm.OperationsList.Items.Add(newOperation.OperationNumber.ToString());
                OperationItem.SubItems.Add(newOperation.OperationName);
                OperationItem.SubItems.Add(newOperation.From);
                OperationItem.SubItems.Add(newOperation.To);
                OperationItem.SubItems.Add(newOperation.Sum.ToString());
            }
        }

        private static UInt32 GetNewOperationNumber()
        {
            return 1 + (UInt32)List_Operations.Count;
        }

        public static void AddOperation(string name, string from, string to, decimal sum, CurrencyType currency)
        {
            Operation newOperation = new Operation()
            {
                OperationNumber = GetNewOperationNumber(),
                OperationName = name,
                From = from,
                To = to,
                Sum = sum,
                Currency = currency,
                Balance = (decimal)9999.9       //БАЛАНС, ОСТАТОК НА СЧЕТУ
            };

            List_Operations.Add(newOperation);

            XmlElement XmlOperation    = XmlOperationsDocument.CreateElement("operation");

            XmlElement OperationNumber = XmlOperationsDocument.CreateElement("number");
            XmlElement OperationName   = XmlOperationsDocument.CreateElement("name");
            XmlElement From            = XmlOperationsDocument.CreateElement("from");
            XmlElement To              = XmlOperationsDocument.CreateElement("to");
            XmlElement Summ            = XmlOperationsDocument.CreateElement("Summ");
            XmlElement Currency        = XmlOperationsDocument.CreateElement("currency");
            XmlElement Balance         = XmlOperationsDocument.CreateElement("balance");

            OperationNumber.InnerText = newOperation.OperationNumber.ToString();
            OperationName.InnerText = newOperation.OperationName;

            From.InnerText = newOperation.From;
            To.InnerText = newOperation.To;

            Summ.InnerText = newOperation.Sum.ToString();
            Currency.InnerText = newOperation.Currency.ToString();
            Balance.InnerText = newOperation.Balance.ToString();

            XmlOperation.AppendChild(OperationNumber);
            XmlOperation.AppendChild(OperationName);
            XmlOperation.AppendChild(From);
            XmlOperation.AppendChild(To);
            XmlOperation.AppendChild(Summ);
            XmlOperation.AppendChild(Currency);
            XmlOperation.AppendChild(Balance);

            XmlOperationsDocument.DocumentElement.AppendChild(XmlOperation);

            //Добавление на форму
            ListViewItem item = TileManager.GlavnForm.OperationsList.Items.Add(newOperation.OperationNumber.ToString());
            item.SubItems.Add(newOperation.OperationName);
            item.SubItems.Add(newOperation.From);
            item.SubItems.Add(newOperation.To);
            item.SubItems.Add(newOperation.Sum.ToString());
        }


        public static void DeleteOperation(string number)
        {
            //Удаление из XML документа
            foreach (XmlElement operation in XmlOperationsDocument.DocumentElement)
            {
                if (operation.ChildNodes[0].InnerText == number)
                {
                    XmlOperationsDocument.DocumentElement.RemoveChild(operation);
                    break;
                }
            }
        }

        public static void SaveAll()
        {
            XmlOperationsDocument.Save("operations.xml");
        }
    }


    /// <summary>
    /// Класс для работы со счетами
    /// </summary>
    public static class Accounts
    {
        public static List<BankAccount> List_BankAccounts = new List<BankAccount>();
        public static List<PlasticCard> List_PlasticCards = new List<PlasticCard>();
        public static List<CryptoWallet> List_CryptoWallets = new List<CryptoWallet>();
        public static List<OtherAccount> List_OtherAccounts = new List<OtherAccount>();

        private static XmlDocument XmlAccountsDocument = new XmlDocument();

        /// <summary>
        /// Загрузка информации о счетах, карточках, кошельках и т.д. из файла
        /// </summary>
        public static void Init()
        {
            if (!File.Exists(Properties.Resources.AccountsFile))
            {
                StreamWriter fileWriter = File.CreateText(Properties.Resources.AccountsFile);
                fileWriter.WriteLine("<?xml version=\"1.0\"?>\n<accounts>\n</accounts>  ");
                fileWriter.Close();
            }
            
            XmlAccountsDocument.Load(Properties.Resources.AccountsFile);
            
            foreach (XmlNode node in XmlAccountsDocument.DocumentElement)
            {
                switch (node.Attributes["type"].Value)
                {
                    case "Bank":
                        {
                            BankAccount newAccount = new BankAccount();
                            newAccount.AccountName = node.ChildNodes[0].InnerText;
                            newAccount.AccountNumber = node.ChildNodes[1].InnerText;
                            Enum.TryParse(node.ChildNodes[2].InnerText, out newAccount.Currency);
                            newAccount.AccountAmount = decimal.Parse(node.ChildNodes[3].InnerText);

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
                            newCard.AccountAmount = decimal.Parse(node.ChildNodes[6].InnerText);

                            List_PlasticCards.Add(newCard);
                            TileManager.PlasticCardsTab.AddTile(newCard.Name);
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
                            newOtherAccount.AccountAmount = decimal.Parse(node.ChildNodes[2].InnerText);

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
            public static void AddBankAccount(string AccountName, string AccountNumber, CurrencyType Currency, decimal AccountAmount)
            {
                {
                    //Добавление в лист счетов
                    BankAccount NewBankAccount = new BankAccount()
                    {
                        AccountName = AccountName,
                        AccountNumber = AccountNumber,
                        Currency = Currency,
                        AccountAmount = AccountAmount
                    };

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

            public static void DeleteAccount(MetroFramework.Controls.MetroTile tile)
            {
                if (tile == null) return;

                for (int index = 0; index < List_BankAccounts.Count; index++)
                {
                    if (List_BankAccounts[index].AccountName == tile.Text)
                    {
                        List_BankAccounts.RemoveAt(index);

                        for (int XmlChildIndex = 0; XmlChildIndex < XmlAccountsDocument.DocumentElement.ChildNodes.Count; XmlChildIndex++)
                        {
                            if (XmlAccountsDocument.DocumentElement.ChildNodes[XmlChildIndex].Attributes["type"].Value == "Bank"
                                && XmlAccountsDocument.DocumentElement.ChildNodes[XmlChildIndex].ChildNodes[0].InnerText == tile.Text)
                            {
                                XmlAccountsDocument.DocumentElement.RemoveChild(XmlAccountsDocument.DocumentElement.ChildNodes[XmlChildIndex]);
                                break;
                            }
                        }

                        break;
                    }
                }

                TileManager.BankAccountsTab.DeleteTile(tile);
            }
        }


        public static class PlasticCards
        {            
            public static void AddPlasticCard(string name, string BankAccount, string CardHolder, string CardNumber, string Date, CurrencyType currency, decimal Amount)
            {
                PlasticCard newPlasticCard = new PlasticCard()
                {
                    Name = name,
                    BankAccount = BankAccount,
                    CardHolder = CardHolder,
                    CardNumber = CardNumber,
                    Date = Date,
                    Currency = currency,
                    AccountAmount = Amount
                };
               
                List_PlasticCards.Add(newPlasticCard);
                


                {
                    //Добавление в XML файл
                    XmlElement xmlAccount = XmlAccountsDocument.CreateElement("account");
                    XmlAttribute attributeType = XmlAccountsDocument.CreateAttribute("type");
                                 attributeType.Value = "PlasticCard";

                    xmlAccount.Attributes.Append(attributeType);

                    XmlElement XmlName = XmlAccountsDocument.CreateElement("name");
                               XmlName.InnerText = newPlasticCard.Name;

                    XmlElement XmlBankAccount = XmlAccountsDocument.CreateElement("BankAccount");
                               XmlBankAccount.InnerText = newPlasticCard.BankAccount;

                    XmlElement XmlCardHolder = XmlAccountsDocument.CreateElement("CardHolder");
                               XmlCardHolder.InnerText = newPlasticCard.CardHolder;

                    XmlElement XmlCardNumber = XmlAccountsDocument.CreateElement("CardNumber");
                               XmlCardNumber.InnerText = newPlasticCard.CardNumber;

                    XmlElement XmlDate = XmlAccountsDocument.CreateElement("date");
                               XmlDate.InnerText = newPlasticCard.Date;

                    XmlElement XmlCurrency = XmlAccountsDocument.CreateElement("currency");
                               XmlCurrency.InnerText = newPlasticCard.Currency.ToString();

                    XmlElement XmlAmount = XmlAccountsDocument.CreateElement("Amount");
                               XmlAmount.InnerText = newPlasticCard.AccountAmount.ToString();

                    xmlAccount.AppendChild(XmlName);
                    xmlAccount.AppendChild(XmlBankAccount);
                    xmlAccount.AppendChild(XmlCardHolder);
                    xmlAccount.AppendChild(XmlCardNumber);
                    xmlAccount.AppendChild(XmlDate);
                    xmlAccount.AppendChild(XmlCurrency);
                    xmlAccount.AppendChild(XmlAmount);

                    XmlAccountsDocument.DocumentElement.AppendChild(xmlAccount);
                }
            }

            public static void DeleteAccount(MetroFramework.Controls.MetroTile tile)
            {
                if (tile == null) return;

                for (int index = 0; index < List_PlasticCards.Count; index++)
                {
                    if (List_PlasticCards[index].Name == tile.Text)
                    {
                        List_PlasticCards.RemoveAt(index);

                        for (int XmlChildIndex = 0; XmlChildIndex < XmlAccountsDocument.DocumentElement.ChildNodes.Count; XmlChildIndex++)
                        {
                            if (XmlAccountsDocument.DocumentElement.ChildNodes[XmlChildIndex].Attributes["type"].Value == "PlasticCard"
                                && XmlAccountsDocument.DocumentElement.ChildNodes[XmlChildIndex].ChildNodes[0].InnerText == tile.Text)
                            {
                                XmlAccountsDocument.DocumentElement.RemoveChild(XmlAccountsDocument.DocumentElement.ChildNodes[XmlChildIndex]);
                                break;
                            }
                        }

                        break;
                    }
                }

                TileManager.PlasticCardsTab.DeleteTile(tile);
            }
        }



        /// <summary>
        /// Получить структуру PlasticCard по её "Объекту на форме"
        /// </summary>
        /// <param name="tile">Объект формы</param>
        /// <returns></returns>
        public static PlasticCard GetCardByTile(MetroTile tile)
        {
            for (int index = 0; index < List_PlasticCards.Count; index++)
            {
                if (List_PlasticCards[index].Name == tile.Text)
                {
                    return List_PlasticCards[index];
                }
            }

            throw new Exception("Card not found");
        }

        public static void SaveAll()
        {
            XmlAccountsDocument.Save(Properties.Resources.AccountsFile);
        }
    }


    ///<summary>
    /// Класс, который отвечает за элементы 'Tile' на форме
    /// </summary>
    public static class TileManager
    {
        public static Explorer GlavnForm;
        public static MetroTabPage BankAccountsPage;
        public static MetroTabPage PlasticCardsPage;


        ///<summary>
        /// Класс, для работы с элементами Tile вкладки банковских счетов
        /// </summary>
        public static class BankAccountsTab
        {
            private static List<MetroTile> TileList = new List<MetroTile>();

            /// <summary>
            /// Удалить элемент Tile и пересчитать расположение их на форме
            /// </summary>
            /// <param name="tile"></param>
            public static void DeleteTile(MetroTile tile)
            {
                BankAccountsPage.Controls.Remove(tile);
                TileList.Remove(tile);
                RePaint();
            }


            /// <summary>
            ///    Добавление элемента Tile на форму и в лист
            /// </summary>
            public static MetroTile AddTile(string TileText)
            {
                MetroTile newTile = new MetroTile();

                newTile.ActiveControl = null;
                newTile.Location = new System.Drawing.Point(0, 0);
                newTile.Name = "BMetroTile" + (TileList.Count + 1).ToString();
                newTile.Size = new System.Drawing.Size(184, 136);
                newTile.TabIndex = TileList.Count + 1;
                newTile.Text = TileText;
                newTile.Theme = BankAccountsPage.Theme;
                newTile.TileImage = global::FinanceManager.Properties.Resources.Coins;
                newTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                newTile.UseSelectable = true;
                newTile.UseTileImage = true;
                newTile.MouseMove += GlavnForm.MouseOnTile;


                BankAccountsPage.Controls.Add(newTile);
                TileList.Add(newTile);

                RePaint();

                return newTile;
            }


            //Хранит в себе количество элементов в строке ДО изменения размера окна пользователем
            private static byte CountTileInRow = 0;

            /// <summary>
            ///     Нужно ли перерисовывать элементы Tile на вкладке
            /// </summary>
            public static bool RePaintAvailable()
            {
                if ((byte)Math.Ceiling(BankAccountsPage.Width / (184f + 85)) != CountTileInRow) return true;
                return false;
            }

            /// <summary>
            /// Перерисовка расположения элементов Tile на вкладке
            /// </summary>
            public static void RePaint()
            {
                //Расстояние между блоками 'Tile' на форме по горизонтали(в строке), 
                //ОТСТУП ТАК ЖЕ ПРИМЕНЯЕТСЯ ДЛЯ ПЕРВОГО ЭЛЕМЕНТА В СТРОКЕ
                byte horisontalOffset = 20;

                //Расстояние между блоками 'Tile' на форме по вертикали(т.е. между строками)
                byte verticalOffset = 20;

                CountTileInRow = (byte)Math.Ceiling(BankAccountsPage.Width / (184f + 85));//Количество элементов в строке
                byte CountRows = (byte)Math.Ceiling(BankAccountsPage.Height / 136f); //Количество строк
                byte TileIndex = 0; //Индекс элемента, положение которого выставляется


                int Y = 18; //Координата по Y для строки
                for (byte Row = 0; Row < CountRows && TileIndex < TileList.Count; Row++)
                {
                    for (byte TileNumber = 0; TileNumber < CountTileInRow && TileIndex < TileList.Count; TileNumber++)
                    {
                        int X = ((horisontalOffset * TileNumber + 1) + (TileNumber * 184)); //Координата по X для этого элемента

                        TileList[TileIndex].Location = new System.Drawing.Point(X, Y);
                        TileIndex++;

                        //ONLY DEBUG
                        //MessageBox.Show($" Установка форматирования для Строка {Row} Элемент {TileNumber}\n Координаты X,Y {X},{Y}");
                    }

                    Y += verticalOffset + 136;
                }
            }
        }



        ///<summary>
        /// Класс, для работы с элементами Tile вкладки банковских счетов
        /// </summary>
        public static class PlasticCardsTab
        {
            private static List<MetroTile> TileList = new List<MetroTile>();

            /// <summary>
            /// Удалить элемент Tile и пересчитать расположение их на форме
            /// </summary>
            /// <param name="tile"></param>
            public static void DeleteTile(MetroTile tile)
            {
                PlasticCardsPage.Controls.Remove(tile);
                TileList.Remove(tile);
                RePaint();
            }


            /// <summary>
            ///    Добавление элемента Tile на форму и в лист
            /// </summary>
            public static MetroTile AddTile(string TileText)
            {
                MetroTile newTile = new MetroTile();

                newTile.ActiveControl = null;
                newTile.Location = new System.Drawing.Point(0, 0);
                newTile.Name = "PMetroTile" + (TileList.Count + 1).ToString();
                newTile.Size = new System.Drawing.Size(184, 136);
                newTile.TabIndex = TileList.Count + 1;
                newTile.Text = TileText;
                newTile.Theme = BankAccountsPage.Theme;
                newTile.TileImage = global::FinanceManager.Properties.Resources.PlasticCard;
                newTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                newTile.UseSelectable = true;
                newTile.UseTileImage = true;
                newTile.MouseMove += GlavnForm.MouseOnTile;
                
                PlasticCardsPage.Controls.Add(newTile);
                TileList.Add(newTile);

                RePaint();

                return newTile;
            }


            //Хранит в себе количество элементов в строке ДО изменения размера окна пользователем
            private static byte CountTileInRow = 0;

            /// <summary>
            ///     Возвращает True, если количество элементов на форме не совпадает количеством элементов, которое можно сейчас нарисовать на форме
            /// </summary>
            public static bool RePaintAvailable()
            {
                if ((byte)Math.Ceiling(PlasticCardsPage.Width / (184f + 85)) != CountTileInRow) return true;
                return false;
            }

            /// <summary>
            /// Перерисовка расположения элементов Tile на вкладке
            /// </summary>
            public static void RePaint()
            {
                //Расстояние между блоками 'Tile' на форме по горизонтали(в строке), 
                //ОТСТУП ТАК ЖЕ ПРИМЕНЯЕТСЯ ДЛЯ ПЕРВОГО ЭЛЕМЕНТА В СТРОКЕ
                byte horisontalOffset = 20;

                //Расстояние между блоками 'Tile' на форме по вертикали(т.е. между строками)
                byte verticalOffset = 20;

                CountTileInRow = (byte)Math.Ceiling(PlasticCardsPage.Width / (184f + 85));//Количество элементов в строке
                byte CountRows = (byte)Math.Ceiling(PlasticCardsPage.Height / 136f); //Количество строк
                byte TileIndex = 0; //Индекс элемента, положение которого выставляется


                int Y = 18; //Координата по Y для строки
                for (byte Row = 0; Row < CountRows && TileIndex < TileList.Count; Row++)
                {
                    for (byte TileNumber = 0; TileNumber < CountTileInRow && TileIndex < TileList.Count; TileNumber++)
                    {
                        int X = ((horisontalOffset * TileNumber + 1) + (TileNumber * 184)); //Координата по X для этого элемента

                        TileList[TileIndex].Location = new System.Drawing.Point(X, Y);
                        TileIndex++;
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
        static List<CurrencyTableElement> CurrencyTable = new List<CurrencyTableElement>();

        /// <summary>
        /// Обновление курсов валют
        /// </summary>
        public static void Refresh()
        {
            foreach(byte num in Enum.GetValues(typeof(CurrencyType)))
            {
                foreach (byte num1 in Enum.GetValues(typeof(CurrencyType)))
                {
                    if (num == num1)
                        continue;

                    CurrencyTableElement element = new CurrencyTableElement()
                    {
                        currency1 = (CurrencyType)num,
                        currency2 = (CurrencyType)num1,
                        cost = 5.555m
                    };

                    CurrencyTable.Add(element);
                }
            }
        }


        /// <summary>
        /// Получение курса валюты 1 по отношению к валюте 2
        /// </summary>
        /// <param name="currency1">Валюта 1</param>
        /// <param name="currency2">Валюта 2</param>
        /// <returns></returns>
        public static decimal getCost(CurrencyType currency1, CurrencyType currency2)
        {
            foreach(CurrencyTableElement element in CurrencyTable)
            {
                if(element.currency1 == currency1 && 
                   element.currency2 == currency2)
                {
                    return element.cost;
                }
            }

            return 0;
        }
    }

}
