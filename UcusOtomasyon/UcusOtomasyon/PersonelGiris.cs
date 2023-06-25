using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusOtomasyon
{
    public partial class PersonelGiris : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public PersonelGiris()
        {
            InitializeComponent();
        }
        private void YöneticiGir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From Personel where TC=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", PersonelTC.Text);
            komut.Parameters.AddWithValue("@p2", PersonelSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                PersonelYönetimEkranı pym = new PersonelYönetimEkranı();
                pym.Show();
            }
            else
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz");
                PersonelTC.Clear();
                PersonelSifre.Clear();

            }

            bgl.baglanti().Close();
        }
    }
}
