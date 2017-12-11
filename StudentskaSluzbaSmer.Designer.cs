namespace StudentskaSluzba
{
    partial class frmStudentskaSluzbaSmer
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
            this.lblSmerNaziv = new System.Windows.Forms.Label();
            this.lblSmerMnemo = new System.Windows.Forms.Label();
            this.txtSmerNaziv = new System.Windows.Forms.TextBox();
            this.txtSmerMnemo = new System.Windows.Forms.TextBox();
            this.cmbSmer = new System.Windows.Forms.ComboBox();
            this.btnSmerUnos = new System.Windows.Forms.Button();
            this.btnSmerIzmena = new System.Windows.Forms.Button();
            this.btnSmerBrisanje = new System.Windows.Forms.Button();
            this.dataGridViewSmer = new System.Windows.Forms.DataGridView();
            this.grpSmerovi = new System.Windows.Forms.GroupBox();
            this.lblSmerLogOut = new System.Windows.Forms.LinkLabel();
            this.lblSmerLogin = new System.Windows.Forms.Label();
            this.lblSmerLoginPrikaz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmer)).BeginInit();
            this.grpSmerovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSmerNaziv
            // 
            this.lblSmerNaziv.AutoSize = true;
            this.lblSmerNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmerNaziv.Location = new System.Drawing.Point(33, 16);
            this.lblSmerNaziv.Name = "lblSmerNaziv";
            this.lblSmerNaziv.Size = new System.Drawing.Size(52, 20);
            this.lblSmerNaziv.TabIndex = 0;
            this.lblSmerNaziv.Text = "Naziv";
            // 
            // lblSmerMnemo
            // 
            this.lblSmerMnemo.AutoSize = true;
            this.lblSmerMnemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmerMnemo.Location = new System.Drawing.Point(36, 73);
            this.lblSmerMnemo.Name = "lblSmerMnemo";
            this.lblSmerMnemo.Size = new System.Drawing.Size(67, 20);
            this.lblSmerMnemo.TabIndex = 1;
            this.lblSmerMnemo.Text = "Mnemo";
            // 
            // txtSmerNaziv
            // 
            this.txtSmerNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmerNaziv.Location = new System.Drawing.Point(121, 15);
            this.txtSmerNaziv.Name = "txtSmerNaziv";
            this.txtSmerNaziv.Size = new System.Drawing.Size(289, 26);
            this.txtSmerNaziv.TabIndex = 2;
            // 
            // txtSmerMnemo
            // 
            this.txtSmerMnemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmerMnemo.Location = new System.Drawing.Point(121, 65);
            this.txtSmerMnemo.Name = "txtSmerMnemo";
            this.txtSmerMnemo.Size = new System.Drawing.Size(289, 26);
            this.txtSmerMnemo.TabIndex = 3;
            // 
            // cmbSmer
            // 
            this.cmbSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmer.FormattingEnabled = true;
            this.cmbSmer.Location = new System.Drawing.Point(426, 15);
            this.cmbSmer.Name = "cmbSmer";
            this.cmbSmer.Size = new System.Drawing.Size(201, 28);
            this.cmbSmer.TabIndex = 4;
            this.cmbSmer.SelectedIndexChanged += new System.EventHandler(this.cmbSmer_SelectedIndexChanged);
            // 
            // btnSmerUnos
            // 
            this.btnSmerUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmerUnos.Location = new System.Drawing.Point(39, 145);
            this.btnSmerUnos.Name = "btnSmerUnos";
            this.btnSmerUnos.Size = new System.Drawing.Size(100, 35);
            this.btnSmerUnos.TabIndex = 5;
            this.btnSmerUnos.Text = "Unos";
            this.btnSmerUnos.UseVisualStyleBackColor = true;
            this.btnSmerUnos.Click += new System.EventHandler(this.btnSmerUnos_Click);
            // 
            // btnSmerIzmena
            // 
            this.btnSmerIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmerIzmena.Location = new System.Drawing.Point(187, 145);
            this.btnSmerIzmena.Name = "btnSmerIzmena";
            this.btnSmerIzmena.Size = new System.Drawing.Size(100, 35);
            this.btnSmerIzmena.TabIndex = 6;
            this.btnSmerIzmena.Text = "Izmena";
            this.btnSmerIzmena.UseVisualStyleBackColor = true;
            this.btnSmerIzmena.Click += new System.EventHandler(this.btnSmerIzmena_Click);
            // 
            // btnSmerBrisanje
            // 
            this.btnSmerBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmerBrisanje.Location = new System.Drawing.Point(335, 145);
            this.btnSmerBrisanje.Name = "btnSmerBrisanje";
            this.btnSmerBrisanje.Size = new System.Drawing.Size(100, 35);
            this.btnSmerBrisanje.TabIndex = 7;
            this.btnSmerBrisanje.Text = "Brisanje";
            this.btnSmerBrisanje.UseVisualStyleBackColor = true;
            this.btnSmerBrisanje.Click += new System.EventHandler(this.btnSmerBrisanje_Click);
            // 
            // dataGridViewSmer
            // 
            this.dataGridViewSmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmer.Location = new System.Drawing.Point(717, 57);
            this.dataGridViewSmer.Name = "dataGridViewSmer";
            this.dataGridViewSmer.Size = new System.Drawing.Size(455, 208);
            this.dataGridViewSmer.TabIndex = 9;
            // 
            // grpSmerovi
            // 
            this.grpSmerovi.Controls.Add(this.lblSmerNaziv);
            this.grpSmerovi.Controls.Add(this.lblSmerMnemo);
            this.grpSmerovi.Controls.Add(this.txtSmerNaziv);
            this.grpSmerovi.Controls.Add(this.btnSmerBrisanje);
            this.grpSmerovi.Controls.Add(this.txtSmerMnemo);
            this.grpSmerovi.Controls.Add(this.btnSmerIzmena);
            this.grpSmerovi.Controls.Add(this.cmbSmer);
            this.grpSmerovi.Controls.Add(this.btnSmerUnos);
            this.grpSmerovi.Location = new System.Drawing.Point(68, 57);
            this.grpSmerovi.Name = "grpSmerovi";
            this.grpSmerovi.Size = new System.Drawing.Size(643, 208);
            this.grpSmerovi.TabIndex = 10;
            this.grpSmerovi.TabStop = false;
            this.grpSmerovi.Text = "Smerovi";
            // 
            // lblSmerLogOut
            // 
            this.lblSmerLogOut.AutoSize = true;
            this.lblSmerLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmerLogOut.Location = new System.Drawing.Point(1100, 25);
            this.lblSmerLogOut.Name = "lblSmerLogOut";
            this.lblSmerLogOut.Size = new System.Drawing.Size(49, 20);
            this.lblSmerLogOut.TabIndex = 11;
            this.lblSmerLogOut.TabStop = true;
            this.lblSmerLogOut.Text = "Back";
            this.lblSmerLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSmerLogOut_LinkClicked);
            // 
            // lblSmerLogin
            // 
            this.lblSmerLogin.AutoSize = true;
            this.lblSmerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmerLogin.Location = new System.Drawing.Point(994, 25);
            this.lblSmerLogin.Name = "lblSmerLogin";
            this.lblSmerLogin.Size = new System.Drawing.Size(53, 20);
            this.lblSmerLogin.TabIndex = 12;
            this.lblSmerLogin.Text = "Login";
            // 
            // lblSmerLoginPrikaz
            // 
            this.lblSmerLoginPrikaz.AutoSize = true;
            this.lblSmerLoginPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmerLoginPrikaz.Location = new System.Drawing.Point(1051, 27);
            this.lblSmerLoginPrikaz.Name = "lblSmerLoginPrikaz";
            this.lblSmerLoginPrikaz.Size = new System.Drawing.Size(46, 17);
            this.lblSmerLoginPrikaz.TabIndex = 13;
            this.lblSmerLoginPrikaz.Text = "label1";
            // 
            // frmStudentskaSluzbaSmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 416);
            this.Controls.Add(this.lblSmerLoginPrikaz);
            this.Controls.Add(this.lblSmerLogin);
            this.Controls.Add(this.lblSmerLogOut);
            this.Controls.Add(this.grpSmerovi);
            this.Controls.Add(this.dataGridViewSmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentskaSluzbaSmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENTSKA SLUŽBA - SMER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmer)).EndInit();
            this.grpSmerovi.ResumeLayout(false);
            this.grpSmerovi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSmerNaziv;
        private System.Windows.Forms.Label lblSmerMnemo;
        private System.Windows.Forms.TextBox txtSmerNaziv;
        private System.Windows.Forms.TextBox txtSmerMnemo;
        private System.Windows.Forms.ComboBox cmbSmer;
        private System.Windows.Forms.Button btnSmerUnos;
        private System.Windows.Forms.Button btnSmerIzmena;
        private System.Windows.Forms.Button btnSmerBrisanje;
        private System.Windows.Forms.DataGridView dataGridViewSmer;
        private System.Windows.Forms.GroupBox grpSmerovi;
        private System.Windows.Forms.LinkLabel lblSmerLogOut;
        private System.Windows.Forms.Label lblSmerLogin;
        private System.Windows.Forms.Label lblSmerLoginPrikaz;
    }
}