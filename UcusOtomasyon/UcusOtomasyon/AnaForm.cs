using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusOtomasyon
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            YöneticiGiris yy = new YöneticiGiris();
            yy.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MüsteriGiris mm = new MüsteriGiris();
            mm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PersonelGiris pp = new PersonelGiris();
            pp.Show();
        }
    }
}
