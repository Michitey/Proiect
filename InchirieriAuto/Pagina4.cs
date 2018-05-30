using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministrareClienti;
using StocareDate;
using System.Configuration;
using System.Collections.Generic;


namespace InchirieriAuto
{
    public partial class Pagina4 : Form
    {
        IStocareData stocareFizicaDate;
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        List<Client> clienti = new List<Client>();
        public Pagina4()
        {
            this.Height = 670;
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagina2 s = new Pagina2();
            Pagina3 p = new Pagina3();
            p.imagine(s.Img);

            p.Informatii(Global.Numar);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        
        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtCNP.Text = txtNrTelefon.Text = txtEMail.Text = string.Empty;

        }
        public void AdaugaClientInlistBox1(Client c)
        {

            listBox1.Items.Add(c.ConversieLaSir());

        }
        private void ReincarcaClientiInlistBox1(ListBox q)
        {
            listBox1.Items.Clear();
            foreach (Client c in clienti)
            {
                AdaugaClientInlistBox1(c);
            }
        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pagina4_Load(object sender, EventArgs e)
        {

        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNrTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (txtNume.Text == "" || txtPrenume.Text == "" || txtCNP.Text == "" || txtNrTelefon.Text == "" || txtEMail.Text == "")
            {
                MessageBox.Show("Campuri necompletate");
                Global.Nr = 0;
            }
            else
            {
                this.Height = 750;
                Pagina1 x = new Pagina1();
                Client c = new Client(txtNume.Text, txtPrenume.Text, txtCNP.Text, txtNrTelefon.Text, txtEMail.Text,Global.Serie, Global.locatia_livrarii, Global.Data_Livrarii, Global.Data_Predarii);
                clienti.Add(c);
                ResetareControale();
                Global.Nr = 1;
                AdaugaClientInlistBox1(c);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            //stocareFizicaDate.AddClienti(c);

            if (Global.Nr==0)
            {
                MessageBox.Show("Nu ati introdus datele dumneavoastra");
            }
            else
            {

                Pagina5 q = new Pagina5();
                this.Hide();
                q.ShowDialog();
                this.Close();
                
            }


        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
