using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FinanceManager.Modules.Enums;

namespace FinanceManager.Modules.Structures
{   
    public interface IAccount
    {
        void AddToAccount(decimal value, CurrencyType currency);
        void SubtractFromAccount(decimal value, CurrencyType currency);
    }


    /// <summary>
    /// Bank Account
    /// </summary>
    public struct BankAccount : IAccount
    {
        public string AccountName;
        public string BankName;
        public string AccountNumber;
        public decimal AccountAmount;
        public CurrencyType Currency;

        public MetroFramework.Controls.MetroTile AccountFormTile;

        public void AddToAccount(decimal value, CurrencyType currency)
        {
            throw new NotImplementedException();
        }

        public void SubtractFromAccount(decimal value, CurrencyType currency)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Plastic Card
    /// </summary>
    public struct PlasticCard
    {
        public string Name;
        public string BankAccount;
        public string CardHolder;
        public string CardNumber;
        public string Date;
        public decimal AccountAmount;
        public CurrencyType Currency;

        public MetroFramework.Controls.MetroTile AccountFormTile;
    }

    /// <summary>
    /// Crypto Wallet
    /// </summary>
    public struct CryptoWallet
    {
        public string Name;
        public string WalletID;
        public string WalletPassword;
        public string WalletAddress;
        public CryptoCurrencyType CryptoCurrency;

        public MetroFramework.Controls.MetroTile AccountFormTile;
    }

    public struct OtherAccount
    {
        public string AccountName;
        public decimal AccountAmount;
        public CurrencyType Currency;
    }

    /// <summary>
    /// Структура, содержащая информацию об операции
    /// </summary>
    public struct Operation
    {
        public UInt32 OperationNumber; //Уникальный номер операции
        public string OperationName;   //Наименование операции
        public string From;            //Откуда
        public string To;              //Куда
        public decimal Sum;            //Сумма
        public CurrencyType Currency;  //Валюта денег, которые задействованы в переводе
        public decimal Balance;        //Остаток на балансе счета, с которого производится операция
        public decimal CurrencyСost;   //Стоимость валюты, которая задействована в переводе, по отношению к валюте счета, на который производится перевод
    }


    /// <summary>
    /// Элемент таблицы валют
    /// </summary>
    public struct CurrencyTableElement
    {
        public CurrencyType currency1;
        public CurrencyType currency2;
        public decimal cost;
    }
}
