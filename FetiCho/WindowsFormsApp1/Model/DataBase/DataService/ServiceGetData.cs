using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.DataBase.DataBaseAccess;
using WindowsFormsApp1.Model.DataBase.Mapper;

namespace WindowsFormsApp1.Model.DataBase.DataService
{
    public static class ServiceGetData
    {
        public static MySqlDataAdapter all()
        {
            Console.WriteLine("1");
            MySqlCommand dataFromBase = SelectAll.Data(DataBaseConnect.getInstance());
            return  DataBaseToWinForm.Transform(dataFromBase);
            
        }
    }
}
