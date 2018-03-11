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
            
            MySqlCommand dataFromBase = SelectAll.Data(DataBaseConnect.getInstance());
            return  DataBaseToWinForm.Transform(dataFromBase);
            
        }


        public static MySqlDataAdapter ByDate(DateTime startDate,DateTime endDate, String id_sensor) {
            String strStartDate = MapToDataBase.MapDate(startDate);
            String strEndDate = MapToDataBase.MapDate(endDate);

            String sql_query = 
                "SELECT * FROM dataline WHERE dataline.dateTime >= '" + strStartDate +
                "' AND dataline.dateTime <= '" + strEndDate + "'"+
                " AND dataline.idSensor = '"+id_sensor + "'";

            MySqlCommand dataFromBase = SelectInDataBase.WithParameter(sql_query, DataBaseConnect.getInstance());
            return DataBaseToWinForm.Transform(dataFromBase);
        }
    }
}
