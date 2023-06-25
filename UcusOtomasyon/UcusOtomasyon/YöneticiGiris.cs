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
    public partial class YöneticiGiris : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public YöneticiGiris()
        {
            InitializeComponent();
        }


        private void YöneticiGir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From Yönetici where TC=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", YöneticiTC.Text);
            komut.Parameters.AddWithValue("@p2", YöneticiSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                YöneticiKontrolPaneli yp = new YöneticiKontrolPaneli();
                yp.Show();
            }
            else
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz");
                YöneticiTC.Clear();
                YöneticiSifre.Clear();

            }

            bgl.baglanti().Close();
        }

        private void YöneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
