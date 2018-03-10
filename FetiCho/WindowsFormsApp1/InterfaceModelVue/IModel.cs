using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceModelView;
using MySql.Data.MySqlClient;

namespace InterfaceModelView
{
    public interface IModel
    {
        MySqlDataAdapter GetAllStoredData();
        MySqlDataAdapter GetStoredDataByDate(DateTime startDate, DateTime endDate);

        Boolean ImportDataFromTxt();

        RecipientList ImportRecipientList();

        Boolean AddRecipient(String email,String name);

        Boolean DeleteRecipient(int id_recipient);

        Boolean ExportToPdf(String email, DataList datalist);

        Boolean ExportToCsv(DataList datalist);
    }
}
