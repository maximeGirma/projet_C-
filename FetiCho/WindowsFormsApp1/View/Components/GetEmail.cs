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
    public partial class GetEmail : Form
    {
        MainFrame mainframe;
        public GetEmail(MainFrame caller)
        {
            InitializeComponent();
            mainframe = caller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainframe.email_recipient = textBox1.Text;
            mainframe.sending_mail();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
