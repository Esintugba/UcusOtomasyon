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
    public partial class Uçuşlar : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, ucakno, nereden, nereye, ucustarih, kalkissaati, inissaati, fiyat;

        

        public Uçuşlar()
        {
            InitializeComponent();
        }

        private void Uçuşlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbUcusDataSetUcus.Ucuslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucuslarTableAdapter.Fill(this.dbUcusDataSetUcus.Ucuslar);

        }

        private void Kayıt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Ucuslar (UcakNo,Nereden,Nereye,UcusTarihi,KalkisSaati,VarisSaati,BiletFiyat) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", UcusNo.Text);
                komutkaydet.Parameters.AddWithValue("@d2", Neredenn.Text);
                komutkaydet.Parameters.AddWithValue("@d3", Nereyee.Text);
                komutkaydet.Parameters.AddWithValue("@d4", UcusTarih.Text);
                komutkaydet.Parameters.AddWithValue("@d5", KalkisSaati.Text);
                komutkaydet.Parameters.AddWithValue("@d6", İnisSaati.Text);
                komutkaydet.Parameters.AddWithValue("@d7", BiletFiyati.Text);
                komutkaydet.ExecuteNonQuery();
                this.ucuslarTableAdapter.Fill(this.dbUcusDataSetUcus.Ucuslar);
                bgl.baglanti().Close();
                MessageBox.Show("Uçuş bilgileri başarıyla kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz");
                UcusNo.Clear();
                KalkisSaati.Clear();
                İnisSaati.Clear();
                BiletFiyati.Clear();

            }
        }


        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komutguncelle = new SqlCommand("Update Ucuslar set UcakNo=@t2,Nereden=@t3,Nereye=@t4,UcusTarihi=@t5,KalkisSaati=@t6,VarisSaati=@t7,BiletFiyat=@t8 where ID=@t1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@t1", UcusİD.Text);
                komutguncelle.Parameters.AddWithValue("@t2", UcusNo.Text);
                komutguncelle.Parameters.AddWithValue("@t3", Neredenn.Text);
                komutguncelle.Parameters.AddWithValue("@t4", Nereyee.Text);
                komutguncelle.Parameters.AddWithValue("@t5", UcusTarih.Text);
                komutguncelle.Parameters.AddWithValue("@t6", KalkisSaati.Text);
                komutguncelle.Parameters.AddWithValue("@t7", İnisSaati.Text);
                komutguncelle.Parameters.AddWithValue("@t8", BiletFiyati.Text);
                komutguncelle.ExecuteNonQuery();
                this.ucuslarTableAdapter.Fill(this.dbUcusDataSetUcus.Ucuslar);
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
                SqlCommand komutsil = new SqlCommand("delete from Ucuslar where ID=@e1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@e1", UcusİD.Text);
                komutsil.ExecuteNonQuery();
                this.ucuslarTableAdapter.Fill(this.dbUcusDataSetUcus.Ucuslar);
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
            string id, ucakno, nereden, nereye, ucustarih, kalkissaati, inissaati, fiyat;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ucakno = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            nereden = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            nereye = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ucustarih = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            kalkissaati = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            inissaati = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fiyat = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


            UcusİD.Text = id;
            UcusNo.Text = ucakno;
            Neredenn.Text = nereden;
            Nereyee.Text = nereye;
            UcusTarih.Text = ucustarih;
            KalkisSaati.Text = kalkissaati;
            İnisSaati.Text = inissaati;
            BiletFiyati.Text = fiyat;

        }

    }
}
