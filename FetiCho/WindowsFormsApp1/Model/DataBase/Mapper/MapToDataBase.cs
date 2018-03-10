using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model.DataBase.Mapper
{
    public static class MapToDataBase
    {
        public static String MapDate(DateTime date) {
            String strDate = date.ToString();
            MessageBox.Show(strDate);
            strDate.Replace("/", "-");
            strDate = strDate.Substring(0, 10);
            MessageBox.Show(strDate);
            return strDate;
        }
        
    }
}
