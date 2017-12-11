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
    public partial class frmIzbornaListaRegistracija : Form
    {
        string vrstaKorisnika = "";
        string userName,passWord;
        int grupaKorisnik;
        public frmIzbornaListaRegistracija()
        {
            InitializeComponent();

        }

        private void upisGostKorisnika(string userName,string passWord,int grupaKorisnik)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO studentskasluzba.korisnici(username,password,studentskasluzba.korisnici.grupa_id) VALUES ('"+userName+"','"+passWord+"','"+grupaKorisnik+"');", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                
                while (myReader.Read())
                {
                    
                }
                myConn.Close();
                myReader.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnRegistracijaCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaLogin mainForm = new frmStudentskaSluzbaLogin();
            mainForm.Show();
        }

        private void btnRegistracijaRegistracija_Click(object sender, EventArgs e)
        {
            


            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT korisnici_id,username,password,grupa_mnemo FROM studentskasluzba.korisnici,studentskasluzba.grupa WHERE username='" + this.txtRegistracijaUsername.Text + "' AND password='" + this.txtRegistracijaPassword.Text + "' AND studentskasluzba.korisnici.grupa_id='"+4+"';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    vrstaKorisnika = myReader.GetString("grupa_mnemo");
                    userName = myReader.GetString("username");
                    passWord = myReader.GetString("password");
                    
                    

                    count++;
                }
                myConn.Close();
                myReader.Close();
                if (count == 0)
                {
                    if(string.IsNullOrWhiteSpace(txtRegistracijaUsername.Text) || string.IsNullOrWhiteSpace(txtRegistracijaPassword.Text))
                    {
                        MessageBox.Show("Niste uneli username ili password");

                    }else
                    {
                        userName = txtRegistracijaUsername.Text;
                    passWord = txtRegistracijaPassword.Text;
                    grupaKorisnik = 4;
                    upisGostKorisnika(userName,passWord,grupaKorisnik);
                        this.Visible = false;
                        frmStudentskaSluzbaLogin mainForm = new frmStudentskaSluzbaLogin();
                        mainForm.Show();
                    }
                    




                    
                    

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password ...Access denied");
                    txtRegistracijaUsername.Text = "";
                    txtRegistracijaPassword.Text = "";
                    txtRegistracijaUsername.Focus();

                }
                else
                {
                    MessageBox.Show("Username and Password is Not correct...Please try again");
                    txtRegistracijaUsername.Text = "";
                    txtRegistracijaPassword.Text = "";
                    txtRegistracijaUsername.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
