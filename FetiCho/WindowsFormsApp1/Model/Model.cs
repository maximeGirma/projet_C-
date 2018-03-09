using InterfaceModelView;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.DataBase.DataService;

namespace WindowsFormsApp1.Model
{
    public class Model : IModel
    {
        private static Model model = null;
        private Model() { }

        public static Model getInstance()
        {
            if (model == null) model = new Model();
            return model;
        }
        public MySqlDataAdapter GetAllStoredData() { return ServiceGetData.all(); }

        public DataList GetStoredDataByDate(DateTime date) { return new DataList(); }

        public Boolean ImportDataFromTxt() { return true; }

        public RecipientList ImportRecipientList() { return new RecipientList(); }

        public Boolean AddRecipient(String email, String name) { return true; }

        public Boolean DeleteRecipient(int id_recipient) { return true; }

        public Boolean ExportToPdf(String email, DataList datalist) { return true; }

        public Boolean ExportToCsv(DataList datalist) { return true; }
    }
}
