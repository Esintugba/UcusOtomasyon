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
    public partial class PersonelKayitFormu : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, tc, adsoyad, mail, telefon, dogumtarihi, dogumyeri, isebaslamatarih, sifre;


        public PersonelKayitFormu()
        {
            InitializeComponent();
        }

        private void PersonelKayitFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbUcusDataSetPersonel.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.dbUcusDataSetPersonel.Personel);

        }

        private void PersonelKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Personel (TC,AdSoyad,EMail,Telefon,DogumTarihi,DogumYeri,İseBaslamaTarih,Sifre) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", PersonelTC.Text);
                komutkaydet.Parameters.AddWithValue("@d2", PersonelAd.Text);
                komutkaydet.Parameters.AddWithValue("@d3", PersonelMail.Text);
                komutkaydet.Parameters.AddWithValue("@d4", PersonelTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@d5", PersonelDogumTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@d6", PersonelDogumYeri.Text);
                komutkaydet.Parameters.AddWithValue("@d7", PersonelİseBaslama.Text);
                komutkaydet.Parameters.AddWithValue("@d8", PersonelSifre.Text);
                komutkaydet.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dbUcusDataSetPersonel.Personel);
                bgl.baglanti().Close();
                MessageBox.Show("Personel başarıyla kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz");
                PersonelTC.Clear();
                PersonelAd.Clear();
                PersonelMail.Clear();
                PersonelTelefon.Clear();
                PersonelDogumYeri.Clear();
                PersonelSifre.Clear();

            }
        }


        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("Update Personel set TC=@t2,AdSoyad=@t3,EMail=@t4,Telefon=@t5,DogumTarihi=@t6,DogumYeri=@t7,İseBaslamaTarih=@t8,Sifre=@t9 where ID=@t1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@t1", PersonelİD.Text);
                komutguncelle.Parameters.AddWithValue("@t2", PersonelTC.Text);
                komutguncelle.Parameters.AddWithValue("@t3", PersonelAd.Text);
                komutguncelle.Parameters.AddWithValue("@t4", PersonelMail.Text);
                komutguncelle.Parameters.AddWithValue("@t5", PersonelTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@t6", PersonelDogumTarihi.Text);
                komutguncelle.Parameters.AddWithValue("@t7", PersonelDogumYeri.Text);
                komutguncelle.Parameters.AddWithValue("@t8", PersonelİseBaslama.Text);
                komutguncelle.Parameters.AddWithValue("@t9", PersonelSifre.Text);
                komutguncelle.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dbUcusDataSetPersonel.Personel);
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
                SqlCommand komutsil = new SqlCommand("delete from Personel where ID=@e1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@e1", PersonelİD.Text);
                komutsil.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dbUcusDataSetPersonel.Personel);
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
            string id, tc, adsoyad, mail, telefon, dogumtarihi, dogumyeri, isebaslamatarih, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adsoyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dogumtarihi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dogumyeri = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            isebaslamatarih = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[8].Value.ToString();


            PersonelİD.Text = id;
            PersonelTC.Text = tc;
            PersonelAd.Text = adsoyad;
            PersonelMail.Text = mail;
            PersonelTelefon.Text = telefon;
            PersonelDogumTarihi.Text = dogumtarihi;
            PersonelDogumYeri.Text = dogumyeri;
            PersonelİseBaslama.Text = isebaslamatarih;
            PersonelSifre.Text = sifre;
        }

    }


}
