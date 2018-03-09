using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.DataBase.Mapper
{
    static class DataBaseToWinForm
    {
        public static MySqlDataAdapter Transform(MySqlCommand command)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = command;
            return sda;
            
        }
    }
}
