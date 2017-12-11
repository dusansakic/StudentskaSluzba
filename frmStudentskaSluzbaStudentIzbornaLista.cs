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
    public partial class frmStudentskaSluzbaStudentIzbornaLista : Form
    {
        int smerID;
        int zbirEspb = 0;
        string espb;
        int predmetID;
        int studentID;
        string prviSemestar, drugiSemestar, treciSemestar, cetvrtiSemestar, petiSemestar, sestiSemestar;

        public frmStudentskaSluzbaStudentIzbornaLista(int idKorisnika,string user)
        {
            InitializeComponent();
            lblIzbornaListaLoginPrikaz.Text = user;
            prikazPodatakaStudent(idKorisnika);
            FillComboboxSmer();
            brojTextBoxNaFormi();
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
                    cmbIzbornaListaSmerOstali.Items.Add(smerNaziv);
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

        void prikazPodatakaStudent(int id)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT   student_id,student_ime,student_prezime,student_smer_id,smer_naziv FROM  studentskasluzba.student,studentskasluzba.smer WHERE student_korisnik_id='"+id+"' AND student_smer_id=smer_id;";
            
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
                    studentID = myReader.GetInt32("student_id");
                    string studentPrezime = myReader.GetString("student_prezime");
                    string studentIme = myReader.GetString("student_ime");
                    string studentSmer = myReader.GetString("smer_naziv");
                    smerID = myReader.GetInt32("student_smer_id");
                    studentImePrezime = studentIme + " " + studentPrezime;
                    lblIzbornaListaImePrezime.Text = studentImePrezime;
                    lblIzbornaListaSmerNaziv.Text = studentSmer;


                    
                    
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



        private void lblIzbornaListaLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaLogin mainForm = new frmStudentskaSluzbaLogin();
            mainForm.Show();
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (!label1.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label1.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
                
            }
            if (checkBox1.Checked == true)
            {
                if (!label1.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label1.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }

        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (!label2.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label2.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox2.Checked == true)
            {
                if (!label2.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label2.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                if (!label3.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label3.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox3.Checked == true)
            {
                if (!label3.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label3.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                if (!label4.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label4.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox4.Checked == true)
            {
                if (!label4.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label4.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                if (!label5.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label5.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox5.Checked == true)
            {
                if (!label5.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label5.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox6.Checked == false)
            {
                if (!label6.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label6.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox6.Checked == true)
            {
                if (!label6.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label6.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox13_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox13.Checked == false)
            {
                if (!label13.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label3.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox13.Checked == true)
            {
                if (!label13.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label13.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox7.Checked == false)
            {
                if (!label7.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label7.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox7.Checked == true)
            {
                if (!label7.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label7.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox8.Checked == false)
            {
                if (!label8.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label8.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox8.Checked == true)
            {
                if (!label8.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label8.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox9.Checked == false)
            {
                if (!label9.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label9.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox9.Checked == true)
            {
                if (!label9.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label9.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox10.Checked == false)
            {
                if (!label10.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label10.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox10.Checked == true)
            {
                if (!label10.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label10.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox11_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox11.Checked == false)
            {
                if (!label11.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label11.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox11.Checked == true)
            {
                if (!label11.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label11.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox12.Checked == false)
            {
                if (!label12.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label12.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox12.Checked == true)
            {
                if (!label12.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label12.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void checkBox14_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox14.Checked == false)
            {
                if (!label14.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label14.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox14.Checked == true)
            {
                if (!label14.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label14.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        private void cmbIzbornaListaSmerOstali_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.smer where smer_naziv = '" + cmbIzbornaListaSmerOstali.Text + "';";
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
                    


                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
            
            
            //punjenje combobox za predmete na osnovu odabranog predmeta

            
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT predmet_naziv FROM  studentskasluzba.predmet,studentskasluzba.smersemestarpredmetprofesor where smersemestarpredmetprofesor.rel_smer_id = '" + smerID+ "' AND smersemestarpredmetprofesor.rel_predmet_id = predmet.predmet_id;";
            MySqlConnection myConn1 = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommand1 = new MySqlCommand(Query1, myConn1);
            MySqlDataReader myReader1;
            try
            {

                myConn1.Open();
                myReader1 = SelectCommand1.ExecuteReader();
                cmbIzbornaListaPredmetiOstali.Text = "";
                cmbIzbornaListaPredmetiOstali.Items.Clear();
                while (myReader1.Read())
                {
                    string predmetNaziv = myReader1.GetString("predmet_naziv");
                    cmbIzbornaListaPredmetiOstali.Items.Add(predmetNaziv);




                }
                myConn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn1.Close();
            }


        }

        private void cmbIzbornaListaPredmetiOstali_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.predmet where predmet_naziv = '" + cmbIzbornaListaPredmetiOstali.Text + "';";
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

                    lblID15.Text = predmetID.ToString();
                    textBox15.Text = predmetNaziv;
                    label15.Text = predmetEspb;

                    if (predmetObavezan.Equals("DA"))
                    {
                        MessageBox.Show("Predmet ne moze biti izabran jer je obavezan predmet na izabranom smeru");
                    }
                    else
                    {
                        

                    }


                    



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

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == false)
            {
                if (!label15.Text.Equals("0"))
                {
                    zbirEspb -= int.Parse(label15.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
            if (checkBox15.Checked == true)
            {
                if (!label15.Text.Equals("0"))
                {
                    zbirEspb += int.Parse(label15.Text);
                    lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();
                }
            }
        }

        

        public int brojTextBoxNaFormi()
        {
            
            int countTB = 0;
            

            foreach (Control c in this.Controls)
            {
                
                if (c.GetType() == typeof(TextBox))
                {
                    countTB++;
                }
                
            }

            return countTB;
            
        }

        

        void obrisiIzbornuListu()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "DELETE FROM studentskasluzba.izbornalista where izbornalista_student_id= '"+studentID+"';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();


                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            myConn.Close();
        }

        

        private void btnIzbornaListaPredajListu_Click(object sender, EventArgs e)
        {
            if (zbirEspb >= 48)
            {
                obrisiIzbornuListu();

                int brojTextBox = brojTextBoxNaFormi();
                for (int i = 1; i <= brojTextBox; i++)
                {
                    var labelID = this.Controls.OfType<Label>();
                    var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblID" + i.ToString()));
                    if (!labelId.Text.Equals("NOID"))
                    {
                        int pomPredmetID = int.Parse(labelId.Text);
                    var checkBoxes = this.Controls.OfType<CheckBox>();
                                       
                    var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("checkBox" + i.ToString()));
                    string odabranPredmet;


                    

                        if (checkBoxPredmeti.Checked==true)
                        {
                            odabranPredmet = "DA";
                        }
                        else
                        {
                            odabranPredmet = "NE";
                        }
                        string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                        string Query = "INSERT INTO studentskasluzba.izbornalista (izbornalista_student_id,izbornalista_predmet_id,izbornalista_izbor) VALUES('" + studentID + "','" + pomPredmetID +"','"+odabranPredmet+ "');";
                        MySqlConnection myConn = new MySqlConnection(myConnection);
                        MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
                        MySqlDataReader myReader;
                        try
                        {

                            myConn.Open();
                            myReader = SelectCommand.ExecuteReader();


                            while (myReader.Read())
                            {

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        
                        myConn.Close();


                    }


                    
                    

                }
                MessageBox.Show("Izborna lista je upisana u bazu");
                btnIzbornaListaPredajListu.DataBindings.Control.Enabled = false;

            }
            else
            {
                MessageBox.Show("Da biste predali listu morate imati 48 ESPB poena");
            }
        }

        public bool proveriPostojanjeIzborneListe()
        {
            int brojac = 0;
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT (izbornalista_student_id) as imaLIsta FROM studentskasluzba.izbornalista WHERE izbornalista_student_id= '" + studentID + "' ;";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;

            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();
                
                





                while (myReaderPredmet.Read())
                {

                        
                    ++brojac;


                }
                
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnPredmet.Close();
                
            }
            if (brojac >= 1)
            {
                myConnPredmet.Close();
                
                return true;
            }
            return false;
        }

        private void btnIzbornaListaKreirajListu_Click(object sender, EventArgs e)
        {



            bool imaListu= proveriPostojanjeIzborneListe();

            if (imaListu)
            {
                DialogResult izlaz = MessageBox.Show("Izborna lista postoji.Da li zelite prikaz?", "Izborna lista", MessageBoxButtons.YesNo);
                if (izlaz == DialogResult.Yes)
                {
                    string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                    string Query1 = "SELECT izbornalista_student_id,predmet_id,predmet_naziv,predmet_espb,izbornalista_izbor FROM studentskasluzba.student,studentskasluzba.izbornalista,studentskasluzba.predmet WHERE izbornalista_student_id= '" + studentID + "' AND izbornalista_student_id=student_id AND izbornalista_predmet_id=predmet_id;";
                    MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
                    MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
                    MySqlDataReader myReaderPredmet;
                    try
                    {

                        myConnPredmet.Open();
                        myReaderPredmet = SelectCommandPredmet.ExecuteReader();
                        int brojTextBox = 1;





                        while (myReaderPredmet.Read())
                        {

                            int predmetID = myReaderPredmet.GetInt32("predmet_id");
                            string predmet = myReaderPredmet.GetString("predmet_naziv");

                            string obavezan = myReaderPredmet.GetString("izbornalista_izbor");
                            espb = myReaderPredmet.GetString("predmet_espb");

                            var textBoxes = this.Controls.OfType<TextBox>();
                            var checkBoxes = this.Controls.OfType<CheckBox>();
                            var label = this.Controls.OfType<Label>();
                            var labelID = this.Controls.OfType<Label>();

                            var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals("textBox" + brojTextBox.ToString()));
                            var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("checkBox" + brojTextBox.ToString()));
                            var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals("label" + brojTextBox.ToString()));
                            var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblID" + brojTextBox.ToString()));

                            labelId.Text = predmetID.ToString();
                            labelId.DataBindings.Control.Enabled = false;
                            textBox1.Text = predmet;
                            textBox1.DataBindings.Control.Enabled = false;
                            labelPredmeti.Text = espb;

                            if (obavezan.Equals("DA"))
                            {
                                checkBoxPredmeti.Checked = true;
                                checkBoxPredmeti.DataBindings.Control.Enabled = false;
                                zbirEspb += int.Parse(espb);
                                lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();

                            }
                            ++brojTextBox;



                        }
                        myConnPredmet.Close();
                        myReaderPredmet.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        myConnPredmet.Close();
                    }
                }
                else if (izlaz == DialogResult.No)
                {
                    
                    //KreirajListu();
                }
            }else
            {
                KreirajListu();
            }

            
        }

        private void KreirajListu()
        {
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT predmet_id,predmet_naziv,predmet_obavezan,predmet_espb,rel_semestar  FROM studentskasluzba.student,studentskasluzba.smersemestarpredmetprofesor,studentskasluzba.predmet WHERE student_id='"+studentID+"' AND student_smer_id= '" + smerID + "' AND (rel_semestar='" + prviSemestar + "' OR rel_semestar='" + drugiSemestar + "' OR rel_semestar='" + treciSemestar + "' OR rel_semestar='" + cetvrtiSemestar + "' OR rel_semestar='" + petiSemestar + "' OR rel_semestar='" + sestiSemestar + "') AND student_smer_id=rel_smer_id AND rel_predmet_id=predmet_id ORDER BY rel_semestar;";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;
            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();
                int brojTextBox = 1;





                while (myReaderPredmet.Read())
                {

                    int predmetID = myReaderPredmet.GetInt32("predmet_id");
                    string predmet = myReaderPredmet.GetString("predmet_naziv");

                    string obavezan = myReaderPredmet.GetString("predmet_obavezan");
                    espb = myReaderPredmet.GetString("predmet_espb");

                    var textBoxes = this.Controls.OfType<TextBox>();
                    var checkBoxes = this.Controls.OfType<CheckBox>();
                    var label = this.Controls.OfType<Label>();
                    var labelID = this.Controls.OfType<Label>();

                    var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals("textBox" + brojTextBox.ToString()));
                    var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("checkBox" + brojTextBox.ToString()));
                    var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals("label" + brojTextBox.ToString()));
                    var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblID" + brojTextBox.ToString()));

                    labelId.Text = predmetID.ToString();
                    labelId.DataBindings.Control.Enabled = false;
                    textBox1.Text = predmet;
                    textBox1.DataBindings.Control.Enabled = false;
                    labelPredmeti.Text = espb;

                    if (obavezan.Equals("DA"))
                    {
                        checkBoxPredmeti.Checked = true;
                        checkBoxPredmeti.DataBindings.Control.Enabled = false;
                        zbirEspb += int.Parse(espb);
                        lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();

                    }
                    ++brojTextBox;



                }
                myConnPredmet.Close();
                myReaderPredmet.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnPredmet.Close();
            }
        }

        private void chkBoxSemestarPrvi_MouseClick(object sender, MouseEventArgs e)
        {
            //if (chkBoxSemestarPrvi.Checked == true)
            //{
            //    chkBoxSemestarPrvi.Checked = false;
            //}
            if (chkBoxSemestarPrvi.Checked == true)
            {
                chkBoxSemestarPrvi.Checked = true;
                prviSemestar = chkBoxSemestarPrvi.Text;
            }

            

        }

        private bool obavezanPredmet(int predmetID)
        {
            string obavezanPredmet="";
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT predmet_obavezan FROM studentskasluzba.predmet WHERE predmet_id='" + predmetID + "';";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;

            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();





                
                while (myReaderPredmet.Read())
                {

                     obavezanPredmet = myReaderPredmet.GetString("predmet_obavezan");



                    




                }
                if (obavezanPredmet.Equals("DA"))
                {
                    return true;

                }
                myConnPredmet.Close();
                myReaderPredmet.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnPredmet.Close();
            }
            return false;
        }

        private void btnIzbornaListaIzmena_Click(object sender, EventArgs e)
        {
            //zbirEspb = 0;
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT izbornalista_student_id,predmet_id,predmet_naziv,predmet_espb,izbornalista_izbor FROM studentskasluzba.student,studentskasluzba.izbornalista,studentskasluzba.predmet WHERE izbornalista_student_id= '" + studentID + "' AND izbornalista_student_id=student_id AND izbornalista_predmet_id=predmet_id;";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;
            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();
                int brojTextBox = 1;







                while (myReaderPredmet.Read())
                {
                    string obvPredmet = "";
                    int predmetID = myReaderPredmet.GetInt32("predmet_id");

                    //provera da li je predmet obavezan
                    bool obavezan = obavezanPredmet(predmetID);
                    


                    if (obavezan == true)
                    {
                        obvPredmet = "DA";
                        
                    }



                    string predmet = myReaderPredmet.GetString("predmet_naziv");

                    string izabranPredmet = myReaderPredmet.GetString("izbornalista_izbor");
                    espb = myReaderPredmet.GetString("predmet_espb");

                    var textBoxes = this.Controls.OfType<TextBox>();
                    var checkBoxes = this.Controls.OfType<CheckBox>();
                    var label = this.Controls.OfType<Label>();
                    var labelID = this.Controls.OfType<Label>();

                    var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals("textBox" + brojTextBox.ToString()));
                    var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("checkBox" + brojTextBox.ToString()));
                    var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals("label" + brojTextBox.ToString()));
                    var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblID" + brojTextBox.ToString()));

                    labelId.Text = predmetID.ToString();
                    labelId.DataBindings.Control.Enabled = false;
                    textBox1.Text = predmet;
                    textBox1.DataBindings.Control.Enabled = false;
                    labelPredmeti.Text = espb;

                    if (obvPredmet.Equals("DA"))
                    {
                        checkBoxPredmeti.Checked = true;
                        checkBoxPredmeti.DataBindings.Control.Enabled = false;
                        //zbirEspb += int.Parse(espb);
                        //lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();


                    }

                    if (izabranPredmet.Equals("DA"))
                    {
                        if (!obvPredmet.Equals("DA"))
                        {
                            checkBoxPredmeti.Checked = false;
                            checkBoxPredmeti.DataBindings.Control.Enabled = true;
                            zbirEspb -= int.Parse(espb);
                            lblIzbornaListaEspbZbir.Text = zbirEspb.ToString();

                        }


                    }
                    ++brojTextBox;



                }
                myConnPredmet.Close();
                myReaderPredmet.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnPredmet.Close();
            }
        }

        private void chkBoxSemestarDrugi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSemestarDrugi.Checked == true)
            {
                chkBoxSemestarDrugi.Checked = true;
                drugiSemestar = chkBoxSemestarDrugi.Text;
            }
        }

        private void chkBoxSemestarTreci_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSemestarTreci.Checked == true)
            {
                chkBoxSemestarTreci.Checked = true;
                treciSemestar = chkBoxSemestarTreci.Text;
            }
        }

        private void chkBoxSemestarCetvrti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSemestarCetvrti.Checked == true)
            {
                chkBoxSemestarCetvrti.Checked = true;
                cetvrtiSemestar = chkBoxSemestarCetvrti.Text;
            }
        }

        private void chkBoxSemestarPeti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSemestarPeti.Checked == true)
            {
                chkBoxSemestarPeti.Checked = true;
                petiSemestar = chkBoxSemestarPeti.Text;
            }
        }

        private void chkBoxSemestarSesti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSemestarSesti.Checked == true)
            {
                chkBoxSemestarSesti.Checked = true;
                sestiSemestar = chkBoxSemestarSesti.Text;
            }
        }
    }
}
