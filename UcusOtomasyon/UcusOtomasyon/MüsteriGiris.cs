using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UcusOtomasyon
{
    public partial class MüsteriGiris : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public MüsteriGiris()
        {
            InitializeComponent();
        }
        private void YöneticiGir_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select*From Musteri where TC=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MusteriTC.Text);
            komut.Parameters.AddWithValue("@p2", MusteriSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                Rezervasyon mp = new Rezervasyon();
                mp.Show();
            }
            else
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz");
               MusteriTC.Clear();
               MusteriSifre.Clear();

            }

            bgl.baglanti().Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MusteriUyeFormcs mf = new MusteriUyeFormcs ();
            mf.Show();
        }
    }
}
