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
    public partial class Rezervasyon : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        public Rezervasyon()
        {
            InitializeComponent();
        }

       

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbUcusDataSet.Ucuslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucuslarTableAdapter.Fill(this.dbUcusDataSet.Ucuslar);

        }


        private void Kayıt_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KoltukNo.Text = "A - 1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "A - 2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "A - 3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "A - 4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "A - 5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "B - 1";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "B - 2";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "B - 3";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "B - 4";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "B - 5";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "C - 1";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "C - 2";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "C - 3";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "C - 4";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "C - 5";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "D - 1";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "D - 2";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "D - 3";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "D - 4";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "D - 5";
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "E - 1";
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "E - 2";
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "E - 3";
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "E - 4";
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            KoltukNo.Text = "E - 5";
        }

        private void Kayıt_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Rezervasyon (TC,AdSoyad,EMail,Telefon,Nereden,Nereye,Tarih,KalkısSaati,VarisSaati,Fiyat,KoltukNumarasi) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", MusteriTC.Text);
                komutkaydet.Parameters.AddWithValue("@d2", MusteriAd.Text);
                komutkaydet.Parameters.AddWithValue("@d3", MusteriMail.Text);
                komutkaydet.Parameters.AddWithValue("@d4", MusteriTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@d5", Neredenn.Text);
                komutkaydet.Parameters.AddWithValue("@d6", Nereyee.Text);
                komutkaydet.Parameters.AddWithValue("@d7", UcusTarih.Text);
                komutkaydet.Parameters.AddWithValue("@d8", KalkisSaat.Text);
                komutkaydet.Parameters.AddWithValue("@d9", İnisSaat.Text);
                komutkaydet.Parameters.AddWithValue("@d10",BiletFiyat.Text);
                komutkaydet.Parameters.AddWithValue("@d11",KoltukNo.Text);
                komutkaydet.ExecuteNonQuery();
                this.ucuslarTableAdapter.Fill(this.dbUcusDataSet.Ucuslar);
                bgl.baglanti().Close();
                MessageBox.Show("Rezervasyonunuz başarıyla kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz");
                MusteriTC.Clear();
                MusteriAd.Clear();
                MusteriMail.Clear();
                MusteriTelefon.Clear();
                

            }
        }
    }
}
