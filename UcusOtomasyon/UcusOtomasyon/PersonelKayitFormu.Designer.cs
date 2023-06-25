namespace UcusOtomasyon
{
    partial class PersonelKayitFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelKayitFormu));
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.PersonelİD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PersonelİseBaslama = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.PersonelDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.PersonelKayıt = new System.Windows.Forms.Button();
            this.PersonelSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonelDogumYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonelTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonelMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonelTC = new System.Windows.Forms.MaskedTextBox();
            this.PersonelAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbUcusDataSetPersonel = new UcusOtomasyon.DbUcusDataSetPersonel();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new UcusOtomasyon.DbUcusDataSetPersonelTableAdapters.PersonelTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iseBaslamaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(197, 703);
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
            this.buttonGuncelle.Location = new System.Drawing.Point(327, 703);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(113, 39);
            this.buttonGuncelle.TabIndex = 31;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // PersonelİD
            // 
            this.PersonelİD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelİD.Location = new System.Drawing.Point(327, 77);
            this.PersonelİD.Name = "PersonelİD";
            this.PersonelİD.Size = new System.Drawing.Size(220, 32);
            this.PersonelİD.TabIndex = 30;
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
            // PersonelİseBaslama
            // 
            this.PersonelİseBaslama.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelİseBaslama.Location = new System.Drawing.Point(327, 568);
            this.PersonelİseBaslama.Name = "PersonelİseBaslama";
            this.PersonelİseBaslama.Size = new System.Drawing.Size(220, 32);
            this.PersonelİseBaslama.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "İşe Başlama Tarihi :";
            // 
            // PersonelDogumTarihi
            // 
            this.PersonelDogumTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelDogumTarihi.Location = new System.Drawing.Point(327, 422);
            this.PersonelDogumTarihi.Name = "PersonelDogumTarihi";
            this.PersonelDogumTarihi.Size = new System.Drawing.Size(220, 32);
            this.PersonelDogumTarihi.TabIndex = 26;
            // 
            // PersonelKayıt
            // 
            this.PersonelKayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonelKayıt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelKayıt.Location = new System.Drawing.Point(452, 703);
            this.PersonelKayıt.Name = "PersonelKayıt";
            this.PersonelKayıt.Size = new System.Drawing.Size(113, 39);
            this.PersonelKayıt.TabIndex = 25;
            this.PersonelKayıt.Text = "Kaydet";
            this.PersonelKayıt.UseVisualStyleBackColor = false;
            this.PersonelKayıt.Click += new System.EventHandler(this.PersonelKayıt_Click);
            // 
            // PersonelSifre
            // 
            this.PersonelSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelSifre.Location = new System.Drawing.Point(327, 636);
            this.PersonelSifre.Name = "PersonelSifre";
            this.PersonelSifre.Size = new System.Drawing.Size(220, 32);
            this.PersonelSifre.TabIndex = 24;
            this.PersonelSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(192, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Şifre:";
            // 
            // PersonelDogumYeri
            // 
            this.PersonelDogumYeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelDogumYeri.Location = new System.Drawing.Point(327, 492);
            this.PersonelDogumYeri.Name = "PersonelDogumYeri";
            this.PersonelDogumYeri.Size = new System.Drawing.Size(220, 32);
            this.PersonelDogumYeri.TabIndex = 22;
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
            // PersonelTelefon
            // 
            this.PersonelTelefon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelTelefon.Location = new System.Drawing.Point(327, 353);
            this.PersonelTelefon.Name = "PersonelTelefon";
            this.PersonelTelefon.Size = new System.Drawing.Size(220, 32);
            this.PersonelTelefon.TabIndex = 18;
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
            // PersonelMail
            // 
            this.PersonelMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelMail.Location = new System.Drawing.Point(327, 282);
            this.PersonelMail.Name = "PersonelMail";
            this.PersonelMail.Size = new System.Drawing.Size(220, 32);
            this.PersonelMail.TabIndex = 16;
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
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            // 
            // PersonelTC
            // 
            this.PersonelTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelTC.Location = new System.Drawing.Point(327, 140);
            this.PersonelTC.Mask = "00000000000";
            this.PersonelTC.Name = "PersonelTC";
            this.PersonelTC.Size = new System.Drawing.Size(220, 32);
            this.PersonelTC.TabIndex = 14;
            this.PersonelTC.ValidatingType = typeof(int);
            // 
            // PersonelAd
            // 
            this.PersonelAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAd.Location = new System.Drawing.Point(327, 208);
            this.PersonelAd.Name = "PersonelAd";
            this.PersonelAd.Size = new System.Drawing.Size(220, 32);
            this.PersonelAd.TabIndex = 13;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.PersonelİD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PersonelİseBaslama);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PersonelDogumTarihi);
            this.groupBox1.Controls.Add(this.PersonelKayıt);
            this.groupBox1.Controls.Add(this.PersonelSifre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PersonelDogumYeri);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PersonelTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PersonelMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PersonelTC);
            this.groupBox1.Controls.Add(this.PersonelAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Location = new System.Drawing.Point(48, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 791);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3844, 1056);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.iseBaslamaTarihDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(874, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 800);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbUcusDataSetPersonel
            // 
            this.dbUcusDataSetPersonel.DataSetName = "DbUcusDataSetPersonel";
            this.dbUcusDataSetPersonel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.dbUcusDataSetPersonel;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
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
            // iseBaslamaTarihDataGridViewTextBoxColumn
            // 
            this.iseBaslamaTarihDataGridViewTextBoxColumn.DataPropertyName = "İseBaslamaTarih";
            this.iseBaslamaTarihDataGridViewTextBoxColumn.HeaderText = "İseBaslamaTarih";
            this.iseBaslamaTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iseBaslamaTarihDataGridViewTextBoxColumn.Name = "iseBaslamaTarihDataGridViewTextBoxColumn";
            this.iseBaslamaTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // PersonelKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1056);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonelKayitFormu";
            this.Text = "PersonelKayitFormu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelKayitFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox PersonelİD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker PersonelİseBaslama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker PersonelDogumTarihi;
        private System.Windows.Forms.Button PersonelKayıt;
        private System.Windows.Forms.TextBox PersonelSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PersonelDogumYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PersonelTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PersonelMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private System.Windows.Forms.MaskedTextBox PersonelTC;
        private System.Windows.Forms.TextBox PersonelAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbUcusDataSetPersonel dbUcusDataSetPersonel;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private DbUcusDataSetPersonelTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iseBaslamaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
    }
}