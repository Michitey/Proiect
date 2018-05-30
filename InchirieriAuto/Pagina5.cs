using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchirieriAuto
{
    public partial class Pagina5 : Form
    {
        public Pagina5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagina1 p = new Pagina1();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Pagina5_Load(object sender, EventArgs e)
        {

        }
    }
}
