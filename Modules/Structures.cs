using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Modules.Enums;

namespace FinanceManager.Modules.Structures
{

    public struct OtherAccount
    {
        public string AccountName;
        public float AccountAmount;
        public CurrencyType Currency;
    }

    public struct BankAccount
    {
        public string AccountName;
        public string BankName;
        public string AccountNumber;
        public float AccountAmount;
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
        public float AccountAmount;
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
}
