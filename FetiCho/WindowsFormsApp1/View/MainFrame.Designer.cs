namespace View
{
    partial class MainFrame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTxtToolStripMenuItem,
            this.exportCsvToolStripMenuItem,
            this.envoiEmailToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // importTxtToolStripMenuItem
            // 
            this.importTxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem});
            this.importTxtToolStripMenuItem.Name = "importTxtToolStripMenuItem";
            this.importTxtToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.importTxtToolStripMenuItem.Text = "Import";
            this.importTxtToolStripMenuItem.Click += new System.EventHandler(this.importTxtToolStripMenuItem_Click);
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.txtToolStripMenuItem.Text = "txt...";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.import_txt_button);
            // 
            // exportCsvToolStripMenuItem
            // 
            this.exportCsvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvToolStripMenuItem,
            this.pdfToolStripMenuItem});
            this.exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            this.exportCsvToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exportCsvToolStripMenuItem.Text = "Export";
            this.exportCsvToolStripMenuItem.Click += new System.EventHandler(this.exportCsvToolStripMenuItem_Click);
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.csvToolStripMenuItem.Text = "csv...";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.pdfToolStripMenuItem.Text = "pdf...";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // envoiEmailToolStripMenuItem
            // 
            this.envoiEmailToolStripMenuItem.Name = "envoiEmailToolStripMenuItem";
            this.envoiEmailToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.envoiEmailToolStripMenuItem.Text = "Envoyer par email...";
            this.envoiEmailToolStripMenuItem.Click += new System.EventHandler(this.envoiEmailToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableauToolStripMenuItem,
            this.graphiqueToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            this.affichageToolStripMenuItem.Click += new System.EventHandler(this.affichageToolStripMenuItem_Click);
            // 
            // tableauToolStripMenuItem
            // 
            this.tableauToolStripMenuItem.Name = "tableauToolStripMenuItem";
            this.tableauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tableauToolStripMenuItem.Text = "Tableau";
            this.tableauToolStripMenuItem.Click += new System.EventHandler(this.tableauDisplay);
            // 
            // graphiqueToolStripMenuItem
            // 
            this.graphiqueToolStripMenuItem.Name = "graphiqueToolStripMenuItem";
            this.graphiqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graphiqueToolStripMenuItem.Text = "Graphique";
            this.graphiqueToolStripMenuItem.Click += new System.EventHandler(this.graphiqueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 10);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(438, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(499, 57);
            this.chart1.Margin = new System.Windows.Forms.Padding(20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Humidité";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(473, 256);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "Envoi Email";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.send_mail);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 323);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFrame";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoiEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableauToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
    }
}

