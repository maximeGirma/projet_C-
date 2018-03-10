using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.DataBase.DataBaseAccess
{
    static class SelectAll
    {
        public static MySqlCommand Data(DataBaseConnect connection)
        {
            return new MySqlCommand("SELECT * ", connection.conn);
            
        } 
    }
}
