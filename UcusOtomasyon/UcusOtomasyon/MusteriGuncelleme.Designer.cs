namespace UcusOtomasyon
{
    partial class MusteriGuncelleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelleme));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.MusteriİD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MusteriDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.PersonelKayıt = new System.Windows.Forms.Button();
            this.MusteriSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MusteriDogumYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MusteriTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MusteriMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.MusteriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUcusDataSetMusteri = new UcusOtomasyon.DbUcusDataSetMusteri();
            this.musteriTableAdapter = new UcusOtomasyon.DbUcusDataSetMusteriTableAdapters.MusteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1055);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.MusteriİD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MusteriDogumTarihi);
            this.groupBox1.Controls.Add(this.PersonelKayıt);
            this.groupBox1.Controls.Add(this.MusteriSifre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MusteriDogumYeri);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MusteriTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MusteriMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MusteriTC);
            this.groupBox1.Controls.Add(this.MusteriAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Location = new System.Drawing.Point(113, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 742);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(197, 640);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(113, 39);
            this.buttonSil.TabIndex = 32;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(327, 640);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(113, 39);
            this.buttonGuncelle.TabIndex = 31;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // MusteriİD
            // 
            this.MusteriİD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriİD.Location = new System.Drawing.Point(327, 77);
            this.MusteriİD.Name = "MusteriİD";
            this.MusteriİD.Size = new System.Drawing.Size(220, 32);
            this.MusteriİD.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(210, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID :";
            // 
            // MusteriDogumTarihi
            // 
            this.MusteriDogumTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriDogumTarihi.Location = new System.Drawing.Point(327, 422);
            this.MusteriDogumTarihi.Name = "MusteriDogumTarihi";
            this.MusteriDogumTarihi.Size = new System.Drawing.Size(220, 32);
            this.MusteriDogumTarihi.TabIndex = 26;
            // 
            // PersonelKayıt
            // 
            this.PersonelKayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonelKayıt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelKayıt.Location = new System.Drawing.Point(452, 640);
            this.PersonelKayıt.Name = "PersonelKayıt";
            this.PersonelKayıt.Size = new System.Drawing.Size(113, 39);
            this.PersonelKayıt.TabIndex = 25;
            this.PersonelKayıt.Text = "Kaydet";
            this.PersonelKayıt.UseVisualStyleBackColor = false;
            this.PersonelKayıt.Click += new System.EventHandler(this.PersonelKayıt_Click);
            // 
            // MusteriSifre
            // 
            this.MusteriSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriSifre.Location = new System.Drawing.Point(327, 563);
            this.MusteriSifre.Name = "MusteriSifre";
            this.MusteriSifre.Size = new System.Drawing.Size(220, 32);
            this.MusteriSifre.TabIndex = 24;
            this.MusteriSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(192, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Şifre:";
            // 
            // MusteriDogumYeri
            // 
            this.MusteriDogumYeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriDogumYeri.Location = new System.Drawing.Point(327, 496);
            this.MusteriDogumYeri.Name = "MusteriDogumYeri";
            this.MusteriDogumYeri.Size = new System.Drawing.Size(220, 32);
            this.MusteriDogumYeri.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(121, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Doğum Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // MusteriTelefon
            // 
            this.MusteriTelefon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTelefon.Location = new System.Drawing.Point(327, 353);
            this.MusteriTelefon.Name = "MusteriTelefon";
            this.MusteriTelefon.Size = new System.Drawing.Size(220, 32);
            this.MusteriTelefon.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon No:";
            // 
            // MusteriMail
            // 
            this.MusteriMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriMail.Location = new System.Drawing.Point(327, 282);
            this.MusteriMail.Name = "MusteriMail";
            this.MusteriMail.Size = new System.Drawing.Size(220, 32);
            this.MusteriMail.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "E-Mail : ";
            // 
            // MusteriTC
            // 
            this.MusteriTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTC.Location = new System.Drawing.Point(327, 140);
            this.MusteriTC.Mask = "00000000000";
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.Size = new System.Drawing.Size(220, 32);
            this.MusteriTC.TabIndex = 14;
            this.MusteriTC.ValidatingType = typeof(int);
            // 
            // MusteriAd
            // 
            this.MusteriAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAd.Location = new System.Drawing.Point(327, 208);
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.Size = new System.Drawing.Size(220, 32);
            this.MusteriAd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad-Soyad :";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(204, 140);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(50, 28);
            this.lblMusteriID.TabIndex = 11;
            this.lblMusteriID.Text = "T.C :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.dogumYeriDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(933, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 742);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumYeriDataGridViewTextBoxColumn
            // 
            this.dogumYeriDataGridViewTextBoxColumn.DataPropertyName = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.HeaderText = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumYeriDataGridViewTextBoxColumn.Name = "dogumYeriDataGridViewTextBoxColumn";
            this.dogumYeriDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.dbUcusDataSetMusteri;
            // 
            // dbUcusDataSetMusteri
            // 
            this.dbUcusDataSetMusteri.DataSetName = "DbUcusDataSetMusteri";
            this.dbUcusDataSetMusteri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // MusteriGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusteriGuncelleme";
            this.Text = "Müşteri Bilgileri Güncelleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox MusteriİD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker MusteriDogumTarihi;
        private System.Windows.Forms.Button PersonelKayıt;
        private System.Windows.Forms.TextBox MusteriSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MusteriDogumYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MusteriTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MusteriMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MusteriTC;
        private System.Windows.Forms.TextBox MusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbUcusDataSetMusteri dbUcusDataSetMusteri;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private DbUcusDataSetMusteriTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
    }
}