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
    public partial class frmStudentskaSluzbaVrstaKorisnika : Form
    {
        int grupaId;
        public frmStudentskaSluzbaVrstaKorisnika(string mainUser)
        {
            InitializeComponent();
            FillCombobox();
            LoadTable();
            lblVrsteKorisnikaLoginPrikaz.Text = mainUser;
            
        }

        void FillCombobox()
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
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.grupa ;", myConn);
                DataTable dbDataSet = new DataTable();
                myDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataSet;
                dataGridViewVrstaKorisnika.DataSource = bSource;
                myDataAdapter.Update(dbDataSet);
                myConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    string grupaNaziv = myReader.GetString("grupa_naziv");
                    string grupaMnemo = myReader.GetString("grupa_mnemo");

                    txtVrstaKorisnika.Text = grupaNaziv;
                    txtMnemo.Text = grupaMnemo;
                    

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

        private void lblMnemo_Click(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "INSERT INTO studentskasluzba.grupa (grupa_naziv,grupa_mnemo) VALUES('" + this.txtVrstaKorisnika.Text.ToUpper() + "','" + this.txtMnemo.Text.ToUpper() + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Slog je upisan u bazu");
                txtVrstaKorisnika.Text = "";
                txtMnemo.Text = "";
                txtVrstaKorisnika.Focus();
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

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "UPDATE studentskasluzba.grupa SET grupa_naziv='" + this.txtVrstaKorisnika.Text.ToUpper() + "',grupa_mnemo='" + this.txtMnemo.Text.ToUpper() + "' WHERE grupa_id='" + grupaId + "';";
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

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "DELETE FROM  studentskasluzba.grupa WHERE grupa_id='" + grupaId + "';";
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

        private void lnkVrsteKorisnikaLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaMainMenuAdmin parentForm = new frmStudentskaSluzbaMainMenuAdmin(lblVrsteKorisnikaLoginPrikaz.Text);
            parentForm.Show();
        }
    }
}
