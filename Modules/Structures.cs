using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FinanceManager.Modules.Enums;

namespace FinanceManager.Modules.Structures
{   
    public struct BankAccount
    {
        public string AccountName;
        public string BankName;
        public string AccountNumber;
        public decimal AccountAmount;
        public CurrencyType Currency;

        public MetroFramework.Controls.MetroTile AccountFormTile;
    }

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

    public struct Operation
    {
        public UInt32 OperationNumber;
        public string OperationName;
        public string From;
        public string To;
        public decimal Sum;
        public CurrencyType Currency;
        public decimal Balance; //Остаток 
    }
}
