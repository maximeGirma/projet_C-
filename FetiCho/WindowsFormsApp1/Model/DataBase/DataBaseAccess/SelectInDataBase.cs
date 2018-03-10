using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model.DataBase.DataBaseAccess
{
    public static class SelectInDataBase
    {
        public static MySqlCommand WithParameter(String parameter, DataBaseConnect conn)
        {
            
            return new MySqlCommand(parameter, conn.conn);
           
        }
    }
}
