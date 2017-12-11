using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class frmStudentskaSluzbaMainMenuAdmin : Form
    {

        public frmStudentskaSluzbaMainMenuAdmin(string user)
        {
            InitializeComponent();
            lblMainUser.Text = user;
            
        }
        private void btnStudenti_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaProfesor adminProfesoriStudenti = new StudentskaSluzba.frmStudentskaSluzbaProfesor(lblMainUser.Text, "STUDENT");

            adminProfesoriStudenti.ShowDialog();
        }

        private void btnProfesori_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaProfesor adminProfesoriStudenti = new StudentskaSluzba.frmStudentskaSluzbaProfesor(lblMainUser.Text,"PROFESOR");
            
            adminProfesoriStudenti.ShowDialog();
            
        }

        private void btnSmerovi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaSmer adminSmerova = new StudentskaSluzba.frmStudentskaSluzbaSmer(lblMainUser.Text);
            
            adminSmerova.ShowDialog();
            
        }

        private void btnPredmeti_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaPredmeti adminPredmeti = new StudentskaSluzba.frmStudentskaSluzbaPredmeti(lblMainUser.Text);

            

            adminPredmeti.ShowDialog();
        }

        private void btnGrupe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaVrstaKorisnika vrsteKorisnika = new StudentskaSluzba.frmStudentskaSluzbaVrstaKorisnika(lblMainUser.Text);
            
            vrsteKorisnika.ShowDialog();
            
        }

        private void btnIzborneListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaIzborneListeStudenata izborneListeStudenata = new StudentskaSluzba.frmStudentskaSluzbaIzborneListeStudenata(lblMainUser.Text);

            izborneListeStudenata.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaLogin mainForm = new frmStudentskaSluzbaLogin();
            mainForm.Show();
            //LOGIN_FORM logout = new LOGIN_FORM();
            //logout.Show();
        }

        private void btnRelacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSmerSemestarPredmetProfesor adminRelacija = new StudentskaSluzba.frmSmerSemestarPredmetProfesor(lblMainUser.Text);
            adminRelacija.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentskaSluzbaStatistika adminRelacija = new StudentskaSluzba.frmStudentskaSluzbaStatistika(lblMainUser.Text);
            adminRelacija.ShowDialog();
        }
    }
}
