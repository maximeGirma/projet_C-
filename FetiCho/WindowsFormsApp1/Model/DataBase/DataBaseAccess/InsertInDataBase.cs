using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model.DataBase.DataBaseAccess
{
    public static class InsertInDataBase
    {
        public static Boolean rapport(DataBaseConnect conn, String[] file, Storage sensor_info) {

            foreach (String lines in file)
            {

                string[] entries = lines.Split(' ');


                int id = int.Parse(Regex.Replace(entries[0], "[^0-9 ]", ""));
                DateTime date = System.DateTime.Parse(entries[1] + " " + entries[2]);
                double temp = double.Parse(Regex.Replace(entries[3], "[^0-9., ]", "").Replace(".", ","));
                double humidity = double.Parse(Regex.Replace(entries[4], "[^0-9., ]", "").Replace(".", ","));

                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `dataline` (`idSensor`, `dateTime`, `humidity`, `temperature`,`place`) VALUES(@id, @date, @humidity, @temp, @place)", conn.conn);
                    cmd.Parameters.AddWithValue("@idSensor", sensor_info.id_sensor);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@temp", temp);
                    cmd.Parameters.AddWithValue("@humidity", humidity);
                    cmd.Parameters.AddWithValue("@place", sensor_info.sensor_place);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;                }



            }
            return true;
        }
    }
}
