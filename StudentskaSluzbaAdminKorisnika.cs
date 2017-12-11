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
    public partial class frmAdminKorisnika : Form
    {
        int grupaId;
        int korisniciId;
        public frmAdminKorisnika()
        {
            InitializeComponent();
            FillComboboxKorisnici();
            FillComboboxVrsteKorisnika();
            LoadTable();

        }

        void FillComboboxKorisnici()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.korisnici ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    //korisniciId = myReader.GetInt32("korisnici_id");
                    string userName = myReader.GetString("username");
                    cmbAdminKorisnika.Items.Add(userName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillComboboxVrsteKorisnika()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.grupa ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string grupaNaziv = myReader.GetString("grupa_naziv");
                    cmbVrstaKorisnika.Items.Add(grupaNaziv);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadTable()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.korisnici ;", myConn);
                DataTable dbDataSet = new DataTable();
                myDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataSet;
                dataGridViewKorisnici.DataSource = bSource;
                myDataAdapter.Update(dbDataSet);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUnosKorisnika_Click(object sender, EventArgs e)
        {

            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "INSERT INTO studentskasluzba.korisnici (username,password,grupa_id) VALUES('" + this.txtUserName.Text + "','" + this.txtPassword.Text + "','" + grupaId + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Slog je upisan u bazu");
                txtUserName.Text = "";
                txtPassword.Text = "";
                cmbVrstaKorisnika.Text = "";
                txtUserName.Focus();
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadTable();
            //FillCombobox();
        }

        

        private void btnIzmenaKorisnika_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "UPDATE studentskasluzba.korisnici SET username='" + this.txtUserName.Text + "',password='" + this.txtPassword.Text + "',grupa_id='" + grupaId + "' WHERE korisnici_id='" + korisniciId+ "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadTable();
        }

        private void cmbVrstaKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.grupa where grupa_naziv = '" + cmbVrstaKorisnika.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    grupaId = myReader.GetInt32("grupa_id");
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisanjeKorisnika_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "DELETE FROM  studentskasluzba.korisnici WHERE korisnici_id='" + this.txtUserName.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadTable();
        }

        private void cmbAdminKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT studentskasluzba.korisnici.korisnici_id,studentskasluzba.korisnici.username,studentskasluzba.korisnici.password,studentskasluzba.grupa.grupa_id,studentskasluzba.grupa.grupa_naziv  FROM  studentskasluzba.korisnici,studentskasluzba.grupa WHERE korisnici.username = '" + cmbAdminKorisnika.Text + "'"+" AND studentskasluzba.korisnici.grupa_id=studentskasluzba.grupa.grupa_id;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    korisniciId = myReader.GetInt32("korisnici_id");
                    string userName = myReader.GetString("username");
                    string korPasswd = myReader.GetString("password");
                    string korGrupaNaziv = myReader.GetString("grupa_naziv");
                    grupaId = myReader.GetInt32("grupa_id");
                    

                    txtUserName.Text = userName;
                    txtPassword.Text = korPasswd;
                    cmbVrstaKorisnika.Text = korGrupaNaziv;


                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAdminKorisnika_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li zelite da napustite aplikaciju?","Exit",MessageBoxButtons.YesNo);
            if(izlaz == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (izlaz == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
