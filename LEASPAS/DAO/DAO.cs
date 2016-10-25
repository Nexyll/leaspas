using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LEASPAS.DAO {
    public abstract class DAO {
        public SQLiteConnection Connection { get; set; }

        protected DAO(SQLiteConnection connection)
        {
            Connection = connection;
        }
    }
}
