using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View.Components
{
    public partial class SensorAskingPopup : Form
    {
        Storage sensor;
        public SensorAskingPopup(Storage s)
        {
            InitializeComponent();
            sensor = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton(object sender, EventArgs e)
        {

            sensor.id_sensor = textBox1.Text;
            sensor.sensor_place = textBox2.Text;
            this.Close();
        }

        
    }
}
