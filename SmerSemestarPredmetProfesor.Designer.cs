namespace StudentskaSluzba
{
    partial class frmSmerSemestarPredmetProfesor
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
            this.cmbRelacijaSmer = new System.Windows.Forms.ComboBox();
            this.lblRelacijaSmer = new System.Windows.Forms.Label();
            this.lblRelacijaSemestar = new System.Windows.Forms.Label();
            this.cmbRelacijaSemestar = new System.Windows.Forms.ComboBox();
            this.lblRelacijaPredmet = new System.Windows.Forms.Label();
            this.cmbRelacijaPredmet = new System.Windows.Forms.ComboBox();
            this.lblRelacijaProfesor = new System.Windows.Forms.Label();
            this.cmbRelacijaProfesor = new System.Windows.Forms.ComboBox();
            this.grpRelacijaSSPP = new System.Windows.Forms.GroupBox();
            this.btnRelacijaBrisanje = new System.Windows.Forms.Button();
            this.btnRelacijaIzmena = new System.Windows.Forms.Button();
            this.btnRelacijaUnos = new System.Windows.Forms.Button();
            this.dataGridViewRelacija = new System.Windows.Forms.DataGridView();
            this.lblRelacijaLogin = new System.Windows.Forms.Label();
            this.lblRelacijaLoginPrikaz = new System.Windows.Forms.Label();
            this.lblRelacijaLogout = new System.Windows.Forms.LinkLabel();
            this.grpRelacijaSSPP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelacija)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRelacijaSmer
            // 
            this.cmbRelacijaSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelacijaSmer.FormattingEnabled = true;
            this.cmbRelacijaSmer.Location = new System.Drawing.Point(132, 39);
            this.cmbRelacijaSmer.Name = "cmbRelacijaSmer";
            this.cmbRelacijaSmer.Size = new System.Drawing.Size(374, 28);
            this.cmbRelacijaSmer.TabIndex = 0;
            this.cmbRelacijaSmer.SelectedIndexChanged += new System.EventHandler(this.cmbRelacijaSmer_SelectedIndexChanged);
            // 
            // lblRelacijaSmer
            // 
            this.lblRelacijaSmer.AutoSize = true;
            this.lblRelacijaSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaSmer.Location = new System.Drawing.Point(32, 37);
            this.lblRelacijaSmer.Name = "lblRelacijaSmer";
            this.lblRelacijaSmer.Size = new System.Drawing.Size(51, 20);
            this.lblRelacijaSmer.TabIndex = 1;
            this.lblRelacijaSmer.Text = "Smer";
            // 
            // lblRelacijaSemestar
            // 
            this.lblRelacijaSemestar.AutoSize = true;
            this.lblRelacijaSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaSemestar.Location = new System.Drawing.Point(32, 94);
            this.lblRelacijaSemestar.Name = "lblRelacijaSemestar";
            this.lblRelacijaSemestar.Size = new System.Drawing.Size(86, 20);
            this.lblRelacijaSemestar.TabIndex = 2;
            this.lblRelacijaSemestar.Text = "Semestar";
            // 
            // cmbRelacijaSemestar
            // 
            this.cmbRelacijaSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelacijaSemestar.FormattingEnabled = true;
            this.cmbRelacijaSemestar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbRelacijaSemestar.Location = new System.Drawing.Point(132, 93);
            this.cmbRelacijaSemestar.Name = "cmbRelacijaSemestar";
            this.cmbRelacijaSemestar.Size = new System.Drawing.Size(91, 28);
            this.cmbRelacijaSemestar.TabIndex = 3;
            this.cmbRelacijaSemestar.SelectedIndexChanged += new System.EventHandler(this.cmbRelacijaSemestar_SelectedIndexChanged);
            // 
            // lblRelacijaPredmet
            // 
            this.lblRelacijaPredmet.AutoSize = true;
            this.lblRelacijaPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaPredmet.Location = new System.Drawing.Point(35, 151);
            this.lblRelacijaPredmet.Name = "lblRelacijaPredmet";
            this.lblRelacijaPredmet.Size = new System.Drawing.Size(76, 20);
            this.lblRelacijaPredmet.TabIndex = 4;
            this.lblRelacijaPredmet.Text = "Predmet";
            // 
            // cmbRelacijaPredmet
            // 
            this.cmbRelacijaPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelacijaPredmet.FormattingEnabled = true;
            this.cmbRelacijaPredmet.Location = new System.Drawing.Point(132, 150);
            this.cmbRelacijaPredmet.Name = "cmbRelacijaPredmet";
            this.cmbRelacijaPredmet.Size = new System.Drawing.Size(374, 28);
            this.cmbRelacijaPredmet.TabIndex = 5;
            this.cmbRelacijaPredmet.SelectedIndexChanged += new System.EventHandler(this.cmbRelacijaPredmet_SelectedIndexChanged);
            // 
            // lblRelacijaProfesor
            // 
            this.lblRelacijaProfesor.AutoSize = true;
            this.lblRelacijaProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaProfesor.Location = new System.Drawing.Point(38, 207);
            this.lblRelacijaProfesor.Name = "lblRelacijaProfesor";
            this.lblRelacijaProfesor.Size = new System.Drawing.Size(77, 20);
            this.lblRelacijaProfesor.TabIndex = 6;
            this.lblRelacijaProfesor.Text = "Profesor";
            // 
            // cmbRelacijaProfesor
            // 
            this.cmbRelacijaProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelacijaProfesor.FormattingEnabled = true;
            this.cmbRelacijaProfesor.Location = new System.Drawing.Point(132, 206);
            this.cmbRelacijaProfesor.Name = "cmbRelacijaProfesor";
            this.cmbRelacijaProfesor.Size = new System.Drawing.Size(374, 28);
            this.cmbRelacijaProfesor.TabIndex = 7;
            this.cmbRelacijaProfesor.SelectedIndexChanged += new System.EventHandler(this.cmbRelacijaProfesor_SelectedIndexChanged);
            // 
            // grpRelacijaSSPP
            // 
            this.grpRelacijaSSPP.Controls.Add(this.btnRelacijaBrisanje);
            this.grpRelacijaSSPP.Controls.Add(this.btnRelacijaIzmena);
            this.grpRelacijaSSPP.Controls.Add(this.btnRelacijaUnos);
            this.grpRelacijaSSPP.Controls.Add(this.lblRelacijaSmer);
            this.grpRelacijaSSPP.Controls.Add(this.cmbRelacijaSmer);
            this.grpRelacijaSSPP.Controls.Add(this.cmbRelacijaProfesor);
            this.grpRelacijaSSPP.Controls.Add(this.lblRelacijaSemestar);
            this.grpRelacijaSSPP.Controls.Add(this.lblRelacijaProfesor);
            this.grpRelacijaSSPP.Controls.Add(this.cmbRelacijaSemestar);
            this.grpRelacijaSSPP.Controls.Add(this.cmbRelacijaPredmet);
            this.grpRelacijaSSPP.Controls.Add(this.lblRelacijaPredmet);
            this.grpRelacijaSSPP.Location = new System.Drawing.Point(53, 32);
            this.grpRelacijaSSPP.Name = "grpRelacijaSSPP";
            this.grpRelacijaSSPP.Size = new System.Drawing.Size(512, 344);
            this.grpRelacijaSSPP.TabIndex = 8;
            this.grpRelacijaSSPP.TabStop = false;
            this.grpRelacijaSSPP.Text = "Relacija";
            // 
            // btnRelacijaBrisanje
            // 
            this.btnRelacijaBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacijaBrisanje.Location = new System.Drawing.Point(322, 280);
            this.btnRelacijaBrisanje.Name = "btnRelacijaBrisanje";
            this.btnRelacijaBrisanje.Size = new System.Drawing.Size(100, 35);
            this.btnRelacijaBrisanje.TabIndex = 10;
            this.btnRelacijaBrisanje.Text = "Brisanje";
            this.btnRelacijaBrisanje.UseVisualStyleBackColor = true;
            this.btnRelacijaBrisanje.Click += new System.EventHandler(this.btnRelacijaBrisanje_Click);
            // 
            // btnRelacijaIzmena
            // 
            this.btnRelacijaIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacijaIzmena.Location = new System.Drawing.Point(181, 280);
            this.btnRelacijaIzmena.Name = "btnRelacijaIzmena";
            this.btnRelacijaIzmena.Size = new System.Drawing.Size(100, 35);
            this.btnRelacijaIzmena.TabIndex = 9;
            this.btnRelacijaIzmena.Text = "Izmena";
            this.btnRelacijaIzmena.UseVisualStyleBackColor = true;
            this.btnRelacijaIzmena.Click += new System.EventHandler(this.btnRelacijaIzmena_Click);
            // 
            // btnRelacijaUnos
            // 
            this.btnRelacijaUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacijaUnos.Location = new System.Drawing.Point(42, 280);
            this.btnRelacijaUnos.Name = "btnRelacijaUnos";
            this.btnRelacijaUnos.Size = new System.Drawing.Size(100, 35);
            this.btnRelacijaUnos.TabIndex = 8;
            this.btnRelacijaUnos.Text = "Unos";
            this.btnRelacijaUnos.UseVisualStyleBackColor = true;
            this.btnRelacijaUnos.Click += new System.EventHandler(this.btnRelacijaUnos_Click);
            // 
            // dataGridViewRelacija
            // 
            this.dataGridViewRelacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelacija.Location = new System.Drawing.Point(582, 39);
            this.dataGridViewRelacija.Name = "dataGridViewRelacija";
            this.dataGridViewRelacija.Size = new System.Drawing.Size(475, 337);
            this.dataGridViewRelacija.TabIndex = 9;
            // 
            // lblRelacijaLogin
            // 
            this.lblRelacijaLogin.AutoSize = true;
            this.lblRelacijaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaLogin.Location = new System.Drawing.Point(707, 13);
            this.lblRelacijaLogin.Name = "lblRelacijaLogin";
            this.lblRelacijaLogin.Size = new System.Drawing.Size(53, 20);
            this.lblRelacijaLogin.TabIndex = 10;
            this.lblRelacijaLogin.Text = "Login";
            // 
            // lblRelacijaLoginPrikaz
            // 
            this.lblRelacijaLoginPrikaz.AutoSize = true;
            this.lblRelacijaLoginPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaLoginPrikaz.Location = new System.Drawing.Point(775, 14);
            this.lblRelacijaLoginPrikaz.Name = "lblRelacijaLoginPrikaz";
            this.lblRelacijaLoginPrikaz.Size = new System.Drawing.Size(57, 20);
            this.lblRelacijaLoginPrikaz.TabIndex = 11;
            this.lblRelacijaLoginPrikaz.Text = "label1";
            // 
            // lblRelacijaLogout
            // 
            this.lblRelacijaLogout.AutoSize = true;
            this.lblRelacijaLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacijaLogout.Location = new System.Drawing.Point(912, 14);
            this.lblRelacijaLogout.Name = "lblRelacijaLogout";
            this.lblRelacijaLogout.Size = new System.Drawing.Size(49, 20);
            this.lblRelacijaLogout.TabIndex = 12;
            this.lblRelacijaLogout.TabStop = true;
            this.lblRelacijaLogout.Text = "Back";
            this.lblRelacijaLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRelacijaLogout_LinkClicked);
            // 
            // frmSmerSemestarPredmetProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 416);
            this.Controls.Add(this.lblRelacijaLogout);
            this.Controls.Add(this.lblRelacijaLoginPrikaz);
            this.Controls.Add(this.lblRelacijaLogin);
            this.Controls.Add(this.dataGridViewRelacija);
            this.Controls.Add(this.grpRelacijaSSPP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSmerSemestarPredmetProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMER SEMESTAR PREDMET PROFESOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpRelacijaSSPP.ResumeLayout(false);
            this.grpRelacijaSSPP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRelacijaSmer;
        private System.Windows.Forms.Label lblRelacijaSmer;
        private System.Windows.Forms.Label lblRelacijaSemestar;
        private System.Windows.Forms.ComboBox cmbRelacijaSemestar;
        private System.Windows.Forms.Label lblRelacijaPredmet;
        private System.Windows.Forms.ComboBox cmbRelacijaPredmet;
        private System.Windows.Forms.Label lblRelacijaProfesor;
        private System.Windows.Forms.ComboBox cmbRelacijaProfesor;
        private System.Windows.Forms.GroupBox grpRelacijaSSPP;
        private System.Windows.Forms.DataGridView dataGridViewRelacija;
        private System.Windows.Forms.Button btnRelacijaBrisanje;
        private System.Windows.Forms.Button btnRelacijaIzmena;
        private System.Windows.Forms.Button btnRelacijaUnos;
        private System.Windows.Forms.Label lblRelacijaLogin;
        private System.Windows.Forms.Label lblRelacijaLoginPrikaz;
        private System.Windows.Forms.LinkLabel lblRelacijaLogout;
    }
}