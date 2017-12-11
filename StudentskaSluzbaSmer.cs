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
    public partial class frmStudentskaSluzbaSmer : Form
    {
        int smerID;
        public frmStudentskaSluzbaSmer(string user)
        {
            
            InitializeComponent();
            lblSmerLoginPrikaz.Text = user;
            FillCombobox();
            LoadTable();

        }

        void FillCombobox()
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
                    cmbSmer.Items.Add(smerNaziv);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            myConn.Close();
            
        }

        void LoadTable()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            try
            {
                myConn.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.smer ;", myConn);
                DataTable dbDataSet = new DataTable();
                myDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataSet;
                dataGridViewSmer.DataSource = bSource;
                myDataAdapter.Update(dbDataSet);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void btnSmerUnos_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "INSERT INTO studentskasluzba.smer (smer_naziv,smer_mnemo) VALUES('" + this.txtSmerNaziv.Text.ToUpper() + "','" + this.txtSmerMnemo.Text.ToUpper() + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Slog je upisan u bazu");
                txtSmerNaziv.Text = "";
                txtSmerMnemo.Text = "";
                txtSmerNaziv.Focus();
                
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            myConn.Close();
            LoadTable();
        }

        private void btnSmerIzmena_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "UPDATE studentskasluzba.smer SET smer_naziv='" + this.txtSmerNaziv.Text.ToUpper() + "',smer_mnemo='" + this.txtSmerMnemo.Text.ToUpper() + "' WHERE smer_id='" + smerID + "';";
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

        private void btnSmerBrisanje_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "DELETE FROM  studentskasluzba.smer WHERE smer_id='" + smerID + "';";
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

        private void cmbSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.smer where smer_naziv = '" + cmbSmer.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    smerID = myReader.GetInt32("smer_id");
                    string smerNaziv = myReader.GetString("smer_naziv");
                    string smerMnemo = myReader.GetString("smer_mnemo");

                    txtSmerNaziv.Text = smerNaziv;
                    txtSmerMnemo.Text = smerMnemo;


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

        private void lblSmerLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaMainMenuAdmin mainForm = new frmStudentskaSluzbaMainMenuAdmin(lblSmerLoginPrikaz.Text);
            mainForm.Show();
        }
    }
}
