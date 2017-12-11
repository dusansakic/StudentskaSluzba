namespace StudentskaSluzba
{
    partial class frmAdminKorisnika
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblVrstaKorisnika = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbVrstaKorisnika = new System.Windows.Forms.ComboBox();
            this.grpAdministracijaKorisnika = new System.Windows.Forms.GroupBox();
            this.cmbAdminKorisnika = new System.Windows.Forms.ComboBox();
            this.btnUnosKorisnika = new System.Windows.Forms.Button();
            this.btnIzmenaKorisnika = new System.Windows.Forms.Button();
            this.btnBrisanjeKorisnika = new System.Windows.Forms.Button();
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.grpAdministracijaKorisnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(15, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblVrstaKorisnika
            // 
            this.lblVrstaKorisnika.AutoSize = true;
            this.lblVrstaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrstaKorisnika.Location = new System.Drawing.Point(15, 126);
            this.lblVrstaKorisnika.Name = "lblVrstaKorisnika";
            this.lblVrstaKorisnika.Size = new System.Drawing.Size(128, 20);
            this.lblVrstaKorisnika.TabIndex = 2;
            this.lblVrstaKorisnika.Text = "Vrsta korisnika";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(261, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(149, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // cmbVrstaKorisnika
            // 
            this.cmbVrstaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVrstaKorisnika.FormattingEnabled = true;
            this.cmbVrstaKorisnika.Location = new System.Drawing.Point(149, 118);
            this.cmbVrstaKorisnika.Name = "cmbVrstaKorisnika";
            this.cmbVrstaKorisnika.Size = new System.Drawing.Size(261, 28);
            this.cmbVrstaKorisnika.TabIndex = 2;
            this.cmbVrstaKorisnika.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaKorisnika_SelectedIndexChanged);
            // 
            // grpAdministracijaKorisnika
            // 
            this.grpAdministracijaKorisnika.Controls.Add(this.cmbAdminKorisnika);
            this.grpAdministracijaKorisnika.Controls.Add(this.lblUserName);
            this.grpAdministracijaKorisnika.Controls.Add(this.cmbVrstaKorisnika);
            this.grpAdministracijaKorisnika.Controls.Add(this.btnUnosKorisnika);
            this.grpAdministracijaKorisnika.Controls.Add(this.lblPassword);
            this.grpAdministracijaKorisnika.Controls.Add(this.txtUserName);
            this.grpAdministracijaKorisnika.Controls.Add(this.lblVrstaKorisnika);
            this.grpAdministracijaKorisnika.Controls.Add(this.txtPassword);
            this.grpAdministracijaKorisnika.Location = new System.Drawing.Point(34, 51);
            this.grpAdministracijaKorisnika.Name = "grpAdministracijaKorisnika";
            this.grpAdministracijaKorisnika.Size = new System.Drawing.Size(678, 263);
            this.grpAdministracijaKorisnika.TabIndex = 6;
            this.grpAdministracijaKorisnika.TabStop = false;
            this.grpAdministracijaKorisnika.Text = "Administracija korisnika";
            // 
            // cmbAdminKorisnika
            // 
            this.cmbAdminKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdminKorisnika.FormattingEnabled = true;
            this.cmbAdminKorisnika.Location = new System.Drawing.Point(416, 39);
            this.cmbAdminKorisnika.Name = "cmbAdminKorisnika";
            this.cmbAdminKorisnika.Size = new System.Drawing.Size(256, 28);
            this.cmbAdminKorisnika.TabIndex = 3;
            this.cmbAdminKorisnika.SelectedIndexChanged += new System.EventHandler(this.cmbAdminKorisnika_SelectedIndexChanged);
            // 
            // btnUnosKorisnika
            // 
            this.btnUnosKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosKorisnika.Location = new System.Drawing.Point(19, 196);
            this.btnUnosKorisnika.Name = "btnUnosKorisnika";
            this.btnUnosKorisnika.Size = new System.Drawing.Size(100, 35);
            this.btnUnosKorisnika.TabIndex = 7;
            this.btnUnosKorisnika.Text = "Unos";
            this.btnUnosKorisnika.UseVisualStyleBackColor = true;
            this.btnUnosKorisnika.Click += new System.EventHandler(this.btnUnosKorisnika_Click);
            // 
            // btnIzmenaKorisnika
            // 
            this.btnIzmenaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmenaKorisnika.Location = new System.Drawing.Point(203, 247);
            this.btnIzmenaKorisnika.Name = "btnIzmenaKorisnika";
            this.btnIzmenaKorisnika.Size = new System.Drawing.Size(100, 35);
            this.btnIzmenaKorisnika.TabIndex = 8;
            this.btnIzmenaKorisnika.Text = "Izmena";
            this.btnIzmenaKorisnika.UseVisualStyleBackColor = true;
            this.btnIzmenaKorisnika.Click += new System.EventHandler(this.btnIzmenaKorisnika_Click);
            // 
            // btnBrisanjeKorisnika
            // 
            this.btnBrisanjeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanjeKorisnika.Location = new System.Drawing.Point(364, 247);
            this.btnBrisanjeKorisnika.Name = "btnBrisanjeKorisnika";
            this.btnBrisanjeKorisnika.Size = new System.Drawing.Size(100, 35);
            this.btnBrisanjeKorisnika.TabIndex = 9;
            this.btnBrisanjeKorisnika.Text = "Brisanje";
            this.btnBrisanjeKorisnika.UseVisualStyleBackColor = true;
            this.btnBrisanjeKorisnika.Click += new System.EventHandler(this.btnBrisanjeKorisnika_Click);
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(718, 51);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(337, 353);
            this.dataGridViewKorisnici.TabIndex = 10;
            // 
            // frmAdminKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 416);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Controls.Add(this.btnBrisanjeKorisnika);
            this.Controls.Add(this.btnIzmenaKorisnika);
            this.Controls.Add(this.grpAdministracijaKorisnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACIJA KORISNIKA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminKorisnika_FormClosing);
            this.grpAdministracijaKorisnika.ResumeLayout(false);
            this.grpAdministracijaKorisnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblVrstaKorisnika;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbVrstaKorisnika;
        private System.Windows.Forms.GroupBox grpAdministracijaKorisnika;
        private System.Windows.Forms.Button btnUnosKorisnika;
        private System.Windows.Forms.Button btnIzmenaKorisnika;
        private System.Windows.Forms.Button btnBrisanjeKorisnika;
        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
        private System.Windows.Forms.ComboBox cmbAdminKorisnika;
    }
}

