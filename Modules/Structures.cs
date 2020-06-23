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
        public string AccountNumber;
        public float Money;
        public CurrencyType Currency;   //ЗАМЕНИТЬ
    }

    public struct BankAccount
    {
        public string AccountName;
        public string BankName;
        public string AccountNumber;
        public float Money;
        public CurrencyType Currency;   
    }

    public struct PlasticCard
    {
        public string Name;
        public string BankAccount;
        public string CardHolder;
        public string CardNumber;
        public string Date;
        public float Money;
        public CurrencyType Currency;   //ЗАМЕНИТЬ
    }

    public struct CryptoWallet
    {
        public string WalletID;
        public string WalletPassword;
        public string WalletAddress;
        public CryptoCurrencyType CryptoCurrency;
    }
}
