namespace StudentskaSluzba
{
    partial class frmStudentskaSluzbaMainMenuAdmin
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnProfesori = new System.Windows.Forms.Button();
            this.btnSmerovi = new System.Windows.Forms.Button();
            this.btnPredmeti = new System.Windows.Forms.Button();
            this.btnGrupe = new System.Windows.Forms.Button();
            this.btnIzborneListe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMainLogin = new System.Windows.Forms.Label();
            this.lblMainUser = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRelacija = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(515, 83);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(230, 24);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "STUDENTSKA SLUŽBA";
            // 
            // btnStudenti
            // 
            this.btnStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudenti.Location = new System.Drawing.Point(288, 139);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(150, 50);
            this.btnStudenti.TabIndex = 1;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.UseVisualStyleBackColor = true;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // btnProfesori
            // 
            this.btnProfesori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesori.Location = new System.Drawing.Point(288, 208);
            this.btnProfesori.Name = "btnProfesori";
            this.btnProfesori.Size = new System.Drawing.Size(150, 50);
            this.btnProfesori.TabIndex = 2;
            this.btnProfesori.Text = "Profesori";
            this.btnProfesori.UseVisualStyleBackColor = true;
            this.btnProfesori.Click += new System.EventHandler(this.btnProfesori_Click);
            // 
            // btnSmerovi
            // 
            this.btnSmerovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmerovi.Location = new System.Drawing.Point(288, 278);
            this.btnSmerovi.Name = "btnSmerovi";
            this.btnSmerovi.Size = new System.Drawing.Size(150, 50);
            this.btnSmerovi.TabIndex = 3;
            this.btnSmerovi.Text = "Smerovi";
            this.btnSmerovi.UseVisualStyleBackColor = true;
            this.btnSmerovi.Click += new System.EventHandler(this.btnSmerovi_Click);
            // 
            // btnPredmeti
            // 
            this.btnPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredmeti.Location = new System.Drawing.Point(808, 139);
            this.btnPredmeti.Name = "btnPredmeti";
            this.btnPredmeti.Size = new System.Drawing.Size(150, 50);
            this.btnPredmeti.TabIndex = 4;
            this.btnPredmeti.Text = "Predmeti";
            this.btnPredmeti.UseVisualStyleBackColor = true;
            this.btnPredmeti.Click += new System.EventHandler(this.btnPredmeti_Click);
            // 
            // btnGrupe
            // 
            this.btnGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupe.Location = new System.Drawing.Point(808, 208);
            this.btnGrupe.Name = "btnGrupe";
            this.btnGrupe.Size = new System.Drawing.Size(150, 50);
            this.btnGrupe.TabIndex = 5;
            this.btnGrupe.Text = "Vrste korisnika";
            this.btnGrupe.UseVisualStyleBackColor = true;
            this.btnGrupe.Click += new System.EventHandler(this.btnGrupe_Click);
            // 
            // btnIzborneListe
            // 
            this.btnIzborneListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzborneListe.Location = new System.Drawing.Point(808, 278);
            this.btnIzborneListe.Name = "btnIzborneListe";
            this.btnIzborneListe.Size = new System.Drawing.Size(150, 50);
            this.btnIzborneListe.TabIndex = 6;
            this.btnIzborneListe.Text = "Izborne liste";
            this.btnIzborneListe.UseVisualStyleBackColor = true;
            this.btnIzborneListe.Click += new System.EventHandler(this.btnIzborneListe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentskaSluzba.Properties.Resources.Student_Services;
            this.pictureBox1.Location = new System.Drawing.Point(477, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblMainLogin
            // 
            this.lblMainLogin.AutoSize = true;
            this.lblMainLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLogin.Location = new System.Drawing.Point(826, 423);
            this.lblMainLogin.Name = "lblMainLogin";
            this.lblMainLogin.Size = new System.Drawing.Size(125, 17);
            this.lblMainLogin.TabIndex = 8;
            this.lblMainLogin.Text = "Ulogovani ste kao:";
            // 
            // lblMainUser
            // 
            this.lblMainUser.AutoSize = true;
            this.lblMainUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainUser.Location = new System.Drawing.Point(969, 420);
            this.lblMainUser.Name = "lblMainUser";
            this.lblMainUser.Size = new System.Drawing.Size(57, 20);
            this.lblMainUser.TabIndex = 9;
            this.lblMainUser.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(966, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRelacija
            // 
            this.btnRelacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacija.Location = new System.Drawing.Point(477, 355);
            this.btnRelacija.Name = "btnRelacija";
            this.btnRelacija.Size = new System.Drawing.Size(307, 50);
            this.btnRelacija.TabIndex = 11;
            this.btnRelacija.Text = "Smer Semestar Predmet Profesor";
            this.btnRelacija.UseVisualStyleBackColor = true;
            this.btnRelacija.Click += new System.EventHandler(this.btnRelacija_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(808, 355);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(150, 50);
            this.btnStatistika.TabIndex = 12;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // frmStudentskaSluzbaMainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnRelacija);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMainUser);
            this.Controls.Add(this.lblMainLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzborneListe);
            this.Controls.Add(this.btnGrupe);
            this.Controls.Add(this.btnPredmeti);
            this.Controls.Add(this.btnSmerovi);
            this.Controls.Add(this.btnProfesori);
            this.Controls.Add(this.btnStudenti);
            this.Controls.Add(this.lblMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentskaSluzbaMainMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLAVNI MENI - ADMINISTRACIJA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnProfesori;
        private System.Windows.Forms.Button btnSmerovi;
        private System.Windows.Forms.Button btnPredmeti;
        private System.Windows.Forms.Button btnGrupe;
        private System.Windows.Forms.Button btnIzborneListe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMainLogin;
        private System.Windows.Forms.Label lblMainUser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnRelacija;
        private System.Windows.Forms.Button btnStatistika;
    }
}