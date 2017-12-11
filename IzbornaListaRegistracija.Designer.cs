namespace StudentskaSluzba
{
    partial class frmIzbornaListaRegistracija
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
            this.lblIzbornaListaRegistracijaUsername = new System.Windows.Forms.Label();
            this.lblRegistracijaPassword = new System.Windows.Forms.Label();
            this.txtRegistracijaUsername = new System.Windows.Forms.TextBox();
            this.txtRegistracijaPassword = new System.Windows.Forms.TextBox();
            this.btnRegistracijaRegistracija = new System.Windows.Forms.Button();
            this.btnRegistracijaCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzbornaListaRegistracijaUsername
            // 
            this.lblIzbornaListaRegistracijaUsername.AutoSize = true;
            this.lblIzbornaListaRegistracijaUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzbornaListaRegistracijaUsername.Location = new System.Drawing.Point(36, 60);
            this.lblIzbornaListaRegistracijaUsername.Name = "lblIzbornaListaRegistracijaUsername";
            this.lblIzbornaListaRegistracijaUsername.Size = new System.Drawing.Size(100, 22);
            this.lblIzbornaListaRegistracijaUsername.TabIndex = 0;
            this.lblIzbornaListaRegistracijaUsername.Text = "Username";
            // 
            // lblRegistracijaPassword
            // 
            this.lblRegistracijaPassword.AutoSize = true;
            this.lblRegistracijaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracijaPassword.Location = new System.Drawing.Point(39, 104);
            this.lblRegistracijaPassword.Name = "lblRegistracijaPassword";
            this.lblRegistracijaPassword.Size = new System.Drawing.Size(97, 22);
            this.lblRegistracijaPassword.TabIndex = 1;
            this.lblRegistracijaPassword.Text = "Password";
            // 
            // txtRegistracijaUsername
            // 
            this.txtRegistracijaUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracijaUsername.Location = new System.Drawing.Point(156, 57);
            this.txtRegistracijaUsername.Name = "txtRegistracijaUsername";
            this.txtRegistracijaUsername.Size = new System.Drawing.Size(250, 27);
            this.txtRegistracijaUsername.TabIndex = 2;
            // 
            // txtRegistracijaPassword
            // 
            this.txtRegistracijaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracijaPassword.Location = new System.Drawing.Point(155, 106);
            this.txtRegistracijaPassword.Name = "txtRegistracijaPassword";
            this.txtRegistracijaPassword.PasswordChar = '*';
            this.txtRegistracijaPassword.Size = new System.Drawing.Size(251, 27);
            this.txtRegistracijaPassword.TabIndex = 3;
            // 
            // btnRegistracijaRegistracija
            // 
            this.btnRegistracijaRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracijaRegistracija.Location = new System.Drawing.Point(74, 237);
            this.btnRegistracijaRegistracija.Name = "btnRegistracijaRegistracija";
            this.btnRegistracijaRegistracija.Size = new System.Drawing.Size(163, 35);
            this.btnRegistracijaRegistracija.TabIndex = 4;
            this.btnRegistracijaRegistracija.Text = "INSERT";
            this.btnRegistracijaRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracijaRegistracija.Click += new System.EventHandler(this.btnRegistracijaRegistracija_Click);
            // 
            // btnRegistracijaCancel
            // 
            this.btnRegistracijaCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracijaCancel.Location = new System.Drawing.Point(243, 237);
            this.btnRegistracijaCancel.Name = "btnRegistracijaCancel";
            this.btnRegistracijaCancel.Size = new System.Drawing.Size(163, 35);
            this.btnRegistracijaCancel.TabIndex = 5;
            this.btnRegistracijaCancel.Text = "Cancel";
            this.btnRegistracijaCancel.UseVisualStyleBackColor = true;
            this.btnRegistracijaCancel.Click += new System.EventHandler(this.btnRegistracijaCancel_Click);
            // 
            // frmIzbornaListaRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnRegistracijaCancel);
            this.Controls.Add(this.btnRegistracijaRegistracija);
            this.Controls.Add(this.txtRegistracijaPassword);
            this.Controls.Add(this.txtRegistracijaUsername);
            this.Controls.Add(this.lblRegistracijaPassword);
            this.Controls.Add(this.lblIzbornaListaRegistracijaUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIzbornaListaRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRACIJA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzbornaListaRegistracijaUsername;
        private System.Windows.Forms.Label lblRegistracijaPassword;
        private System.Windows.Forms.TextBox txtRegistracijaUsername;
        private System.Windows.Forms.TextBox txtRegistracijaPassword;
        private System.Windows.Forms.Button btnRegistracijaRegistracija;
        private System.Windows.Forms.Button btnRegistracijaCancel;
    }
}