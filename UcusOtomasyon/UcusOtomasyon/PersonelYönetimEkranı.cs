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
    public partial class PersonelYönetimEkranı : Form
    {
        public PersonelYönetimEkranı()
        {
            InitializeComponent();
        }

        private void PersonelYönetimEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme mg=new MusteriGuncelleme();
            mg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonGuncelleme rg = new RezervasyonGuncelleme();
            rg.Show();
        }
    }
}
