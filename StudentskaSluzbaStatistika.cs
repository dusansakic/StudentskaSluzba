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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace StudentskaSluzba
{
    public partial class frmStudentskaSluzbaStatistika : Form
    {
        public frmStudentskaSluzbaStatistika(string mainUser)
        {
            InitializeComponent();
            lblStatistikaLoginPrikaz.Text = mainUser;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string myConnection = "datasource=localhost;port=3306;username=root;password=Fil2105ozof!";
            string Query = "SELECT count(student_id) as BrojStudenata, smer_mnemo as smer FROM studentskasluzba.student,studentskasluzba.smer WHERE student_smer_id = smer_id GROUP BY smer_mnemo;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    this.chartStatistikaSmerStudent.Series["Smer"].Points.AddXY(myReader.GetString("smer"),myReader.GetInt32("BrojStudenata") );


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

        private void linkStatistikaLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (lblStatistikaLoginPrikaz.Text.Equals("GOST"))
            {
                this.Visible = false;
                frmStudentskaSluzbaLogin mainForm = new frmStudentskaSluzbaLogin();
                mainForm.Show();
            }
            else if (lblStatistikaLoginPrikaz.Text.Equals("ADMIN"))
            {
                this.Visible = false;
                frmStudentskaSluzbaMainMenuAdmin mainForm = new frmStudentskaSluzbaMainMenuAdmin(lblStatistikaLoginPrikaz.Text);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Greska u logovanju");
                this.Visible = false;
                frmStudentskaSluzbaLogin mainForm = new frmStudentskaSluzbaLogin();
                mainForm.Show();

            }
            
        }

        private void btnStatistikaKreirajPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            PdfWriter wri = PdfWriter.GetInstance(doc,new FileStream("Test.pdf",FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Ovo je moj prvi paragraph\nHello....");
            doc.Add(paragraph);
            doc.Close();
            System.Diagnostics.Process.Start("D:\\Studiranje_Daljina\\Treca_Godina\\Vizuelno_Programiranje\\1_Projekat\\StudentskaSluzba\\StudentskaSluzba\\bin\\Debug\\Test.pdf");

        }
    }
}
