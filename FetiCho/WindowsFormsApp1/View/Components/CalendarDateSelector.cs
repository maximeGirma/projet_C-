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

namespace WindowsFormsApp1.View.Components
{
    public partial class CalendarDateSelector : Form
    {
        MainFrame mainframe;
        public CalendarDateSelector(MainFrame caller)
        {
            InitializeComponent();
            mainframe = caller;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CalendarDateSelector_Load(object sender, EventArgs e)
        {

        }

        private void OK_button(object sender, EventArgs e)
        {
            
            mainframe.startDate = dateTimePicker1.Value;
            mainframe.endDate = dateTimePicker2.Value;
        }

        private void cancel_button(object sender, EventArgs e)
        {

        }
    }
}
