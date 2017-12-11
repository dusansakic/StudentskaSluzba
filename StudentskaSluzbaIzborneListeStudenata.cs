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
    public class IzbornaLista
    {
        public TextBox nazivPredmeta;
        public CheckBox izbor;
        public Label espbPoeni;

        public IzbornaLista(TextBox nazivPredmeta,CheckBox izbor, Label espbPoeni)
        {
            this.nazivPredmeta = nazivPredmeta;
            this.izbor = izbor;
            this.espbPoeni = espbPoeni;
        }
    }
    public partial class frmStudentskaSluzbaIzborneListeStudenata : Form
    {
        CheckBox[] nizSemestar;
        TextBox[] nizTextBoxNazivPredmeta;
        CheckBox[] nizCheckBoxIzborPredmeta;
        //IzbornaLista[] izbornaLista;
        Label[] nizLabelaEspbPredmeta;
        Button buttonIzmeniListu, buttonPredajListu,buttonKreirajListu;
        Label espbZbirPrikaz;
        Label[] nizLabelPredmetID;

        int zbirEspb = 0;
        string espb;
        int smerID;
        int studentID;
        int brojPredmeta=0;
        string prviSemestar, drugiSemestar, treciSemestar, cetvrtiSemestar, petiSemestar, sestiSemestar;
        int x = 700, y = 90,xtxt =600, ytxt = 120, xchk = 1005, ychk = 120, xlbl=1150, ylbl=120, xlblID=1250, ylblID=120,xlblzbir=1005, ylblzbir=565, xlblZbirPrikaz=1100, ylblZbirPrikaz=565,xpredaj=580,ypredaj=620,xkreiraj=850,ykreiraj=620,xizmena=1100,yizmena=620;
        //int brojacPredmeta = 0;

        public frmStudentskaSluzbaIzborneListeStudenata(string mainUser)
        {
            InitializeComponent();
            FillComboboxSmer();
            lblIzborneListeStudenataLoginPrikaz.Text = mainUser;
            dataGridViewIzborneListeStudenata.Visible = false;

        }
        //Dinamicko kreiranje labela za prikaz ID predmeta
        private Label LabelPredmetID(int x, int y, int i)
        {
            Label labela = new Label();
            labela.Location = new Point(x, y);

            labela.Font = new Font(labela.Font.FontFamily, 12);
            labela.Name = "lblPredmetID" + i.ToString();
            labela.Text = "NOID";

            return labela;


        }
        //Dinamicko kreiranje textbox-ova
        private TextBox TextBox(int x, int y,int i)
        {
             
            TextBox textBox = new TextBox();
            textBox.Name = "txtBoxPredmet" + i.ToString();
            textBox.Width = 400;
            textBox.Height = 50;
            
            textBox.Font = new Font(textBox.Font.FontFamily, 12);
            textBox.Top = y;
            textBox.Left = x;
            
           
            return textBox;
        }
        //Checkbox semestara
        private CheckBox CheckBox(int x,int y,int i)
        {
            CheckBox checkBoxSemestar = new CheckBox();
            checkBoxSemestar.Font = new Font(checkBoxSemestar.Font.FontFamily, 12);
            checkBoxSemestar.Location = new Point(x, y);
            checkBoxSemestar.Text = i.ToString();
            checkBoxSemestar.Name = "chkBoxSemestar" + i.ToString();
            checkBoxSemestar.CheckedChanged += new EventHandler(CheckedChange);
            
            return checkBoxSemestar;
        }

        //Kreiranje Checkbox predmeta
        private CheckBox CheckBoxPredmeti(int x, int y, int i)
        {
            CheckBox checkBoxPredmet = new CheckBox();
            checkBoxPredmet.Font = new Font(checkBoxPredmet.Font.FontFamily, 12);
            checkBoxPredmet.Location = new Point(x, y);
            checkBoxPredmet.Text = "DA";
            checkBoxPredmet.Name = "chkBoxPredmet" + i.ToString();
            checkBoxPredmet.Checked = false;
            checkBoxPredmet.CheckedChanged += CheckBoxPredmet_CheckedChanged;
            //checkBoxPredmet.MouseClick += new MouseEventHandler(Predmeti_MouseClick);
            
            return checkBoxPredmet;
        }

        //Odredjivanje broja ESPB na osnovu cekiranog predmeta
        private int Dodaj(string izbor)
        {
            
            switch (izbor)
            {
                case "chkBoxPredmet1":
                    int index = int.Parse(izbor.Substring(13, 1));
                    int bodovi = int.Parse(nizLabelaEspbPredmeta[index-1].Text);
                    
                    return bodovi;
                case "chkBoxPredmet2":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet3":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet4":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet5":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet6":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet7":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet8":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet9":
                    index = int.Parse(izbor.Substring(13, 1));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet10":
                    index = int.Parse(izbor.Substring(13, 2));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet11":
                    index = int.Parse(izbor.Substring(13, 2));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet12":
                    index = int.Parse(izbor.Substring(13, 2));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;
                case "chkBoxPredmet13":
                    index = int.Parse(izbor.Substring(13, 2));
                    bodovi = int.Parse(nizLabelaEspbPredmeta[index - 1].Text);

                    return bodovi;

            }
            return 0;
        }
        //Selekcija predmeta cekiranjem predmeta
        private void CheckBoxPredmet_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            
            if (cb.Checked)
            {
                zbirEspb += Dodaj(cb.Name);
                espbZbirPrikaz.Text = zbirEspb.ToString();
            }
            else
            {
                zbirEspb -= Dodaj(cb.Name);
                espbZbirPrikaz.Text = zbirEspb.ToString();
            }
        }

        
        

        //Dugme za predaju izborne liste
        private void ButtonPredajListu(int x, int y)
        {
            Button buttonPredajListu = new Button();
            buttonPredajListu.Location = new Point(xpredaj, ypredaj);
            buttonPredajListu.Font = new Font(buttonPredajListu.Font.FontFamily, 12);
            buttonPredajListu.Size = new Size(235, 35);
            buttonPredajListu.Text = "PREDAJ LISTU";
            buttonPredajListu.Click += new EventHandler(Predaj_Listu_Click);
            this.Controls.Add(buttonPredajListu);


        }

        //Dugme za kreiranje liste
        private void ButtonKreirajListu(int x, int y)
        {
            buttonKreirajListu = new Button();
            buttonKreirajListu.Location = new Point(xkreiraj, ykreiraj);
            buttonKreirajListu.Font = new Font(buttonKreirajListu.Font.FontFamily, 12);
            buttonKreirajListu.Size = new Size(235, 35);
            buttonKreirajListu.Text = "KREIRAJ LISTU";
            buttonKreirajListu.Click += new EventHandler(Kreiraj_Listu_Click);
            this.Controls.Add(buttonKreirajListu);


        }

        //Dugme za izmenu liste
        private void ButtonIzmeniListu(int xizmena, int yizmena)
        {
            buttonIzmeniListu = new Button();
            buttonIzmeniListu.Location = new Point(xizmena, yizmena);
            buttonIzmeniListu.Font = new Font(buttonIzmeniListu.Font.FontFamily, 12);
            buttonIzmeniListu.Size = new Size(235, 35);
            buttonIzmeniListu.Text = "IZMENI LISTU";
            buttonIzmeniListu.Click += ButtonIzmeniListu_Click;
            this.Controls.Add(buttonIzmeniListu);
        }

        private void ButtonIzmeniListu_Click(object sender, EventArgs e)
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

                    var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals("txtBoxPredmet" + brojTextBox.ToString()));
                    var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("chkBoxPredmet" + brojTextBox.ToString()));
                    var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals("lblEspbPredmet" + brojTextBox.ToString()));
                    var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblPredmetID" + brojTextBox.ToString()));

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
                            //zbirEspb -= int.Parse(espb);
                            //espbZbirPrikaz.Text = zbirEspb.ToString();

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

        //Labela za prikaz ESPB poena
        private Label LabelEspbPredmeti(int x, int y, int i)
        {
            Label labela = new Label();
            labela.Location = new Point(x, y);
            
            labela.Font = new Font(labela.Font.FontFamily, 12);
            labela.Name = "lblEspbPredmet" + i.ToString();
            labela.Text = "0";

            return labela;


        }

        //Labela za prikaz naslova za ukupan zbir ESPB poena
        private void LabelEspbPredmetiZbir(int x, int y)
        {
            Label labela = new Label();
            labela.Location = new Point(x, y);

            labela.Font = new Font(labela.Font.FontFamily, 12,FontStyle.Bold);
            labela.Name = "lblEspbPredmetZbir";
            labela.Text = "ESPB:";

            this.Controls.Add(labela);



        }
        //Dinamicko kreiranje labela za prikaz ESPB poena
        private void LabelEspbPredmetiZbirPrikaz(int x, int y)
        {
            espbZbirPrikaz = new Label();
            espbZbirPrikaz.Location = new Point(x, y);

            espbZbirPrikaz.Font = new Font(espbZbirPrikaz.Font.FontFamily, 12, FontStyle.Bold);
            espbZbirPrikaz.Name = "lblEspbPredmetZbirPrikaz";
            espbZbirPrikaz.Text = "0";

            this.Controls.Add(espbZbirPrikaz);



        }


        //Brisanje izborne liste

        void obrisiIzbornuListu()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "DELETE FROM studentskasluzba.izbornalista where izbornalista_student_id= '" + studentID + "';";
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


        //Dogadjaj dugmeta za predaju liste - nakon kreiranja liste ili izmene
        public void Predaj_Listu_Click(object sender, EventArgs e)
        {
            if (zbirEspb >= 48)
            {
                obrisiIzbornuListu();

                
                for (int i = 1; i <= brojPredmeta; i++)
                {
                    var labelID = this.Controls.OfType<Label>();
                    var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblPredmetID" + i.ToString()));
                    if (!labelId.Text.Equals("NOID"))
                    {
                        int pomPredmetID = int.Parse(labelId.Text);
                        var checkBoxes = this.Controls.OfType<CheckBox>();

                        var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("chkBoxPredmet" + i.ToString()));
                        string odabranPredmet;




                        if (checkBoxPredmeti.Checked == true)
                        {
                            odabranPredmet = "DA";
                        }
                        else
                        {
                            odabranPredmet = "NE";
                        }
                        string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
                        string Query = "INSERT INTO studentskasluzba.izbornalista (izbornalista_student_id,izbornalista_predmet_id,izbornalista_izbor) VALUES('" + studentID + "','" + pomPredmetID + "','" + odabranPredmet + "');";
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
                //buttonPredajListu.DataBindings.Control.Enabled = false;

            }
            else
            {
                MessageBox.Show("Da biste predali listu morate imati 48 ESPB poena");
            }
        }

        //Dogadjaj dugmeta za kreiranje liste - dinamicko kreiranje kontrola
        public void Kreiraj_Listu_Click(object sender, EventArgs e)
        {
            brojPredmeta = BrojPredmetaPoSmeru();
            nizTextBoxNazivPredmeta = new TextBox[brojPredmeta];
            nizCheckBoxIzborPredmeta = new CheckBox[brojPredmeta];
            nizLabelaEspbPredmeta = new Label[brojPredmeta];
            nizLabelPredmetID = new Label[brojPredmeta];
            //izbornaLista = new IzbornaLista[brojPredmeta];

            
            for (int i = 0; i < brojPredmeta; i++)
            {
                nizTextBoxNazivPredmeta[i] = TextBox(xtxt, ytxt, i + 1);
                nizCheckBoxIzborPredmeta[i] = CheckBoxPredmeti(xchk, ychk, i + 1);
                CheckBoxPredmeti(xchk, ychk, i + 1);
                nizLabelaEspbPredmeta[i] = LabelEspbPredmeti(xlbl, ylbl, i + 1);
                nizLabelPredmetID[i] = LabelPredmetID(xlblID, ylblID, i + 1);
                //izbornaLista[i] = new IzbornaLista(TextBox(xtxt, ytxt, i + 1), CheckBoxPredmeti(xchk, ychk, i + 1), LabelEspbPredmeti(xlbl, ylbl, i + 1));
                

                ytxt += 35;
                ychk += 35;
                ylbl += 35;
                ylblID += 35;
            }

            //foreach (IzbornaLista izbor in izbornaLista)
            //{
            //    this.Controls.Add(izbor.nazivPredmeta);
            //    this.Controls.Add(izbor.izbor);
            //    this.Controls.Add(izbor.espbPoeni);
            //}
            foreach (TextBox txtPredmeti in nizTextBoxNazivPredmeta)
            {
                this.Controls.Add(txtPredmeti);
            }
            foreach (CheckBox chkPredmeti in nizCheckBoxIzborPredmeta)
            {
                this.Controls.Add(chkPredmeti);
            }
            foreach (Label lblEspbPredmeti in nizLabelaEspbPredmeta)
            {
                this.Controls.Add(lblEspbPredmeti);
            }

            foreach (Label lblPredmetID in nizLabelPredmetID)
            {
                this.Controls.Add(lblPredmetID);
            }

            LabelEspbPredmetiZbir(xlblzbir, ylblzbir);
            LabelEspbPredmetiZbirPrikaz(xlblZbirPrikaz, ylblZbirPrikaz);


            buttonKreirajListu.DataBindings.Control.Enabled = false;
            KreirajListu();
        }

        //Selekcija semestra
        public void CheckedChange(object sender, EventArgs e)
        {
            for(int i = 0; i < nizSemestar.Length; i++)
            {
                if (nizSemestar[i].Checked)
                {
                    if (nizSemestar[i].Text.Equals("1"))
                    {
                        prviSemestar = nizSemestar[i].Text;
                        
                    }
                    if (nizSemestar[i].Text.Equals("2"))
                    {
                        drugiSemestar = nizSemestar[i].Text;
                        
                    }
                    if (nizSemestar[i].Text.Equals("3"))
                    {
                        treciSemestar = nizSemestar[i].Text;
                       
                    }
                    if (nizSemestar[i].Text.Equals("4"))
                    {
                        cetvrtiSemestar = nizSemestar[i].Text;
                        
                    }
                    if (nizSemestar[i].Text.Equals("5"))
                    {
                        petiSemestar = nizSemestar[i].Text;
                        
                    }
                    if (nizSemestar[i].Text.Equals("6"))
                    {
                        sestiSemestar = nizSemestar[i].Text;
                        
                    }
                }
            }
        }

        
        //Punjenje combobox-a smerova
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
                    cmbIzborneListeStudenataSmer.Items.Add(smerNaziv);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            myConn.Close();

        }

        //Punjenje combobox-a studenata na osnovu smera
        void FillComboboxStudentNaOsnovuSmera()
        {
            string studentImePrezime="";
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.student WHERE student_smer_id= '"+smerID+"';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                cmbIzborneListeStudenataStudent.Text = "";
                cmbIzborneListeStudenataStudent.Items.Clear();

                while (myReader.Read())
                {
                    

                    studentID = myReader.GetInt32("student_id");
                    string studentPrezime = myReader.GetString("student_prezime");
                    string studentIme = myReader.GetString("student_ime");
                    studentImePrezime = studentIme + " " + studentPrezime;

                    cmbIzborneListeStudenataStudent.Items.Add(studentImePrezime);
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

        //Prikaz podataka o izbornim listama u DataGridu
        void LoadTable(int studID)
        {
            dataGridViewIzborneListeStudenata.Visible = true;
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            try
            {
                myConn.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT predmet_naziv AS naziv,predmet_espb AS ESPB,izbornalista_izbor FROM studentskasluzba.izbornalista,studentskasluzba.predmet WHERE  izbornalista_student_id='"+studID+"' AND izbornalista_predmet_id=predmet_id AND izbornalista_izbor='DA';", myConn);
                DataTable dbDataSet = new DataTable();
                myDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataSet;
                dataGridViewIzborneListeStudenata.DataSource = bSource;
                myDataAdapter.Update(dbDataSet);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        //Povratak na glavni meni
        private void lnkIzborneListeStudentaLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmStudentskaSluzbaMainMenuAdmin mainForm = new frmStudentskaSluzbaMainMenuAdmin(lblIzborneListeStudenataLoginPrikaz.Text);
            mainForm.Show();
        }

        //Selekcija smera
        private void cmbIzborneListeStudenataSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewIzborneListeStudenata.Visible = false;
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT * FROM  studentskasluzba.smer where smer_naziv = '" + cmbIzborneListeStudenataSmer.Text + "';";
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
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }

            //Pravljenje liste studenata na osnovu odabranog smera

            FillComboboxStudentNaOsnovuSmera();

        }

        //Selekcija studenta za odredjeni smer
        private void cmbIzborneListeStudenataStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string text = cmbIzborneListeStudenataStudent.Text;
            string[] imePrezime = text.Split(' ');

            string Query = "SELECT student_id,student_ime,student_prezime,student_smer_id FROM  studentskasluzba.student,studentskasluzba.smer WHERE student_ime = '" + imePrezime[0] + "' AND student_prezime= '" + imePrezime[1] + "' AND student_smer_id='"+smerID+"' AND student_smer_id = smer_id;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    studentID = myReader.GetInt32("student_id");
                    
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

        //Provera da li postoji izborna lista za studenta
        private bool imaIzbornaListaStudenta(int idStudent)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            int imaLista = 0;

            string Query = "SELECT izbornalista_student_id FROM  studentskasluzba.izbornalista WHERE izbornalista_student_id = '" + idStudent + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    imaLista++;

                }
                if (imaLista > 0)
                {
                    return true;
                }
                myConn.Close();
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
            return false;
        }

        //Racuna broj predmeta na izbornoj listi
        private int BrojPredmetaNaListi()
        {
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT count(izbornalista_predmet_id) AS brojPredmetaNaListi FROM studentskasluzba.izbornalista WHERE izbornalista_student_id= '" + studentID +"';";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;
            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();


                while (myReaderPredmet.Read())
                {

                    brojPredmeta = myReaderPredmet.GetInt32("brojPredmetaNaListi");




                }
                myConnPredmet.Close();
                myReaderPredmet.Close();
                return brojPredmeta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnPredmet.Close();
            }
            return brojPredmeta;
        }
        //Racuna ukupan broj predmeta za odredjeni smer
        private int BrojPredmetaPoSmeru()
        {
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT count(predmet_id) AS brojPredmetaPoSmeru FROM studentskasluzba.smersemestarpredmetprofesor,studentskasluzba.predmet WHERE rel_smer_id= '" + smerID + "' AND (rel_semestar='" + prviSemestar + "' OR rel_semestar='" + drugiSemestar + "' OR rel_semestar='" + treciSemestar + "' OR rel_semestar='" + cetvrtiSemestar + "' OR rel_semestar='" + petiSemestar + "' OR rel_semestar='" + sestiSemestar + "') AND rel_predmet_id=predmet_id ORDER BY rel_semestar;";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;
            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();
                

                while (myReaderPredmet.Read())
                {

                    brojPredmeta = myReaderPredmet.GetInt32("brojPredmetaPoSmeru");
                    



                }
                myConnPredmet.Close();
                myReaderPredmet.Close();
                return brojPredmeta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnPredmet.Close();
            }
            return brojPredmeta;
        }
        
        //Kreiranje izborne liste - koja se unosi prvi put
        private void KreirajListu()
        {
            string myConnection1 = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query1 = "SELECT predmet_id,predmet_naziv,predmet_obavezan,predmet_espb,rel_semestar  FROM studentskasluzba.student,studentskasluzba.smersemestarpredmetprofesor,studentskasluzba.predmet WHERE student_id='" + studentID + "' AND student_smer_id= '" + smerID + "' AND (rel_semestar='" + prviSemestar + "' OR rel_semestar='" + drugiSemestar + "' OR rel_semestar='" + treciSemestar + "' OR rel_semestar='" + cetvrtiSemestar + "' OR rel_semestar='" + petiSemestar + "' OR rel_semestar='" + sestiSemestar + "') AND student_smer_id=rel_smer_id AND rel_predmet_id=predmet_id ORDER BY rel_semestar;";
            MySqlConnection myConnPredmet = new MySqlConnection(myConnection1);
            MySqlCommand SelectCommandPredmet = new MySqlCommand(Query1, myConnPredmet);
            MySqlDataReader myReaderPredmet;
            try
            {

                myConnPredmet.Open();
                myReaderPredmet = SelectCommandPredmet.ExecuteReader();
                int i = 0;
                
                
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

                    var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals(nizTextBoxNazivPredmeta[i].Name));
                    var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals(nizCheckBoxIzborPredmeta[i].Name));
                    var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals(nizLabelaEspbPredmeta[i].Name));
                    var labelPredmetID = labelID.FirstOrDefault<Label>(t => t.Name.Equals(nizLabelPredmetID[i].Name));
                    //MessageBox.Show(izbornaLista[i].nazivPredmeta.Name+""+ izbornaLista[i].izbor.Name+""+ izbornaLista[i].espbPoeni.Name);


                    //var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals(izbornaLista[i].nazivPredmeta.Name));
                    //var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals(izbornaLista[i].izbor.Name));
                    //var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals(izbornaLista[i].espbPoeni.Name));

                    textBox1.Text = predmet;
                    textBox1.DataBindings.Control.Enabled = false;
                    labelPredmeti.Text = espb;
                    labelPredmetID.Text = predmetID.ToString();

                    if (obavezan.Equals("DA"))
                    {
                        
                        checkBoxPredmeti.Checked = true;
                        checkBoxPredmeti.DataBindings.Control.Enabled = false;
                        //zbirEspb += int.Parse(espb);
                        //espbZbirPrikaz.Text = zbirEspb.ToString();


                    }
                    ++i;



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
        //Kreiranje objekata izborne liste
        private void KreiranjeFormeIzborneListe()
        {
            
            brojPredmeta = BrojPredmetaNaListi();
            nizTextBoxNazivPredmeta = new TextBox[brojPredmeta];
            nizCheckBoxIzborPredmeta = new CheckBox[brojPredmeta];
            nizLabelaEspbPredmeta = new Label[brojPredmeta];
            nizLabelPredmetID = new Label[brojPredmeta];
            //izbornaLista = new IzbornaLista[brojPredmeta];


            for (int i = 0; i < brojPredmeta; i++)
            {
                nizTextBoxNazivPredmeta[i] = TextBox(xtxt, ytxt, i + 1);
                nizCheckBoxIzborPredmeta[i] = CheckBoxPredmeti(xchk, ychk, i + 1);
                CheckBoxPredmeti(xchk, ychk, i + 1);
                nizLabelaEspbPredmeta[i] = LabelEspbPredmeti(xlbl, ylbl, i + 1);
                nizLabelPredmetID[i] = LabelPredmetID(xlblID, ylblID, i + 1);
                //izbornaLista[i] = new IzbornaLista(TextBox(xtxt, ytxt, i + 1), CheckBoxPredmeti(xchk, ychk, i + 1), LabelEspbPredmeti(xlbl, ylbl, i + 1));


                ytxt += 35;
                ychk += 35;
                ylbl += 35;
                ylblID += 35;
            }

            //foreach (IzbornaLista izbor in izbornaLista)
            //{
            //    this.Controls.Add(izbor.nazivPredmeta);
            //    this.Controls.Add(izbor.izbor);
            //    this.Controls.Add(izbor.espbPoeni);
            //}
            foreach (TextBox txtPredmeti in nizTextBoxNazivPredmeta)
            {
                this.Controls.Add(txtPredmeti);
            }
            foreach (CheckBox chkPredmeti in nizCheckBoxIzborPredmeta)
            {
                this.Controls.Add(chkPredmeti);
            }
            foreach (Label lblEspbPredmeti in nizLabelaEspbPredmeta)
            {
                this.Controls.Add(lblEspbPredmeti);
            }

            foreach (Label lblPredmetID in nizLabelPredmetID)
            {
                this.Controls.Add(lblPredmetID);
            }

            LabelEspbPredmetiZbir(xlblzbir, ylblzbir);
            LabelEspbPredmetiZbirPrikaz(xlblZbirPrikaz, ylblZbirPrikaz);
            ButtonPredajListu(xpredaj, ypredaj);
            ButtonKreirajListu(xkreiraj, ykreiraj);
            ButtonIzmeniListu(xizmena, yizmena);

            buttonKreirajListu.DataBindings.Control.Enabled = false;
        }
        //Izmena izborne liste - ponovo se pokrece PREDAJ IZBORNU LISTU
        private void IzmenaIzborneListe()
        {
            KreiranjeFormeIzborneListe();

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

                    var textBox1 = textBoxes.FirstOrDefault<TextBox>(t => t.Name.Equals("txtBoxPredmet" + brojTextBox.ToString()));
                    var checkBoxPredmeti = checkBoxes.FirstOrDefault<CheckBox>(t => t.Name.Equals("chkBoxPredmet" + brojTextBox.ToString()));
                    var labelPredmeti = label.FirstOrDefault<Label>(t => t.Name.Equals("lblEspbPredmet" + brojTextBox.ToString()));
                    var labelId = labelID.FirstOrDefault<Label>(t => t.Name.Equals("lblPredmetID" + brojTextBox.ToString()));

                    labelId.Text = predmetID.ToString();
                    labelId.DataBindings.Control.Enabled = false;
                    textBox1.Text = predmet;
                    textBox1.DataBindings.Control.Enabled = false;
                    labelPredmeti.Text = espb;

                    if (obavezan.Equals("DA"))
                    {
                        checkBoxPredmeti.Checked = true;
                        checkBoxPredmeti.DataBindings.Control.Enabled = false;
                        //zbirEspb += int.Parse(espb);
                        //espbZbirPrikaz.Text = zbirEspb.ToString();

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

        //Provera da li je predmet obavezan
        private bool obavezanPredmet(int predmetID)
        {
            
            string obavezanPredmet = "";
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
        //Dogadjaj dugmeta unos izborne liste
        private void btnIzborneListeStudenataUnos_Click(object sender, EventArgs e)
        {
            if(cmbIzborneListeStudenataSmer.Text.Length == 0 || cmbIzborneListeStudenataStudent.Text.Length == 0)
            {
                MessageBox.Show("Odaberite smer i studenta");
            }
            else
            {
                if (imaIzbornaListaStudenta(studentID))
                {
                    DialogResult izmena = MessageBox.Show("Izborna lista postoji.Izmena?", "IZMENA", MessageBoxButtons.YesNo);
                    if (izmena == DialogResult.Yes)
                    {
                        IzmenaIzborneListe();
                    }
                    else if (izmena == DialogResult.No)
                    {
                        LoadTable(studentID);
                    }
                }
                else
                {
                    DialogResult unos = MessageBox.Show("Izborna lista ne postoji.Da li zelite da je unesete?", "UNOS", MessageBoxButtons.YesNo);
                    if (unos == DialogResult.Yes)
                    {
                        int semestar = 6;
                        
                        
                        nizSemestar = new CheckBox[semestar];
                        
                        for (int i = 0; i < semestar; i++)
                        {
                            nizSemestar[i] = CheckBox(x, y,i+1);
                            x += 105;
                            
                        }

                        foreach(CheckBox chk in nizSemestar)
                        {
                            this.Controls.Add(chk);
                        }

                        


                        
                    }
                    else if (unos == DialogResult.No)
                    {
                        //e.Cancel = true;
                    }
                    ButtonPredajListu(600, y + 520);
                    ButtonKreirajListu(900, y + 520);
                }

            }
        }
    }
}
