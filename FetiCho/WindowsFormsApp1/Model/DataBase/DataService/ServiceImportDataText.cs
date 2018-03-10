using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.DataBase.DataBaseAccess;
using WindowsFormsApp1.Model.DataBase.Mapper;
using WindowsFormsApp1.View.Components;

namespace WindowsFormsApp1.Model.DataBase.DataService
{
    class ServiceImportDataText
    {
        public static Boolean OneDocument() {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Storage sensor_info = new Storage();

                            String[] file = File.ReadAllLines(openFileDialog1.FileName);
                            SensorAskingPopup popup = new SensorAskingPopup(sensor_info);
                            popup.ShowDialog();
                            InsertInDataBase.rapport(DataBaseConnect.getInstance(), file, sensor_info);



                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return false;
                }

            }
            return true;
        }
        
    }
}
