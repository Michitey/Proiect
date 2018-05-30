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
    public partial class Pagina1 : Form
    {
        public string Locatie { get; set; }
        public string DLivrare { get; set; }
        public string DPredarii { get; set; }
        public Pagina1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pagina1_Load(object sender, EventArgs e)
        {
        }

      

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            Global.Data_Predarii = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Global.Data_Livrarii=monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locatie = comboBox1.Text;
            Global.locatia_livrarii = Locatie;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ( Locatie == "" || Global.Data_Livrarii == "" || Global.Data_Predarii == "")
            {
                MessageBox.Show("Nu ati selectat toate campurile");

            }
            else
            {
                //this.Close();
                Pagina2 s = new Pagina2();
                this.Hide();
                s.ShowDialog();
                this.Close();
            }



        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
