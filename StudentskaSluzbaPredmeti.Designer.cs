namespace StudentskaSluzba
{
    partial class frmStudentskaSluzbaPredmeti
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
            this.dataGridViewPredmet = new System.Windows.Forms.DataGridView();
            this.lblPredmetObavezan = new System.Windows.Forms.Label();
            this.cmbPredmetObavezan = new System.Windows.Forms.ComboBox();
            this.txtPredmetEspb = new System.Windows.Forms.TextBox();
            this.lblPredmetEspb = new System.Windows.Forms.Label();
            this.lblPredmetMnemo = new System.Windows.Forms.Label();
            this.txtPredmetMnemo = new System.Windows.Forms.TextBox();
            this.txtPredmetNaziv = new System.Windows.Forms.TextBox();
            this.cmbPredmetPredmeti = new System.Windows.Forms.ComboBox();
            this.lblPredmetNaziv = new System.Windows.Forms.Label();
            this.grpPredmeti = new System.Windows.Forms.GroupBox();
            this.btnPredmetBrisanje = new System.Windows.Forms.Button();
            this.btnPredmetIzmena = new System.Windows.Forms.Button();
            this.btnPredmetUnos = new System.Windows.Forms.Button();
            this.lblPredmeti = new System.Windows.Forms.LinkLabel();
            this.lblPredmetiLogin = new System.Windows.Forms.Label();
            this.lblPredmetiLoginPrikaz = new System.Windows.Forms.Label();
            this.lblPredmetiPredmeti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).BeginInit();
            this.grpPredmeti.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPredmet
            // 
            this.dataGridViewPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPredmet.Location = new System.Drawing.Point(775, 47);
            this.dataGridViewPredmet.Name = "dataGridViewPredmet";
            this.dataGridViewPredmet.Size = new System.Drawing.Size(575, 336);
            this.dataGridViewPredmet.TabIndex = 16;
            // 
            // lblPredmetObavezan
            // 
            this.lblPredmetObavezan.AutoSize = true;
            this.lblPredmetObavezan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetObavezan.Location = new System.Drawing.Point(40, 160);
            this.lblPredmetObavezan.Name = "lblPredmetObavezan";
            this.lblPredmetObavezan.Size = new System.Drawing.Size(89, 20);
            this.lblPredmetObavezan.TabIndex = 7;
            this.lblPredmetObavezan.Text = "Obavezan";
            // 
            // cmbPredmetObavezan
            // 
            this.cmbPredmetObavezan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPredmetObavezan.FormattingEnabled = true;
            this.cmbPredmetObavezan.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.cmbPredmetObavezan.Location = new System.Drawing.Point(135, 152);
            this.cmbPredmetObavezan.Name = "cmbPredmetObavezan";
            this.cmbPredmetObavezan.Size = new System.Drawing.Size(213, 28);
            this.cmbPredmetObavezan.TabIndex = 4;
            this.cmbPredmetObavezan.SelectedIndexChanged += new System.EventHandler(this.cmbPredmetObavezan_SelectedIndexChanged_1);
            // 
            // txtPredmetEspb
            // 
            this.txtPredmetEspb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredmetEspb.Location = new System.Drawing.Point(133, 95);
            this.txtPredmetEspb.Name = "txtPredmetEspb";
            this.txtPredmetEspb.Size = new System.Drawing.Size(213, 26);
            this.txtPredmetEspb.TabIndex = 3;
            // 
            // lblPredmetEspb
            // 
            this.lblPredmetEspb.AutoSize = true;
            this.lblPredmetEspb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetEspb.Location = new System.Drawing.Point(40, 95);
            this.lblPredmetEspb.Name = "lblPredmetEspb";
            this.lblPredmetEspb.Size = new System.Drawing.Size(56, 20);
            this.lblPredmetEspb.TabIndex = 5;
            this.lblPredmetEspb.Text = "ESPB";
            // 
            // lblPredmetMnemo
            // 
            this.lblPredmetMnemo.AutoSize = true;
            this.lblPredmetMnemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetMnemo.Location = new System.Drawing.Point(40, 223);
            this.lblPredmetMnemo.Name = "lblPredmetMnemo";
            this.lblPredmetMnemo.Size = new System.Drawing.Size(67, 20);
            this.lblPredmetMnemo.TabIndex = 11;
            this.lblPredmetMnemo.Text = "Mnemo";
            // 
            // txtPredmetMnemo
            // 
            this.txtPredmetMnemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredmetMnemo.Location = new System.Drawing.Point(135, 223);
            this.txtPredmetMnemo.Name = "txtPredmetMnemo";
            this.txtPredmetMnemo.Size = new System.Drawing.Size(121, 26);
            this.txtPredmetMnemo.TabIndex = 6;
            // 
            // txtPredmetNaziv
            // 
            this.txtPredmetNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredmetNaziv.Location = new System.Drawing.Point(133, 34);
            this.txtPredmetNaziv.Name = "txtPredmetNaziv";
            this.txtPredmetNaziv.Size = new System.Drawing.Size(239, 26);
            this.txtPredmetNaziv.TabIndex = 0;
            // 
            // cmbPredmetPredmeti
            // 
            this.cmbPredmetPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPredmetPredmeti.FormattingEnabled = true;
            this.cmbPredmetPredmeti.Location = new System.Drawing.Point(384, 34);
            this.cmbPredmetPredmeti.Name = "cmbPredmetPredmeti";
            this.cmbPredmetPredmeti.Size = new System.Drawing.Size(338, 28);
            this.cmbPredmetPredmeti.TabIndex = 7;
            this.cmbPredmetPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmetPredmeti_SelectedIndexChanged);
            // 
            // lblPredmetNaziv
            // 
            this.lblPredmetNaziv.AutoSize = true;
            this.lblPredmetNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetNaziv.Location = new System.Drawing.Point(37, 34);
            this.lblPredmetNaziv.Name = "lblPredmetNaziv";
            this.lblPredmetNaziv.Size = new System.Drawing.Size(52, 20);
            this.lblPredmetNaziv.TabIndex = 0;
            this.lblPredmetNaziv.Text = "Naziv";
            // 
            // grpPredmeti
            // 
            this.grpPredmeti.Controls.Add(this.lblPredmetiPredmeti);
            this.grpPredmeti.Controls.Add(this.btnPredmetBrisanje);
            this.grpPredmeti.Controls.Add(this.btnPredmetIzmena);
            this.grpPredmeti.Controls.Add(this.btnPredmetUnos);
            this.grpPredmeti.Controls.Add(this.lblPredmetNaziv);
            this.grpPredmeti.Controls.Add(this.cmbPredmetPredmeti);
            this.grpPredmeti.Controls.Add(this.txtPredmetNaziv);
            this.grpPredmeti.Controls.Add(this.txtPredmetMnemo);
            this.grpPredmeti.Controls.Add(this.lblPredmetMnemo);
            this.grpPredmeti.Controls.Add(this.lblPredmetEspb);
            this.grpPredmeti.Controls.Add(this.txtPredmetEspb);
            this.grpPredmeti.Controls.Add(this.cmbPredmetObavezan);
            this.grpPredmeti.Controls.Add(this.lblPredmetObavezan);
            this.grpPredmeti.Location = new System.Drawing.Point(39, 47);
            this.grpPredmeti.Name = "grpPredmeti";
            this.grpPredmeti.Size = new System.Drawing.Size(730, 357);
            this.grpPredmeti.TabIndex = 15;
            this.grpPredmeti.TabStop = false;
            this.grpPredmeti.Text = "Predmeti";
            // 
            // btnPredmetBrisanje
            // 
            this.btnPredmetBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredmetBrisanje.Location = new System.Drawing.Point(412, 316);
            this.btnPredmetBrisanje.Name = "btnPredmetBrisanje";
            this.btnPredmetBrisanje.Size = new System.Drawing.Size(100, 35);
            this.btnPredmetBrisanje.TabIndex = 17;
            this.btnPredmetBrisanje.Text = "Brisanje";
            this.btnPredmetBrisanje.UseVisualStyleBackColor = true;
            this.btnPredmetBrisanje.Click += new System.EventHandler(this.btnPredmetBrisanje_Click);
            // 
            // btnPredmetIzmena
            // 
            this.btnPredmetIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredmetIzmena.Location = new System.Drawing.Point(272, 316);
            this.btnPredmetIzmena.Name = "btnPredmetIzmena";
            this.btnPredmetIzmena.Size = new System.Drawing.Size(100, 35);
            this.btnPredmetIzmena.TabIndex = 16;
            this.btnPredmetIzmena.Text = "Izmena";
            this.btnPredmetIzmena.UseVisualStyleBackColor = true;
            this.btnPredmetIzmena.Click += new System.EventHandler(this.btnPredmetIzmena_Click);
            // 
            // btnPredmetUnos
            // 
            this.btnPredmetUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredmetUnos.Location = new System.Drawing.Point(133, 316);
            this.btnPredmetUnos.Name = "btnPredmetUnos";
            this.btnPredmetUnos.Size = new System.Drawing.Size(100, 35);
            this.btnPredmetUnos.TabIndex = 15;
            this.btnPredmetUnos.Text = "Unos";
            this.btnPredmetUnos.UseVisualStyleBackColor = true;
            this.btnPredmetUnos.Click += new System.EventHandler(this.btnPredmetUnos_Click);
            // 
            // lblPredmeti
            // 
            this.lblPredmeti.AutoSize = true;
            this.lblPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmeti.Location = new System.Drawing.Point(1278, 13);
            this.lblPredmeti.Name = "lblPredmeti";
            this.lblPredmeti.Size = new System.Drawing.Size(65, 20);
            this.lblPredmeti.TabIndex = 17;
            this.lblPredmeti.TabStop = true;
            this.lblPredmeti.Text = "Logout";
            this.lblPredmeti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPredmeti_LinkClicked);
            // 
            // lblPredmetiLogin
            // 
            this.lblPredmetiLogin.AutoSize = true;
            this.lblPredmetiLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetiLogin.Location = new System.Drawing.Point(1168, 13);
            this.lblPredmetiLogin.Name = "lblPredmetiLogin";
            this.lblPredmetiLogin.Size = new System.Drawing.Size(53, 20);
            this.lblPredmetiLogin.TabIndex = 18;
            this.lblPredmetiLogin.Text = "Login";
            // 
            // lblPredmetiLoginPrikaz
            // 
            this.lblPredmetiLoginPrikaz.AutoSize = true;
            this.lblPredmetiLoginPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetiLoginPrikaz.Location = new System.Drawing.Point(1224, 14);
            this.lblPredmetiLoginPrikaz.Name = "lblPredmetiLoginPrikaz";
            this.lblPredmetiLoginPrikaz.Size = new System.Drawing.Size(46, 17);
            this.lblPredmetiLoginPrikaz.TabIndex = 19;
            this.lblPredmetiLoginPrikaz.Text = "label1";
            // 
            // lblPredmetiPredmeti
            // 
            this.lblPredmetiPredmeti.AutoSize = true;
            this.lblPredmetiPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetiPredmeti.Location = new System.Drawing.Point(387, 16);
            this.lblPredmetiPredmeti.Name = "lblPredmetiPredmeti";
            this.lblPredmetiPredmeti.Size = new System.Drawing.Size(64, 17);
            this.lblPredmetiPredmeti.TabIndex = 18;
            this.lblPredmetiPredmeti.Text = "Predmeti";
            // 
            // frmStudentskaSluzbaPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 416);
            this.Controls.Add(this.lblPredmetiLoginPrikaz);
            this.Controls.Add(this.lblPredmetiLogin);
            this.Controls.Add(this.lblPredmeti);
            this.Controls.Add(this.dataGridViewPredmet);
            this.Controls.Add(this.grpPredmeti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentskaSluzbaPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PREDMETI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).EndInit();
            this.grpPredmeti.ResumeLayout(false);
            this.grpPredmeti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPredmet;
        private System.Windows.Forms.Label lblPredmetObavezan;
        private System.Windows.Forms.ComboBox cmbPredmetObavezan;
        private System.Windows.Forms.TextBox txtPredmetEspb;
        private System.Windows.Forms.Label lblPredmetEspb;
        private System.Windows.Forms.Label lblPredmetMnemo;
        private System.Windows.Forms.TextBox txtPredmetMnemo;
        private System.Windows.Forms.TextBox txtPredmetNaziv;
        private System.Windows.Forms.ComboBox cmbPredmetPredmeti;
        private System.Windows.Forms.Label lblPredmetNaziv;
        private System.Windows.Forms.GroupBox grpPredmeti;
        private System.Windows.Forms.Button btnPredmetBrisanje;
        private System.Windows.Forms.Button btnPredmetIzmena;
        private System.Windows.Forms.Button btnPredmetUnos;
        private System.Windows.Forms.LinkLabel lblPredmeti;
        private System.Windows.Forms.Label lblPredmetiLogin;
        private System.Windows.Forms.Label lblPredmetiLoginPrikaz;
        private System.Windows.Forms.Label lblPredmetiPredmeti;
    }
}