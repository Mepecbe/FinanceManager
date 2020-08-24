using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Modules.Enums
{
    public enum CurrencyType : byte
    {
        USD = 0,
        BYN = 1,
        EUR = 2,
        RUB = 3
    }

    public enum CryptoCurrencyType
    {
        BTC   = 0, //Bitcoin
        ETH   = 1, //Ethereum
        ZCASH = 2 
    }
}
