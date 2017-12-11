using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentskaSluzba
{
    public partial class frmStudentskaSluzbaLogin : Form
    {
        int idKorisnika;

        public frmStudentskaSluzbaLogin()
        {
            InitializeComponent();
            timerTime.Start();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmIzbornaListaRegistracija gostRegistracija = new frmIzbornaListaRegistracija();
            gostRegistracija.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string vrstaKorisnika="";
            

            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT korisnici_id,username,password,grupa_mnemo FROM studentskasluzba.korisnici,studentskasluzba.grupa WHERE username='" + this.txtUserName.Text + "' AND password='" + this.txtPassword.Text + "' AND studentskasluzba.korisnici.grupa_id = studentskasluzba.grupa.grupa_id  ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    vrstaKorisnika = myReader.GetString("grupa_mnemo");
                    idKorisnika = myReader.GetInt32("korisnici_id");

                    count++;
                }
                myConn.Close();
                myReader.Close();
                if (count == 1)
                {
                    if (vrstaKorisnika.Equals("ADMIN")){
                        
                        
                        frmStudentskaSluzbaMainMenuAdmin mainMenu = new StudentskaSluzba.frmStudentskaSluzbaMainMenuAdmin("ADMIN");
                        mainMenu.Show();
                        this.Hide();
                        
                        


                    }
                    if (vrstaKorisnika.Equals("STUD"))
                    {
                        

                        frmStudentskaSluzbaStudentIzbornaLista studentLista = new frmStudentskaSluzbaStudentIzbornaLista(idKorisnika,"STUDENT");
                        studentLista.Show();
                        this.Hide();




                    }
                    if (vrstaKorisnika.Equals("GOST"))
                    {

                        MessageBox.Show("Informacije za goste");
                        frmStudentskaSluzbaStatistika gostStatistika = new frmStudentskaSluzbaStatistika("GOST");
                        gostStatistika.Show();
                        this.Hide();




                    }


                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password ...Access denied");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();

                }
                else
                {
                    MessageBox.Show("Username and Password is Not correct...Please try again");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString();
        }

       

        private void frmStudentskaSluzbaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li zelite da napustite aplikaciju?", "Exit", MessageBoxButtons.YesNo);
            if (izlaz == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (izlaz == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
