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
    public partial class MusteriGuncelleme : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, tc, adsoyad, mail, telefon, dogumtarihi, dogumyeri, sifre;

        

        public MusteriGuncelleme()
        {
            InitializeComponent();
        }

        private void MusteriGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbUcusDataSetMusteri.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.dbUcusDataSetMusteri.Musteri);

        }
        
        private void PersonelKayıt_Click(object sender, EventArgs e)
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
                this.musteriTableAdapter.Fill(this.dbUcusDataSetMusteri.Musteri);
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri başarıyla kaydedildi.");
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


        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("Update Musteri set TC=@t2,AdSoyad=@t3,EMail=@t4,Telefon=@t5,DogumTarihi=@t6,DogumYeri=@t7,Sifre=@t8 where ID=@t1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@t1", MusteriİD.Text);
                komutguncelle.Parameters.AddWithValue("@t2", MusteriTC.Text);
                komutguncelle.Parameters.AddWithValue("@t3", MusteriAd.Text);
                komutguncelle.Parameters.AddWithValue("@t4", MusteriMail.Text);
                komutguncelle.Parameters.AddWithValue("@t5", MusteriTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@t6", MusteriDogumTarihi.Text);
                komutguncelle.Parameters.AddWithValue("@t7", MusteriDogumYeri.Text);
                komutguncelle.Parameters.AddWithValue("@t8", MusteriSifre.Text);
                komutguncelle.ExecuteNonQuery();
                this.musteriTableAdapter.Fill(this.dbUcusDataSetMusteri.Musteri);
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar Deneyin.");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Musteri where ID=@e1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@e1", MusteriİD.Text);
                komutsil.ExecuteNonQuery();
                this.musteriTableAdapter.Fill(this.dbUcusDataSetMusteri.Musteri);
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, tc, adsoyad, mail, telefon, dogumtarihi, dogumyeri, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adsoyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dogumtarihi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dogumyeri = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


            MusteriİD.Text = id;
            MusteriTC.Text = tc;
            MusteriAd.Text = adsoyad;
            MusteriMail.Text = mail;
            MusteriTelefon.Text = telefon;
            MusteriDogumTarihi.Text = dogumtarihi;
            MusteriDogumYeri.Text = dogumyeri;
            MusteriSifre.Text = sifre;
        }
    }
}
