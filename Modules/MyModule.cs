using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

namespace FinanceManager.Modules
{
    /// <summary>
    /// Класс, для работы с операциями
    /// </summary>
    public static class Operations
    {
    }


    /// <summary>
    /// Класс, для работы со счетами
    /// </summary>
    public static class Accounts
    {

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
