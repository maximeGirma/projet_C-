using InterfaceModelView;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceModelView;



namespace View
{
    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    
    class ViewController
    {
        private static ViewController viewController = null;
        private IView mainFrame= new MainFrame();
        private IModel model = new IModel();
        private ViewController()
        {
            
        }
        public static ViewController getInstance()
        {
            if (viewController == null)
            {
                
                viewController = new ViewController();
            }
            
            return viewController;
        }
        public IView getView()
        {
            return mainFrame;
        }

        


    }
}
