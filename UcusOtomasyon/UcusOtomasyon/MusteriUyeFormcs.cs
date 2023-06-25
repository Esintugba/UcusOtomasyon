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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UcusOtomasyon
{
    public partial class MusteriUyeFormcs : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, tc, adsoyad, mail, telefon, dogumtarihi, dogumyeri,sifre;

        public MusteriUyeFormcs()
        {
            InitializeComponent();
        }
        private void MusteriUye_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Musteri (TC,AdSoyad,EMail,Telefon,DogumTarihi,DogumYeri,Sifre) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", MusteriTC.Text);
                komutkaydet.Parameters.AddWithValue("@d2", MusteriAd.Text);
                komutkaydet.Parameters.AddWithValue("@d3", MusteriMail.Text);
                komutkaydet.Parameters.AddWithValue("@d4", MusteriTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@d5", MusteriDogumTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@d6", MusteriDogumYeri.Text);
                komutkaydet.Parameters.AddWithValue("@d7", MusteriSifre.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Üyeliğiniz başarıyla oluşturuldu.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz");
                MusteriTC.Clear();
                MusteriAd.Clear();
                MusteriMail.Clear();
                MusteriTelefon.Clear();
                MusteriDogumYeri.Clear();
                MusteriSifre.Clear();
               

            }


        }
    }


}
