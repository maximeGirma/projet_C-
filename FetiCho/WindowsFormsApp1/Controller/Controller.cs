using InterfaceModelView;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using WindowsFormsApp1.Model;

namespace FetiCho
{
    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    
    class Controller
    {
        private static Controller controller = null;

        //private IView mainFrame= new MainFrame();
        private IModel model = Model.getInstance();

        private Controller()
        {
            
        }
        public static Controller getInstance()
        {
            if (controller == null)
            {
                
                controller = new Controller();
            }
            
            return controller;
        }
        /*public IView getView()
        {
            return mainFrame;
        }
        */
        public MySqlDataAdapter getData()
        {
            return model.GetAllStoredData();
        }

        public Boolean importTxt()
        {
           Boolean importWorked = model.ImportDataFromTxt();
            if (importWorked) { return true; } else { return false; }
        }
        public MySqlDataAdapter getDataByDate(DateTime startDate, DateTime endDate)
        {
            return model.GetStoredDataByDate(startDate, endDate);
        }
    }
}
