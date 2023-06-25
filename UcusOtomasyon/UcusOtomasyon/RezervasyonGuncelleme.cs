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
    public partial class RezervasyonGuncelleme : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, tc, ad, mail, telefon, nereden, nereye, tarih, kalkissaat, varissaat, fiyat, koltukno;

        
        public RezervasyonGuncelleme()
        {
            InitializeComponent();
        }

        private void RezervasyonGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbUcusDataSetRezervasyon.Rezervasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonTableAdapter.Fill(this.dbUcusDataSetRezervasyon.Rezervasyon);

        }

        private void PersonelKayıt_Click(object sender, EventArgs e)
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
                komutkaydet.Parameters.AddWithValue("@d10", BiletFiyat.Text);
                komutkaydet.Parameters.AddWithValue("@d11", KoltukNo.Text);
                komutkaydet.ExecuteNonQuery();
                this.rezervasyonTableAdapter.Fill(this.dbUcusDataSetRezervasyon.Rezervasyon);
                bgl.baglanti().Close();
                MessageBox.Show("Rezervasyon başarıyla kaydedildi.");
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
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("Update Rezervasyon set TC=@t2,AdSoyad=@t3,EMail=@t4,Telefon=@t5,Nereden=@t6,Nereye=@t7,Tarih=@t8,KalkısSaati=@t9,VarisSaati=@t10,Fiyat=@t11,KoltukNumarasi=@t12 where ID=@t1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@t1", RezervasyonİD.Text);
                komutguncelle.Parameters.AddWithValue("@t2", MusteriTC.Text);
                komutguncelle.Parameters.AddWithValue("@t3", MusteriAd.Text);
                komutguncelle.Parameters.AddWithValue("@t4", MusteriMail.Text);
                komutguncelle.Parameters.AddWithValue("@t5", MusteriTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@d5", Neredenn.Text);
                komutguncelle.Parameters.AddWithValue("@d6", Nereyee.Text);
                komutguncelle.Parameters.AddWithValue("@d7", UcusTarih.Text);
                komutguncelle.Parameters.AddWithValue("@d8", KalkisSaat.Text);
                komutguncelle.Parameters.AddWithValue("@d9", İnisSaat.Text);
                komutguncelle.Parameters.AddWithValue("@d10", BiletFiyat.Text);
                komutguncelle.Parameters.AddWithValue("@d11", KoltukNo.Text);
                komutguncelle.ExecuteNonQuery();
                this.rezervasyonTableAdapter.Fill(this.dbUcusDataSetRezervasyon.Rezervasyon);
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
                SqlCommand komutsil = new SqlCommand("delete from Rezervasyon where ID=@e1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@e1", RezervasyonİD.Text);
                komutsil.ExecuteNonQuery();
                this.rezervasyonTableAdapter.Fill(this.dbUcusDataSetRezervasyon.Rezervasyon);
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
            string id, tc, ad, mail, telefon, nereden, nereye, tarih, kalkissaat, varissaat, fiyat, koltukno;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            nereden = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            nereye = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tarih = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            kalkissaat = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            varissaat = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fiyat = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            koltukno = dataGridView1.Rows[secilen].Cells[11].Value.ToString();


            RezervasyonİD.Text = id;
            MusteriTC.Text = tc;
            MusteriAd.Text = ad;
            MusteriMail.Text = mail;
            MusteriTelefon.Text = telefon;
            Neredenn.Text = nereden;
            Nereyee.Text = nereye;
            UcusTarih.Text = tarih;
            KalkisSaat.Text = kalkissaat;
            İnisSaat.Text = varissaat;
            BiletFiyat.Text = fiyat;
            KoltukNo.Text = koltukno;
        }

    }
}
