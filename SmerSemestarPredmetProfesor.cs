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
    public partial class frmSmerSemestarPredmetProfesor : Form
    {
        string relacijaSemestar;
        int relacijaSmer;
        int relacijaPredmet;
        int relacijaProfesor;
        public frmSmerSemestarPredmetProfesor(string mainUser)
        {
            InitializeComponent();
            lblRelacijaLoginPrikaz.Text = mainUser;
            FillComboboxSmer();
            FillComboboxPredmeti();
            FillComboboxProfesor();
            LoadTable();
        }

        void LoadTable()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            try
            {
                myConn.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.smersemestarpredmetprofesor ;", myConn);
                DataTable dbDataSet = new DataTable();
                myDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataSet;
                dataGridViewRelacija.DataSource = bSource;
                myDataAdapter.Update(dbDataSet);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            myConn.Close();

        }

            void FillComboboxSmer()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.smer ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string smerNaziv = myReader.GetString("smer_naziv");
                    cmbRelacijaSmer.Items.Add(smerNaziv);
                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }


        void FillComboboxPredmeti()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.predmet ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string predmetNaziv = myReader.GetString("predmet_naziv");
                    cmbRelacijaPredmet.Items.Add(predmetNaziv);
                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }


        void FillComboboxProfesor()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.profesor ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string profesorImePrezime = "";

                    string profesorPrezime = myReader.GetString("profesor_prezime");
                    string profesorIme = myReader.GetString("profesor_ime");
                    profesorImePrezime = profesorIme + " " + profesorPrezime;

                    cmbRelacijaProfesor.Items.Add(profesorImePrezime);
                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }

        private void lblRelacijaLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaMainMenuAdmin parentForm = new frmStudentskaSluzbaMainMenuAdmin(lblRelacijaLoginPrikaz.Text);
            parentForm.Show();
        }

        private void btnRelacijaBrisanje_Click(object sender, EventArgs e)
        {

        }

        private void btnRelacijaIzmena_Click(object sender, EventArgs e)
        {

        }

        private void btnRelacijaUnos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbRelacijaSmer.Text) || String.IsNullOrWhiteSpace(cmbRelacijaSmer.Text) || cmbRelacijaSmer.Text.Length == 0 || String.IsNullOrEmpty(cmbRelacijaSemestar.Text) || String.IsNullOrWhiteSpace(cmbRelacijaSemestar.Text) || cmbRelacijaSemestar.Text.Length == 0 || String.IsNullOrEmpty(cmbRelacijaPredmet.Text) || String.IsNullOrWhiteSpace(cmbRelacijaPredmet.Text) || cmbRelacijaPredmet.Text.Length == 0 || String.IsNullOrEmpty(cmbRelacijaProfesor.Text) || String.IsNullOrWhiteSpace(cmbRelacijaProfesor.Text) || cmbRelacijaProfesor.Text.Length == 0) 
            {
                MessageBox.Show("Niste popunili sva polja");
            }
            else
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                string Query = "INSERT INTO studentskasluzba.smersemestarpredmetprofesor (rel_smer_id,rel_semestar,rel_predmet_id,rel_profesor_id)VALUES('" + relacijaSmer + "','" + relacijaSemestar + "','" + relacijaPredmet + "','" + relacijaProfesor + "');";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;
                try
                {

                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    MessageBox.Show("Slog je upisan u bazu");
                    cmbRelacijaSmer.Text = "";
                    cmbRelacijaSemestar.Text = "";
                    cmbRelacijaProfesor.Text = "";
                    cmbRelacijaPredmet.Text = "";

                    cmbRelacijaSmer.Focus();
                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                    myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmbRelacijaSmer.Text = "";
                    cmbRelacijaSemestar.Text = "";
                    cmbRelacijaProfesor.Text = "";
                    cmbRelacijaPredmet.Text = "";

                    cmbRelacijaSmer.Focus();
                    myConn.Close();
                }
            }

            LoadTable();
        }

        private void cmbRelacijaSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            relacijaSemestar = cmbRelacijaSemestar.Text;
        }

        private void cmbRelacijaSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.smer where smer_naziv = '" + cmbRelacijaSmer.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    relacijaSmer = myReader.GetInt32("smer_id");


                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }

        private void cmbRelacijaPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.predmet where predmet_naziv = '" + cmbRelacijaPredmet.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    relacijaPredmet = myReader.GetInt32("predmet_id");
                    
                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }

        private void cmbRelacijaProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string text = cmbRelacijaProfesor.Text;
            string[] imePrezime = text.Split(' ');

            string Query = "SELECT profesor_id,username,password,profesor_ime,profesor_prezime,profesor_zvanje,profesor_email,profesor_korisnik_id,studentskasluzba.grupa.grupa_id,grupa_naziv FROM  studentskasluzba.profesor,studentskasluzba.korisnici,studentskasluzba.grupa WHERE profesor_ime = '" + imePrezime[0] + "' AND profesor_prezime= '" + imePrezime[1] + "' AND studentskasluzba.profesor.profesor_korisnik_id= studentskasluzba.korisnici.korisnici_id AND studentskasluzba.korisnici.grupa_id=studentskasluzba.grupa.grupa_id;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    relacijaProfesor = myReader.GetInt32("profesor_id");

                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }
    }
}
