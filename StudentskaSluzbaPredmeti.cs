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
    public partial class frmStudentskaSluzbaPredmeti : Form
    {
        
        string predmetObavezan;
        int predmetID;

        public frmStudentskaSluzbaPredmeti(string mainUser)
        {
            InitializeComponent();

            lblPredmetiLoginPrikaz.Text = mainUser;
            
            FillComboboxPredmeti();
            LoadTable();
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
                    cmbPredmetPredmeti.Items.Add(predmetNaziv);
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

        void LoadTable()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            try
            {
                myConn.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.predmet ;", myConn);
                DataTable dbDataSet = new DataTable();
                myDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataSet;
                dataGridViewPredmet.DataSource = bSource;
                myDataAdapter.Update(dbDataSet);
                myConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }

        }

        private void btnPredmetUnos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPredmetNaziv.Text) || String.IsNullOrWhiteSpace(txtPredmetNaziv.Text) || txtPredmetNaziv.Text.Length == 0 || String.IsNullOrEmpty(txtPredmetEspb.Text) || String.IsNullOrWhiteSpace(txtPredmetEspb.Text) || txtPredmetEspb.Text.Length == 0 || String.IsNullOrEmpty(txtPredmetMnemo.Text) || String.IsNullOrWhiteSpace(txtPredmetMnemo.Text) || txtPredmetMnemo.Text.Length == 0 )
            {
                MessageBox.Show("Niste popunili sva polja");
            }
            else
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                string Query = "INSERT INTO studentskasluzba.predmet (predmet_naziv,predmet_espb,predmet_obavezan,predmet_mnemo)VALUES('" + this.txtPredmetNaziv.Text.ToUpper() +  "','"+this.txtPredmetEspb.Text.ToUpper()+"','"+predmetObavezan+"','"+this.txtPredmetMnemo.Text.ToUpper()+"');";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;
                try
                {

                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    MessageBox.Show("Slog je upisan u bazu");
                    txtPredmetNaziv.Text = "";
                    txtPredmetEspb.Text = "";
                    txtPredmetMnemo.Text = "";
                    
                    cmbPredmetObavezan.Text = "";
                   
                    txtPredmetNaziv.Focus();
                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                    myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtPredmetNaziv.Text = "";
                    txtPredmetEspb.Text = "";
                    txtPredmetMnemo.Text = "";
                    
                    cmbPredmetObavezan.Text = "";
                   
                    txtPredmetNaziv.Focus();
                    myConn.Close();
                }
            }

            LoadTable();
        }

        private void btnPredmetIzmena_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "UPDATE studentskasluzba.predmet SET predmet_naziv='" + this.txtPredmetNaziv.Text.ToUpper() + "',predmet_espb='" + this.txtPredmetEspb.Text.ToUpper() + "',predmet_obavezan= '"+cmbPredmetObavezan.Text+"',predmet_mnemo='"+txtPredmetMnemo.Text.ToUpper()+"' WHERE predmet_id='" + predmetID + "';";
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
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
            LoadTable();
        }

        private void lblPredmeti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaMainMenuAdmin parentForm = new frmStudentskaSluzbaMainMenuAdmin(lblPredmetiLoginPrikaz.Text);
            parentForm.Show();
        }
                

        private void cmbPredmetPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.predmet where predmet_naziv = '" + cmbPredmetPredmeti.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    predmetID = myReader.GetInt32("predmet_id");
                    string predmetNaziv = myReader.GetString("predmet_naziv");
                    string predmetEspb = myReader.GetString("predmet_espb");
                    string predmetObavezan = myReader.GetString("predmet_obavezan");
                    string predmetMnemo = myReader.GetString("predmet_mnemo");

                    txtPredmetNaziv.Text = predmetNaziv;
                    cmbPredmetObavezan.Text = predmetObavezan;
                    txtPredmetEspb.Text = predmetEspb;
                    txtPredmetMnemo.Text = predmetMnemo;


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

        private void cmbPredmetObavezan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            predmetObavezan = cmbPredmetObavezan.Text;
        }

        private void btnPredmetBrisanje_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "DELETE FROM  studentskasluzba.predmet WHERE predmet_id='" + predmetID + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Slog je obrisan");
                while (myReader.Read())
                {

                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
            LoadTable();
        }
    }
}
