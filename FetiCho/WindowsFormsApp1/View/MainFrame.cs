using FetiCho;
using InterfaceModelView;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using WindowsFormsApp1.View.Components;
using System.Security.Permissions;
using System.Security;

namespace View

{
    public partial class MainFrame : Form, IView
    {
        private Controller controller = null;
        public DateTime startDate;
        public DateTime endDate;
        public String email_recipient;
        public Boolean blokeur = false;
        public String id_sensor_to_display;
        public MainFrame()
        {
            InitializeComponent();

        }
        public void setController()
        {
            if (controller == null) controller = Controller.getInstance();
        }

        public void DisplayDataList(DataList dataList) { }

        public void DisplayInfo() { }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idsuppr = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            textBox1.Text = idsuppr.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";
                MySqlConnection conn = new MySqlConnection(pathDb);
                conn.Open();
                string Query = "DELETE FROM `dataline` WHERE `id`='" + int.Parse(textBox1.Text) + "';";


                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);

                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                conn.Close();
                tableauDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void envoiEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mailbox recupere le mail et appelle le reste de la fonction (sending_mail)
            GetEmail mailbox = new GetEmail(this);
            mailbox.Show();
        }
        public void sending_mail() { 

            MailMessage email = new MailMessage();
            email.From = new MailAddress("bo76h211@gmail.com");
            email.To.Add(new MailAddress(email_recipient));
            email.IsBodyHtml = true;
            email.Subject = "objet du mail";
            email.Body = " contenu du mail";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("bo76h211@gmail.com", "Cesi2017");

            string file = @"C:\Users\maxime\Desktop\aaaa";
            // Create  the file attachment for this e-mail message.
            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add the file attachment to this e-mail message.
            email.Attachments.Add(data);

            try
            {
                smtp.Send(email);
                MessageBox.Show("email envoye");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string number = "11161806 20170524 11585745";
            string notes = "Test 1 semaine";
            string description = "SN: 11161806";
            string interval = " 300 secondes";
            string alarm = "-20.0 , 100.0";
            int totalRecord = 11;
            string tempStat = "31.0 / 28.1 / 29.0 / 29.0";
            string humidityStat = "56.0 / 44.0 / 49.0 %";
            DateTime startTime = new DateTime(2017,05,24, 12,32,35);
            DateTime endTime = new DateTime(2017, 05, 24, 13, 57, 35);
            string totalTime = "01:25:00";

            Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"D:\Zoran\Downloads\Dropbox\C\Dropbox\ProjetC#\4_Documents\test.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph1 = new Paragraph("Fichier créé le : " + DateTime.Now);
            paragraph1.SpacingAfter = 10;

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("DATA REPORT"));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell.Padding = 10;

            table.AddCell(cell);

            table.AddCell("No:");
            table.AddCell(number);
            table.AddCell("Notes: ");
            table.AddCell(notes);
            table.AddCell("Description:");
            table.AddCell(description);
            table.AddCell("Storage Interval:");
            table.AddCell(interval);
            table.AddCell("Alarm Settings:");
            table.AddCell(alarm);
            table.AddCell("Total Records:");
            table.AddCell((totalRecord).ToString());
            table.AddCell("Temp Max/ Min / Avg / MKT:");
            table.AddCell(tempStat);
            table.AddCell("Humidity Max/ Min / Avg:");
            table.AddCell(humidityStat);
            table.AddCell(" Start Time: ");
            table.AddCell(startTime.ToString());
            table.AddCell("End Time: ");
            table.AddCell(endTime.ToString());
            table.AddCell("Total Time:");
            table.AddCell(totalTime);

            Paragraph paragraph2 = new Paragraph("Temperature and humidity data");
            paragraph2.SpacingBefore = 10;
            paragraph2.SpacingAfter = 10;

            Paragraph paragraph3 = new Paragraph("Temperature and humidity graph");
            paragraph2.SpacingBefore = 10;
            paragraph2.SpacingAfter = 10;

            /* TABLEAU 
              -----------------------------------------*/
            PdfPTable table1 = new PdfPTable(dataGridView1.Columns.Count);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table1.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
            }

            table1.HeaderRows = 1;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++ )
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++ )
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table1.AddCell(new Phrase(dataGridView1[k,i].Value.ToString()));
                    }
                }
            }

            /* GRAPHIQUE
            ----------------------------------------------- */
            var chartimage = new MemoryStream();
            chart1.SaveImage(chartimage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());            

            /* AJOUT AU FICHIER
             * ---------------------------------------------*/
            doc.Add(paragraph1);
            doc.Add(table);
            doc.Add(paragraph2);
            doc.Add(table1);
            doc.Add(paragraph2);
            doc.Add(Chart_image);

            doc.Close();
        }

        private void send_mail(object sender, EventArgs e)
        {

        }

        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void importTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Deleted");
            
            

            
            Console.WriteLine("Connected");

            string path = @"D:\Zoran\Downloads\Dropbox\C\Dropbox\ProjetC#\4_Documents\Sourcedonnées.txt";
            

            String[] file = File.ReadAllLines(path);         // Read the file and display it line by line.  

            
            
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string number = "11161806 20170524 11585745";
            string notes = "Test 1 semaine";
            string description = "SN: 11161806";
            string interval = " 300 secondes";
            string alarm = "-20.0 , 100.0";
            int totalRecord = 11;
            string tempStat = "31.0 / 28.1 / 29.0 / 29.0";
            string humidityStat = "56.0 / 44.0 / 49.0 %";
            DateTime startTime = new DateTime(2017, 05, 24, 12, 32, 35);
            DateTime endTime = new DateTime(2017, 05, 24, 13, 57, 35);
            string totalTime = "01:25:00";

            Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\maxime\Desktop\testpdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph1 = new Paragraph("Fichier créé le : " + DateTime.Now);
            paragraph1.SpacingAfter = 10;

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("DATA REPORT"));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell.Padding = 10;

            table.AddCell(cell);

            table.AddCell("No:");
            table.AddCell(number);
            table.AddCell("Notes: ");
            table.AddCell(notes);
            table.AddCell("Description:");
            table.AddCell(description);
            table.AddCell("Storage Interval:");
            table.AddCell(interval);
            table.AddCell("Alarm Settings:");
            table.AddCell(alarm);
            table.AddCell("Total Records:");
            table.AddCell((totalRecord).ToString());
            table.AddCell("Temp Max/ Min / Avg / MKT:");
            table.AddCell(tempStat);
            table.AddCell("Humidity Max/ Min / Avg:");
            table.AddCell(humidityStat);
            table.AddCell(" Start Time: ");
            table.AddCell(startTime.ToString());
            table.AddCell("End Time: ");
            table.AddCell(endTime.ToString());
            table.AddCell("Total Time:");
            table.AddCell(totalTime);

            Paragraph paragraph2 = new Paragraph("Temperature and humidity data");
            paragraph2.SpacingBefore = 10;
            paragraph2.SpacingAfter = 10;

            Paragraph paragraph3 = new Paragraph("Temperature and humidity graph");
            paragraph2.SpacingBefore = 10;
            paragraph2.SpacingAfter = 10;

            /* TABLEAU 
              -----------------------------------------*/
            PdfPTable table1 = new PdfPTable(dataGridView1.Columns.Count);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table1.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
            }

            table1.HeaderRows = 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table1.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                    }
                }
            }

            /* GRAPHIQUE
            ----------------------------------------------- */
            var chartimage = new MemoryStream();
            chart1.SaveImage(chartimage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());

            /* AJOUT AU FICHIER
             * ---------------------------------------------*/
            doc.Add(paragraph1);
            doc.Add(table);
            doc.Add(paragraph2);
            doc.Add(table1);
            doc.Add(paragraph2);
            doc.Add(Chart_image);

            doc.Close();

        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";
            MySqlConnection conn = new MySqlConnection(pathDb);
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            Console.WriteLine("Connected");


            MySqlCommand cmd = new MySqlCommand("SELECT * from `dataline`", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine("id, date, temperature, taux d'humidite");
            String sensor_name = "error";
            while (reader.Read())
            {
                csvcontent.AppendLine(reader.GetString("idSensor") + "," +
                    reader.GetString("dateTime") + "," +
                    reader.GetString("temperature").Replace(",", ".") + "," +
                    reader.GetString("humidity") + "%");
                sensor_name = reader.GetString("idSensor");
            }
            Console.ReadLine();

            
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String pathCsv = openFileDialog1.SelectedPath;

                
                File.AppendAllText(pathCsv + "\\"+sensor_name, csvcontent.ToString());



            }
        }

        private void prepareTableauDisplay(object sender, EventArgs e)
        {
            this.setController();
            
                
                CalendarDateSelector dateselector = new CalendarDateSelector(this);
                dateselector.ShowDialog();
                this.tableauDisplay();
                


        }
        private void tableauDisplay()
        {
            try
            {
                MySqlDataAdapter sda = controller.getDataByDate(startDate, endDate, id_sensor_to_display);

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void graphiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";
            MySqlConnection conn = new MySqlConnection(pathDb);
            conn.Open();
            MySqlCommand query = new MySqlCommand("SELECT * FROM `dataline`", conn);

            MySqlDataReader myReader;

            myReader = query.ExecuteReader();

            while (myReader.Read())
            {
                this.chart1.Series["Temperature"].Points.AddXY(myReader.GetString("id"), myReader.GetDouble("temperature"));
                this.chart1.Series["Humidité"].Points.AddXY(myReader.GetString("id"), myReader.GetDouble("humidity"));
            }

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void import_txt_button(object sender, EventArgs e)
        {
            setController();
            
            Boolean itWorked = controller.importTxt();
            if (itWorked) { MessageBox.Show("Import effectué avec succés"); }else { MessageBox.Show("Erreur: Echec de l'import"); }
        }
    }
}
