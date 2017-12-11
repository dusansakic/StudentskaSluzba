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
using System.Text.RegularExpressions;

namespace StudentskaSluzba
{
    public partial class frmStudentskaSluzbaProfesor : Form
    {
        int profesorId;
        int grupaId;
        int korisniciId;
        int studentSmerId;
        int studentId;
        int brojKaraktera = 0;

        //definisanje delegata za combobox studenti koji ce se pozivati kod refresh-a 
        public delegate void FillCombobox();
        public frmStudentskaSluzbaProfesor(string user,string vrsta)
        {
            InitializeComponent();
            
            FillComboboxGrupa();
            FillCombobox profesori = new FillCombobox(FillComboboxProfesor);
            profesori.Invoke();
            FillCombobox studenti = new FillCombobox(FillComboboxStudent);
            studenti.Invoke();
            FillComboboxProfesor();
            FillComboboxStudent();
            FillComboboxSmer();
            lblProfesorPrikazLogin.Text = user;
            
            lblVrstaKorisnikaSistema.Text = vrsta;
            LoadTable(lblVrstaKorisnikaSistema.Text);
            if (vrsta.Equals("PROFESOR"))
            {
                grpBoxStudent.DataBindings.Control.Enabled = false;
            }
            if (vrsta.Equals("STUDENT"))
            {
                grpBoxProfesor.DataBindings.Control.Enabled = false;
            }
        }
        

        public bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        void FillComboboxStudent()
        {
            cmbStudentStudenti.Items.Clear();
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.student ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string studentImePrezime = "";

                    string studentPrezime = myReader.GetString("student_prezime");
                    string studentIme = myReader.GetString("student_ime");
                    studentImePrezime = studentIme + " " + studentPrezime;

                    cmbStudentStudenti.Items.Add(studentImePrezime);
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
                    string smerNaziv = myReader.GetString("smer_mnemo");
                    cmbStudentSmer.Items.Add(smerNaziv);
                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        void FillComboboxGrupa()
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
                    
                    string vrstaKorisnika = myReader.GetString("grupa_naziv");
                    cmbProfesorVrstaKorisnika.Items.Add(vrstaKorisnika);
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
            cmbProfesor.Items.Clear();
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
                    
                    cmbProfesor.Items.Add(profesorImePrezime);
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

        void LoadTable(string korisnikSistema)
        {
            if (korisnikSistema.Equals("PROFESOR"))
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                try
                {
                    myConn.Open();
                    MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                    myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.profesor ;", myConn);
                    DataTable dbDataSet = new DataTable();
                    myDataAdapter.Fill(dbDataSet);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbDataSet;
                    dataGridViewProfesor.DataSource = bSource;
                    myDataAdapter.Update(dbDataSet);
                    myConn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myConn.Close();
                }
            }

            if (korisnikSistema.Equals("STUDENT"))
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                try
                {
                    myConn.Open();
                    MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                    myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM studentskasluzba.student ;", myConn);
                    DataTable dbDataSet = new DataTable();
                    myDataAdapter.Fill(dbDataSet);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbDataSet;
                    dataGridViewProfesor.DataSource = bSource;
                    myDataAdapter.Update(dbDataSet);
                    myConn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myConn.Close();
                }
            }



        }
        

        private void btnProfesorUnos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProfesorUsername.Text) || String.IsNullOrWhiteSpace(txtProfesorUsername.Text) || txtProfesorUsername.Text.Length == 0 || String.IsNullOrEmpty(txtProfesorIme.Text) || String.IsNullOrWhiteSpace(txtProfesorIme.Text) || txtProfesorIme.Text.Length == 0 ||String.IsNullOrEmpty(txtProfesorPrezime.Text) || String.IsNullOrWhiteSpace(txtProfesorPrezime.Text) || txtProfesorPrezime.Text.Length == 0 || String.IsNullOrEmpty(txtProfesorEmail.Text) || String.IsNullOrWhiteSpace(txtProfesorEmail.Text) || txtProfesorEmail.Text.Length == 0)
            {
                MessageBox.Show("Niste popunili sva polja");
            }
            else
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                string Query = "START TRANSACTION; INSERT INTO studentskasluzba.korisnici (username,password,grupa_id)VALUES('" + this.txtProfesorUsername.Text + "','" + this.txtProfesorPassword.Text + "','" + grupaId + "');INSERT INTO studentskasluzba.profesor (profesor_ime,profesor_prezime,profesor_zvanje,profesor_email,profesor_korisnik_id) VALUES ('" + this.txtProfesorIme.Text.ToUpper() + "','" + this.txtProfesorPrezime.Text.ToUpper() + "','" + this.txtProfesorZvanje.Text.ToUpper() + "','" + this.txtProfesorEmail.Text + "',last_insert_id()); COMMIT;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;
                try
                {

                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    MessageBox.Show("Slog je upisan u bazu");
                    txtProfesorUsername.Text = "";
                    txtProfesorPassword.Text = "";
                    cmbProfesorVrstaKorisnika.Text = "";
                    txtProfesorIme.Text = "";
                    txtProfesorPrezime.Text = "";
                    txtProfesorZvanje.Text = "";
                    txtProfesorEmail.Text = "";
                    txtProfesorUsername.Focus();
                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                    myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtProfesorUsername.Text = "";
                    txtProfesorPassword.Text = "";
                    cmbProfesorVrstaKorisnika.Text = "";
                    txtProfesorIme.Text = "";
                    txtProfesorPrezime.Text = "";
                    txtProfesorZvanje.Text = "";
                    txtProfesorEmail.Text = "";
                    txtProfesorUsername.Focus();
                    myConn.Close();
                }
            }
                
            LoadTable(lblVrstaKorisnikaSistema.Text);
            FillCombobox profesori = new FillCombobox(FillComboboxProfesor);
            profesori.Invoke();
            
        }

        private void btnProfesorIzmena_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "START TRANSACTION; UPDATE studentskasluzba.korisnici SET username='" + this.txtProfesorUsername.Text + "',password='" + this.txtProfesorPassword.Text + "' WHERE korisnici_id='" + korisniciId + "';UPDATE studentskasluzba.profesor SET profesor_ime ='"+txtProfesorIme.Text+"', profesor_prezime='"+ txtProfesorPrezime.Text+"', profesor_zvanje= '"+txtProfesorZvanje.Text+"',profesor_email = '"+txtProfesorEmail.Text+"' WHERE profesor_id = '"+profesorId+"';"+" COMMIT;";
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
            LoadTable(lblVrstaKorisnikaSistema.Text);
        }



        private void btnProfesorBrisanje_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "START TRANSACTION; DELETE FROM studentskasluzba.profesor WHERE profesor_id = '" + profesorId + "';DELETE FROM  studentskasluzba.korisnici WHERE korisnici_id='" + korisniciId + "';" + " COMMIT;";
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
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
            LoadTable(lblVrstaKorisnikaSistema.Text);
        }

        private void cmbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string text = cmbProfesor.Text;
            string[] imePrezime = text.Split(' ');
            
            string Query = "SELECT profesor_id,username,password,profesor_ime,profesor_prezime,profesor_zvanje,profesor_email,profesor_korisnik_id,studentskasluzba.grupa.grupa_id,grupa_naziv FROM  studentskasluzba.profesor,studentskasluzba.korisnici,studentskasluzba.grupa WHERE profesor_ime = '" + imePrezime[0] + "' AND profesor_prezime= '" + imePrezime[1] +"' AND studentskasluzba.profesor.profesor_korisnik_id= studentskasluzba.korisnici.korisnici_id AND studentskasluzba.korisnici.grupa_id=studentskasluzba.grupa.grupa_id;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    profesorId = myReader.GetInt32("profesor_id");
                    korisniciId = myReader.GetInt32("profesor_korisnik_id");
                    string userName = myReader.GetString("username");
                    string korPasswd = myReader.GetString("password");
                    string korGrupaNaziv = myReader.GetString("grupa_naziv");
                    grupaId = myReader.GetInt32("grupa_id");

                    string profesorIme = myReader.GetString("profesor_ime");
                    string profesorPrezime = myReader.GetString("profesor_prezime");
                    string profesorZvanje = myReader.GetString("profesor_zvanje");
                    string profesorEmail = myReader.GetString("profesor_email");

                    txtProfesorUsername.Text = userName;
                    txtProfesorPassword.Text = korPasswd;
                    cmbProfesorVrstaKorisnika.Text = korGrupaNaziv;

                    txtProfesorIme.Text = profesorIme;
                    txtProfesorPrezime.Text = profesorPrezime;
                    txtProfesorZvanje.Text = profesorZvanje;
                    txtProfesorEmail.Text = profesorEmail;
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

        

        

        private void chkProfesorProveraUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProfesorProveraUserName.Checked)
            {
                try
                {


                    string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";

                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    MySqlCommand SelectCommand = new MySqlCommand("SELECT username  FROM studentskasluzba.korisnici WHERE username='" + this.txtProfesorUsername.Text + "' ;", myConn);
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {

                        count++;
                    }
                    if (count == 1)
                    {

                        lblProfesorProveraUsername.Visible = true;
                        lblProfesorProveraUsername.Text = "Korisnicko ime je zauzeto";
                        lblProfesorProveraUsername.ForeColor = Color.Red;




                    }
                    else if (count > 1)
                    {

                        lblProfesorProveraUsername.Visible = true;
                        lblProfesorProveraUsername.Text = "Korisnicko ime je zauzeto";
                        lblProfesorProveraUsername.ForeColor = Color.Red;

                        txtProfesorUsername.Focus();

                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txtProfesorUsername.Text) || String.IsNullOrWhiteSpace(txtProfesorUsername.Text) || txtProfesorUsername.Text.Length == 0)
                        {

                            lblProfesorProveraUsername.Visible = true;
                            lblProfesorProveraUsername.Text = "Unesite username...";
                            lblProfesorProveraUsername.ForeColor = Color.Red;
                        }
                        else
                        {

                            lblProfesorProveraUsername.Visible = true;
                            lblProfesorProveraUsername.Text = "Korisnicko ime je slobodno";
                            lblProfesorProveraUsername.ForeColor = Color.Green;

                        }


                    }
                    myConn.Close();
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (chkProfesorProveraUserName.Checked == false)
            {
                lblProfesorProveraUsername.Text = "";
            }
        }

        private void linkProfesorLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaMainMenuAdmin parentForm = new frmStudentskaSluzbaMainMenuAdmin(lblProfesorPrikazLogin.Text);
            parentForm.Show();
        }

        private void cmbProfesorVrstaKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.grupa where grupa_naziv = '" + cmbProfesorVrstaKorisnika.Text + "';";
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
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void chkProfesorProveraEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (isValidEmail(txtProfesorEmail.Text))
            {
                txtProfesorEmail.BackColor = Color.Green;
            }
            else
            {
                txtProfesorEmail.BackColor = Color.Red;
            }
        }

        private void btnStudentUpis_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(txtProfesorUsername.Text) || String.IsNullOrWhiteSpace(txtProfesorUsername.Text) || txtProfesorUsername.Text.Length == 0 || String.IsNullOrEmpty(txtStudentIme.Text) || String.IsNullOrWhiteSpace(txtStudentIme.Text) || txtStudentIme.Text.Length == 0 || String.IsNullOrEmpty(txtStudentPrezime.Text) || String.IsNullOrWhiteSpace(txtStudentPrezime.Text) || txtStudentPrezime.Text.Length == 0 || String.IsNullOrEmpty(txtStudentEmail.Text) || String.IsNullOrWhiteSpace(txtStudentEmail.Text) || txtStudentEmail.Text.Length == 0 || String.IsNullOrEmpty(txtStudentJMBG.Text) || String.IsNullOrWhiteSpace(txtStudentJMBG.Text) || txtStudentJMBG.Text.Length == 0)
            {
                MessageBox.Show("Niste popunili sva polja");
            }
            else if(txtStudentJMBG.Text.Length<13 || txtStudentJMBG.Text.Length > 13)
            {
                MessageBox.Show("JMBG nije ispravan");
            }
            else if (!isValidEmail(txtStudentEmail.Text))
                {
                MessageBox.Show("Email adresa nije validna");
                }
                
            else
            {
                
                string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                string Query = "START TRANSACTION; INSERT INTO studentskasluzba.korisnici (username,password,grupa_id)VALUES('" + this.txtProfesorUsername.Text + "','" + this.txtProfesorPassword.Text + "','" + grupaId + "');INSERT INTO studentskasluzba.student (student_ime,student_prezime,student_jmbg,student_datumrodjenja,student_telefon,student_smer_id,student_broj_indeksa,student_godina_upisa,student_email,student_korisnik_id) VALUES ('" + this.txtStudentIme.Text.ToUpper() + "','" + this.txtStudentPrezime.Text.ToUpper() + "','" + this.txtStudentJMBG.Text + "','" +dateTimePickerDatumRodjenja.Value.ToString("yyyy-MM-dd")+"','"+txtStudentTelefon.Text+"','"+ studentSmerId+"','"+txtStudentBrIndeksa.Text+"','"+txtStudentGodinaUpisa.Text+"','"+ this.txtStudentEmail.Text + "',last_insert_id()); COMMIT;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;
                try
                {

                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    MessageBox.Show("Slog je upisan u bazu");
                    txtProfesorUsername.Text = "";
                    txtProfesorPassword.Text = "";
                    cmbProfesorVrstaKorisnika.Text = "";
                    txtStudentIme.Text = "";
                    txtStudentPrezime.Text = "";
                    txtStudentJMBG.Text = "";
                    dateTimePickerDatumRodjenja.Text = "";
                    txtStudentTelefon.Text = "";
                    txtStudentBrIndeksa.Text = "";
                    txtStudentGodinaUpisa.Text = "";
                    txtProfesorEmail.Text = "";
                    txtProfesorUsername.Focus();
                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtProfesorUsername.Text = "";
                    txtProfesorPassword.Text = "";
                    cmbProfesorVrstaKorisnika.Text = "";
                    txtStudentIme.Text = "";
                    txtStudentPrezime.Text = "";
                    txtStudentJMBG.Text = "";
                    dateTimePickerDatumRodjenja.Text = "";
                    txtStudentTelefon.Text = "";
                    txtStudentBrIndeksa.Text = "";
                    txtStudentGodinaUpisa.Text = "";
                    cmbStudentSmer.Text = "";
                    txtStudentEmail.Text = "";
                    txtProfesorUsername.Focus();
                    myConn.Close();
                }
            }

            LoadTable(lblVrstaKorisnikaSistema.Text);
            FillCombobox studenti = new FillCombobox(FillComboboxStudent);
            studenti.Invoke();
        }

        private void cmbStudentSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.smer where smer_mnemo = '" + cmbStudentSmer.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    studentSmerId = myReader.GetInt32("smer_id");
                    


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

        private void cmbStudentStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string text = cmbStudentStudenti.Text;
            string[] imePrezime = text.Split(' ');

            string Query = "SELECT student_id,username,password,student_ime,student_prezime,student_jmbg,student_datumrodjenja,student_telefon,studentskasluzba.smer.smer_id,smer_mnemo,student_broj_indeksa,student_godina_upisa,student_email,student_korisnik_id,studentskasluzba.grupa.grupa_id,grupa_naziv FROM  studentskasluzba.student,studentskasluzba.korisnici,studentskasluzba.grupa,studentskasluzba.smer WHERE student_ime = '" + imePrezime[0] + "' AND student_prezime= '" + imePrezime[1] + "' AND studentskasluzba.student.student_korisnik_id= studentskasluzba.korisnici.korisnici_id AND studentskasluzba.korisnici.grupa_id=studentskasluzba.grupa.grupa_id AND studentskasluzba.student.student_smer_id= studentskasluzba.smer.smer_id;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    studentId = myReader.GetInt32("student_id");
                    korisniciId = myReader.GetInt32("student_korisnik_id");
                    string userName = myReader.GetString("username");
                    string korPasswd = myReader.GetString("password");
                    string korGrupaNaziv = myReader.GetString("grupa_naziv");
                    grupaId = myReader.GetInt32("grupa_id");
                    studentSmerId = myReader.GetInt32("smer_id");

                    string studentIme = myReader.GetString("student_ime");
                    string studentPrezime = myReader.GetString("student_prezime");
                    string studentJmbg = myReader.GetString("student_jmbg");
                    
                    
                    string student_datumrodjenja = myReader.GetString("student_datumrodjenja");
                    string studentTelefon = myReader.GetString("student_telefon");
                    string studentSmer = myReader.GetString("smer_mnemo");
                    string studentBrojIndeksa = myReader.GetString("student_broj_indeksa");
                    string studentGodinaUpisa = myReader.GetString("student_godina_upisa");
                    string studentEmail = myReader.GetString("student_email");

                    txtProfesorUsername.Text = userName;
                    txtProfesorPassword.Text = korPasswd;
                    cmbProfesorVrstaKorisnika.Text = korGrupaNaziv;

                    txtStudentIme.Text = studentIme;
                    txtStudentPrezime.Text = studentPrezime;
                    txtStudentJMBG.Text = studentJmbg;
                    dateTimePickerDatumRodjenja.Text = student_datumrodjenja;
                    txtStudentTelefon.Text = studentTelefon;
                    cmbStudentSmer.Text = studentSmer;
                    txtStudentBrIndeksa.Text = studentBrojIndeksa;
                    txtStudentGodinaUpisa.Text = studentGodinaUpisa;

                    txtStudentEmail.Text = studentEmail;
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

        private void btnStudentBrisanje_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "START TRANSACTION; DELETE FROM studentskasluzba.student WHERE student_id = '" + studentId + "';DELETE FROM  studentskasluzba.korisnici WHERE korisnici_id='" + korisniciId + "';" + " COMMIT;";
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
                myConn.Close();
                myReader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
            LoadTable(lblVrstaKorisnikaSistema.Text);
        }

        private void btnStudentIzmena_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "START TRANSACTION; UPDATE studentskasluzba.korisnici SET username='" + this.txtProfesorUsername.Text + "',password='" + this.txtProfesorPassword.Text + "' WHERE korisnici_id='" + korisniciId + "';UPDATE studentskasluzba.student SET student_ime ='" + txtStudentIme.Text.ToUpper() + "', student_prezime='" + txtStudentPrezime.Text.ToUpper() + "', student_jmbg= '" + txtStudentJMBG.Text + "',student_datumrodjenja='"+dateTimePickerDatumRodjenja.Value.ToString("yyyy-MM-dd")+"',student_telefon='"+txtStudentTelefon.Text+"',student_smer_id='"+studentSmerId+"',student_broj_indeksa='"+txtStudentBrIndeksa.Text+"',student_godina_upisa='"+txtStudentGodinaUpisa.Text+"',student_email = '" + txtStudentEmail.Text + "' WHERE student_id = '" + studentId+ "';" + " COMMIT;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Updated");
                txtProfesorUsername.Text = "";
                txtProfesorPassword.Text = "";
                cmbProfesorVrstaKorisnika.Text = "";
                txtStudentIme.Text = "";
                txtStudentPrezime.Text = "";
                txtStudentJMBG.Text = "";
                dateTimePickerDatumRodjenja.Text = "";
                txtStudentTelefon.Text = "";
                txtStudentBrIndeksa.Text = "";
                txtStudentGodinaUpisa.Text = "";
                cmbStudentSmer.Text = "";
                cmbStudentStudenti.Text = "";
                txtStudentEmail.Text = "";
                txtProfesorUsername.Focus();

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
            LoadTable(lblVrstaKorisnikaSistema.Text);
        }

        private void txtStudentJMBG_TextChanged(object sender, EventArgs e)
        {
            
            brojKaraktera++;
            if (txtStudentJMBG.Text.Length == 7)
            {
                
                if (txtStudentJMBG.Text.Substring(4, 1).Equals("9"))
                {
                    DateTime datum = DateTime.Parse(txtStudentJMBG.Text.Substring
                    (0, 2) + "." + txtStudentJMBG.Text.Substring(2, 2) + "." + "1" + txtStudentJMBG.Text.Substring(4, 3));
                    dateTimePickerDatumRodjenja.Value = datum;
                }
                if (txtStudentJMBG.Text.Substring(4, 1).Equals("0"))
                {
                    DateTime datum = DateTime.Parse(txtStudentJMBG.Text.Substring
                    (0, 2) + "." + txtStudentJMBG.Text.Substring(2, 2) + "." + "2" + txtStudentJMBG.Text.Substring(4, 3));
                    dateTimePickerDatumRodjenja.Value = datum;
                }
                
            }
            else
            {
                if (txtStudentJMBG.Text.Length < 7){
                    dateTimePickerDatumRodjenja.Value = DateTime.Now;
                }
                
            }
        }

        private void chkBoxStudentEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxStudentEmail.Checked)
            {
                if (isValidEmail(txtStudentEmail.Text))
                {
                    txtStudentEmail.BackColor = Color.Green;
                    lblStudentiEmailPrikazValidnosti.Text = "Email adresa je validna";
                }
                else
                {
                    txtStudentEmail.BackColor = Color.Red;
                    lblStudentiEmailPrikazValidnosti.Text = "Email adresa nije validna";
                }
            }
            else if (chkBoxStudentEmail.Checked == false)
            {
                lblStudentiEmailPrikazValidnosti.Text = "";
                txtStudentEmail.BackColor = DefaultBackColor;
            }
                
        }
    }
}
