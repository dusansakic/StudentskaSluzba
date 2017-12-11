namespace StudentskaSluzba
{
    partial class frmStudentskaSluzbaVrstaKorisnika
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
            this.lblVrstaKorisnika = new System.Windows.Forms.Label();
            this.txtMnemo = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.cmbVrstaKorisnika = new System.Windows.Forms.ComboBox();
            this.grpVrstaKorisnika = new System.Windows.Forms.GroupBox();
            this.lblMnemo = new System.Windows.Forms.Label();
            this.txtVrstaKorisnika = new System.Windows.Forms.TextBox();
            this.dataGridViewVrstaKorisnika = new System.Windows.Forms.DataGridView();
            this.lnkVrsteKorisnikaLogout = new System.Windows.Forms.LinkLabel();
            this.lblVrsteKorisnikaLoginNaslov = new System.Windows.Forms.Label();
            this.lblVrsteKorisnikaLoginPrikaz = new System.Windows.Forms.Label();
            this.grpVrstaKorisnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVrstaKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVrstaKorisnika
            // 
            this.lblVrstaKorisnika.AutoSize = true;
            this.lblVrstaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrstaKorisnika.Location = new System.Drawing.Point(16, 52);
            this.lblVrstaKorisnika.Name = "lblVrstaKorisnika";
            this.lblVrstaKorisnika.Size = new System.Drawing.Size(128, 20);
            this.lblVrstaKorisnika.TabIndex = 0;
            this.lblVrstaKorisnika.Text = "Vrsta korisnika";
            // 
            // txtMnemo
            // 
            this.txtMnemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnemo.Location = new System.Drawing.Point(150, 115);
            this.txtMnemo.Name = "txtMnemo";
            this.txtMnemo.Size = new System.Drawing.Size(221, 26);
            this.txtMnemo.TabIndex = 1;
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnos.Location = new System.Drawing.Point(20, 195);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(100, 35);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIzmena
            // 
            this.btnIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmena.Location = new System.Drawing.Point(150, 195);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(100, 35);
            this.btnIzmena.TabIndex = 5;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.Location = new System.Drawing.Point(271, 195);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(100, 35);
            this.btnBrisanje.TabIndex = 6;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // cmbVrstaKorisnika
            // 
            this.cmbVrstaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVrstaKorisnika.FormattingEnabled = true;
            this.cmbVrstaKorisnika.Location = new System.Drawing.Point(377, 51);
            this.cmbVrstaKorisnika.Name = "cmbVrstaKorisnika";
            this.cmbVrstaKorisnika.Size = new System.Drawing.Size(173, 28);
            this.cmbVrstaKorisnika.TabIndex = 2;
            this.cmbVrstaKorisnika.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpVrstaKorisnika
            // 
            this.grpVrstaKorisnika.Controls.Add(this.lblMnemo);
            this.grpVrstaKorisnika.Controls.Add(this.txtVrstaKorisnika);
            this.grpVrstaKorisnika.Controls.Add(this.lblVrstaKorisnika);
            this.grpVrstaKorisnika.Controls.Add(this.cmbVrstaKorisnika);
            this.grpVrstaKorisnika.Controls.Add(this.btnBrisanje);
            this.grpVrstaKorisnika.Controls.Add(this.txtMnemo);
            this.grpVrstaKorisnika.Controls.Add(this.btnIzmena);
            this.grpVrstaKorisnika.Controls.Add(this.btnUnos);
            this.grpVrstaKorisnika.Location = new System.Drawing.Point(32, 62);
            this.grpVrstaKorisnika.Name = "grpVrstaKorisnika";
            this.grpVrstaKorisnika.Size = new System.Drawing.Size(572, 245);
            this.grpVrstaKorisnika.TabIndex = 9;
            this.grpVrstaKorisnika.TabStop = false;
            this.grpVrstaKorisnika.Text = "Vrste korisnika";
            // 
            // lblMnemo
            // 
            this.lblMnemo.AutoSize = true;
            this.lblMnemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnemo.Location = new System.Drawing.Point(16, 115);
            this.lblMnemo.Name = "lblMnemo";
            this.lblMnemo.Size = new System.Drawing.Size(67, 20);
            this.lblMnemo.TabIndex = 9;
            this.lblMnemo.Text = "Mnemo";
            this.lblMnemo.Click += new System.EventHandler(this.lblMnemo_Click);
            // 
            // txtVrstaKorisnika
            // 
            this.txtVrstaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrstaKorisnika.Location = new System.Drawing.Point(150, 51);
            this.txtVrstaKorisnika.Name = "txtVrstaKorisnika";
            this.txtVrstaKorisnika.Size = new System.Drawing.Size(221, 26);
            this.txtVrstaKorisnika.TabIndex = 0;
            // 
            // dataGridViewVrstaKorisnika
            // 
            this.dataGridViewVrstaKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVrstaKorisnika.Location = new System.Drawing.Point(628, 71);
            this.dataGridViewVrstaKorisnika.Name = "dataGridViewVrstaKorisnika";
            this.dataGridViewVrstaKorisnika.Size = new System.Drawing.Size(419, 236);
            this.dataGridViewVrstaKorisnika.TabIndex = 10;
            // 
            // lnkVrsteKorisnikaLogout
            // 
            this.lnkVrsteKorisnikaLogout.AutoSize = true;
            this.lnkVrsteKorisnikaLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVrsteKorisnikaLogout.Location = new System.Drawing.Point(980, 33);
            this.lnkVrsteKorisnikaLogout.Name = "lnkVrsteKorisnikaLogout";
            this.lnkVrsteKorisnikaLogout.Size = new System.Drawing.Size(45, 20);
            this.lnkVrsteKorisnikaLogout.TabIndex = 11;
            this.lnkVrsteKorisnikaLogout.TabStop = true;
            this.lnkVrsteKorisnikaLogout.Text = "Back";
            this.lnkVrsteKorisnikaLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVrsteKorisnikaLogout_LinkClicked);
            // 
            // lblVrsteKorisnikaLoginNaslov
            // 
            this.lblVrsteKorisnikaLoginNaslov.AutoSize = true;
            this.lblVrsteKorisnikaLoginNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrsteKorisnikaLoginNaslov.Location = new System.Drawing.Point(869, 32);
            this.lblVrsteKorisnikaLoginNaslov.Name = "lblVrsteKorisnikaLoginNaslov";
            this.lblVrsteKorisnikaLoginNaslov.Size = new System.Drawing.Size(53, 20);
            this.lblVrsteKorisnikaLoginNaslov.TabIndex = 12;
            this.lblVrsteKorisnikaLoginNaslov.Text = "Login";
            // 
            // lblVrsteKorisnikaLoginPrikaz
            // 
            this.lblVrsteKorisnikaLoginPrikaz.AutoSize = true;
            this.lblVrsteKorisnikaLoginPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrsteKorisnikaLoginPrikaz.Location = new System.Drawing.Point(925, 35);
            this.lblVrsteKorisnikaLoginPrikaz.Name = "lblVrsteKorisnikaLoginPrikaz";
            this.lblVrsteKorisnikaLoginPrikaz.Size = new System.Drawing.Size(52, 17);
            this.lblVrsteKorisnikaLoginPrikaz.TabIndex = 13;
            this.lblVrsteKorisnikaLoginPrikaz.Text = "label2";
            // 
            // frmStudentskaSluzbaVrstaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 416);
            this.Controls.Add(this.lblVrsteKorisnikaLoginPrikaz);
            this.Controls.Add(this.lblVrsteKorisnikaLoginNaslov);
            this.Controls.Add(this.lnkVrsteKorisnikaLogout);
            this.Controls.Add(this.dataGridViewVrstaKorisnika);
            this.Controls.Add(this.grpVrstaKorisnika);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentskaSluzbaVrstaKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRSTE KORISNIKA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpVrstaKorisnika.ResumeLayout(false);
            this.grpVrstaKorisnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVrstaKorisnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVrstaKorisnika;
        private System.Windows.Forms.TextBox txtMnemo;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.ComboBox cmbVrstaKorisnika;
        private System.Windows.Forms.GroupBox grpVrstaKorisnika;
        private System.Windows.Forms.TextBox txtVrstaKorisnika;
        private System.Windows.Forms.Label lblMnemo;
        private System.Windows.Forms.DataGridView dataGridViewVrstaKorisnika;
        private System.Windows.Forms.LinkLabel lnkVrsteKorisnikaLogout;
        private System.Windows.Forms.Label lblVrsteKorisnikaLoginNaslov;
        private System.Windows.Forms.Label lblVrsteKorisnikaLoginPrikaz;
    }
}