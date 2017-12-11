namespace StudentskaSluzba
{
    partial class frmStudentskaSluzbaStatistika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStatistikaSmerStudent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatistikaUcitajChart = new System.Windows.Forms.Button();
            this.lblStatistikaLoginNaslov = new System.Windows.Forms.Label();
            this.lblStatistikaLoginPrikaz = new System.Windows.Forms.Label();
            this.linkStatistikaLogout = new System.Windows.Forms.LinkLabel();
            this.btnStatistikaKreirajPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistikaSmerStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistikaSmerStudent
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistikaSmerStudent.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistikaSmerStudent.Legends.Add(legend1);
            this.chartStatistikaSmerStudent.Location = new System.Drawing.Point(49, 41);
            this.chartStatistikaSmerStudent.Name = "chartStatistikaSmerStudent";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Smer";
            this.chartStatistikaSmerStudent.Series.Add(series1);
            this.chartStatistikaSmerStudent.Size = new System.Drawing.Size(411, 300);
            this.chartStatistikaSmerStudent.TabIndex = 0;
            this.chartStatistikaSmerStudent.Text = "chart1";
            // 
            // btnStatistikaUcitajChart
            // 
            this.btnStatistikaUcitajChart.Location = new System.Drawing.Point(208, 357);
            this.btnStatistikaUcitajChart.Name = "btnStatistikaUcitajChart";
            this.btnStatistikaUcitajChart.Size = new System.Drawing.Size(99, 23);
            this.btnStatistikaUcitajChart.TabIndex = 1;
            this.btnStatistikaUcitajChart.Text = "Ucitaj CHART";
            this.btnStatistikaUcitajChart.UseVisualStyleBackColor = true;
            this.btnStatistikaUcitajChart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatistikaLoginNaslov
            // 
            this.lblStatistikaLoginNaslov.AutoSize = true;
            this.lblStatistikaLoginNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistikaLoginNaslov.Location = new System.Drawing.Point(626, 13);
            this.lblStatistikaLoginNaslov.Name = "lblStatistikaLoginNaslov";
            this.lblStatistikaLoginNaslov.Size = new System.Drawing.Size(53, 20);
            this.lblStatistikaLoginNaslov.TabIndex = 2;
            this.lblStatistikaLoginNaslov.Text = "Login";
            // 
            // lblStatistikaLoginPrikaz
            // 
            this.lblStatistikaLoginPrikaz.AutoSize = true;
            this.lblStatistikaLoginPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistikaLoginPrikaz.Location = new System.Drawing.Point(686, 13);
            this.lblStatistikaLoginPrikaz.Name = "lblStatistikaLoginPrikaz";
            this.lblStatistikaLoginPrikaz.Size = new System.Drawing.Size(51, 20);
            this.lblStatistikaLoginPrikaz.TabIndex = 3;
            this.lblStatistikaLoginPrikaz.Text = "label2";
            // 
            // linkStatistikaLogout
            // 
            this.linkStatistikaLogout.AutoSize = true;
            this.linkStatistikaLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStatistikaLogout.Location = new System.Drawing.Point(928, 13);
            this.linkStatistikaLogout.Name = "linkStatistikaLogout";
            this.linkStatistikaLogout.Size = new System.Drawing.Size(49, 20);
            this.linkStatistikaLogout.TabIndex = 4;
            this.linkStatistikaLogout.TabStop = true;
            this.linkStatistikaLogout.Text = "Back";
            this.linkStatistikaLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStatistikaLogout_LinkClicked);
            // 
            // btnStatistikaKreirajPDF
            // 
            this.btnStatistikaKreirajPDF.Location = new System.Drawing.Point(733, 357);
            this.btnStatistikaKreirajPDF.Name = "btnStatistikaKreirajPDF";
            this.btnStatistikaKreirajPDF.Size = new System.Drawing.Size(75, 23);
            this.btnStatistikaKreirajPDF.TabIndex = 5;
            this.btnStatistikaKreirajPDF.Text = "Kreiraj PDF";
            this.btnStatistikaKreirajPDF.UseVisualStyleBackColor = true;
            this.btnStatistikaKreirajPDF.Click += new System.EventHandler(this.btnStatistikaKreirajPDF_Click);
            // 
            // frmStudentskaSluzbaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 414);
            this.Controls.Add(this.btnStatistikaKreirajPDF);
            this.Controls.Add(this.linkStatistikaLogout);
            this.Controls.Add(this.lblStatistikaLoginPrikaz);
            this.Controls.Add(this.lblStatistikaLoginNaslov);
            this.Controls.Add(this.btnStatistikaUcitajChart);
            this.Controls.Add(this.chartStatistikaSmerStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentskaSluzbaStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STATISTIKA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistikaSmerStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistikaSmerStudent;
        private System.Windows.Forms.Button btnStatistikaUcitajChart;
        private System.Windows.Forms.Label lblStatistikaLoginNaslov;
        private System.Windows.Forms.Label lblStatistikaLoginPrikaz;
        private System.Windows.Forms.LinkLabel linkStatistikaLogout;
        private System.Windows.Forms.Button btnStatistikaKreirajPDF;
    }
}