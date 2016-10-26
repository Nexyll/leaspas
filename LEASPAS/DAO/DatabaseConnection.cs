using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.DAO {
    class DatabaseConnection
    {
        private static SQLiteConnection _connection;

        private DatabaseConnection()
        {
        }

        public static SQLiteConnection GetInstance()
        {
            if (_connection != null)
            {
                return _connection;
            }
            else
            {
                _connection = new SQLiteConnection("Data Source=databaseDAO.db");
                return _connection;
            }
        }
    }
}
