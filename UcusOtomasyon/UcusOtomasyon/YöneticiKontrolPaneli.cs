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
    public partial class YöneticiKontrolPaneli : Form
    {
        public YöneticiKontrolPaneli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelKayitFormu pp = new PersonelKayitFormu();
            pp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme mm=new MusteriGuncelleme();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonGuncelleme rr = new RezervasyonGuncelleme();
            rr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uçuşlar uu=new Uçuşlar();
            uu.Show();
        }
    }
}
