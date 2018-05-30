using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using AdministrareClienti;


namespace InchirieriAuto
{
    public partial class Pagina2 : Form 
    {
        public  Image Img { get; set; }
        public string marca { get; set; }
        Pagina3 s = new Pagina3();
        Pagina1 p = new Pagina1();
        public int Nr { get; set; }
        public Pagina2()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
           
            Img = Resource1.FordFocus;
            
            s.imagine(Img);
            s.Informatii(0);
            Global.Numar = 0;
            this.Hide();
            s.ShowDialog();
            this.Close();
            
            

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Img = Resource1.KiaPicanto;
            s.imagine(Img);
            s.Informatii(1);
            Global.Numar = 1;
            this.Hide();
            s.ShowDialog();
            this.Close();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Img = Resource1.AudiQ7;
            s.Informatii(2);
            Global.Numar = 2;
            s.imagine(Img);
            this.Hide();
            s.ShowDialog();
            this.Close();
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Img = Resource1.OpelAstra;
            s.imagine(Img);
            Global.Numar = 3;
            s.Informatii(3);
            this.Hide();
            s.ShowDialog();
            this.Close();
           
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Img = Resource1.VolkswagenPolo;
            s.imagine(Img);
            s.Informatii(4);
            Global.Numar = 4;
            this.Hide();
            s.ShowDialog();
            this.Close();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Img = Resource1.AudiA7;
            s.imagine(Img);
            s.Informatii(5);
            Global.Numar = 5;
            this.Hide();
            s.ShowDialog();
            this.Close();
            Nr = 6;
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Img = Resource1.Toyota_RAV4;
            s.imagine(Img);
            s.Informatii(6);
            Global.Numar = 6;
            this.Hide();
            s.ShowDialog();
            this.Close();
            Nr = 7;
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Img = Resource1.MercedesGLA;
            s.imagine(Img);
            s.Informatii(7);
            Global.Numar = 7;
            this.Hide();
            s.ShowDialog();
            this.Close();
            Nr = 8;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void Pagina2_Load(object sender, EventArgs e)
        {

            
        }
    }
}
