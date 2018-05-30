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

namespace InchirieriAuto
{
    public partial class Pagina3 : Form
    {
        List<string> Marca = new List<string> { "Ford", "Kia", "Audi", "Opel", "Volkswagen", "Audi", "Toyota", "Mercedes" };
        List<string> Model = new List<string> { "Focus", "Picanto", "Q7", "Astra", "Polo", "A7", "RAV4", "GLA" };
        List<string> Transmisie = new List<string> { "Manuala", "Manuala", "Automata", "Manuala", "Manuala", "Automata", "Automata", "Automata" };
        List<string> NrLocuri = new List<string> { "5", "5", "5", "5", "5", "5", "5", "5" };
        List<string> Pret = new List<string> { "20 $/zi", "17 $/zi", "50 $/zi", "22 $/zi", "20 $/zi", "55 $/zi", "45 $/zi", "57 $/zi" };
        List<string> Serie = new List<string> { "40439843", "93702854", "57495839", "17449395", "49358584", "28493759", "10438954", "57385920" };
        public Pagina3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Pagina2 p = new Pagina2();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        public void  imagine( Image i)
        {
            pictureBox1.Image =i;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Pagina4 s = new Pagina4();
            this.Hide();
            s.ShowDialog();
            this.Close();

        }
        
      
        public void Informatii(int Nr)
        {

            
            label7.Text= Marca[Nr];
            label8.Text = Model[Nr];
            label9.Text = Transmisie[Nr];
            label10.Text = NrLocuri[Nr];
            label11.Text =Pret[Nr];
            Global.Serie = Serie[Nr];

        }
       
        private void label7_Click(object sender, EventArgs e)
        {
            
        }

    }
}
