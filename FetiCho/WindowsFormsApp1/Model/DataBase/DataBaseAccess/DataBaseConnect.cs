using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.DataBase.DataBaseAccess
{
    public class DataBaseConnect
    {
        private static DataBaseConnect connection = null;
        public  MySqlConnection conn = null;
    private DataBaseConnect() {
            string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";
            conn = new MySqlConnection(pathDb);
            conn.Open();
        }
        public static DataBaseConnect getInstance() {
            if (connection == null) connection = new DataBaseConnect();
            return connection;
        }
    }
}
