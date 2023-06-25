namespace UcusOtomasyon
{
    partial class RezervasyonGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonGuncelleme));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BiletFiyat = new System.Windows.Forms.ComboBox();
            this.MusteriTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MusteriMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.MusteriAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.İnisSaat = new System.Windows.Forms.ComboBox();
            this.KalkisSaat = new System.Windows.Forms.ComboBox();
            this.UcusTarih = new System.Windows.Forms.ComboBox();
            this.KoltukNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Nereyee = new System.Windows.Forms.ComboBox();
            this.Neredenn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RezervasyonİD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.PersonelKayıt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbUcusDataSetRezervasyon = new UcusOtomasyon.DbUcusDataSetRezervasyon();
            this.rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyonTableAdapter = new UcusOtomasyon.DbUcusDataSetRezervasyonTableAdapters.RezervasyonTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neredenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkısSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetRezervasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3844, 1056);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.PersonelKayıt);
            this.groupBox1.Controls.Add(this.RezervasyonİD);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BiletFiyat);
            this.groupBox1.Controls.Add(this.MusteriTelefon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MusteriMail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MusteriTC);
            this.groupBox1.Controls.Add(this.MusteriAd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Controls.Add(this.İnisSaat);
            this.groupBox1.Controls.Add(this.KalkisSaat);
            this.groupBox1.Controls.Add(this.UcusTarih);
            this.groupBox1.Controls.Add(this.KoltukNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Nereyee);
            this.groupBox1.Controls.Add(this.Neredenn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(112, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 898);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // BiletFiyat
            // 
            this.BiletFiyat.DataSource = this.rezervasyonBindingSource;
            this.BiletFiyat.DisplayMember = "Fiyat";
            this.BiletFiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BiletFiyat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletFiyat.FormattingEnabled = true;
            this.BiletFiyat.Location = new System.Drawing.Point(308, 679);
            this.BiletFiyat.Name = "BiletFiyat";
            this.BiletFiyat.Size = new System.Drawing.Size(220, 32);
            this.BiletFiyat.TabIndex = 55;
            this.BiletFiyat.ValueMember = "Nereden";
            // 
            // MusteriTelefon
            // 
            this.MusteriTelefon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTelefon.Location = new System.Drawing.Point(308, 303);
            this.MusteriTelefon.Name = "MusteriTelefon";
            this.MusteriTelefon.Size = new System.Drawing.Size(220, 32);
            this.MusteriTelefon.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(110, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Telefon No :";
            // 
            // MusteriMail
            // 
            this.MusteriMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriMail.Location = new System.Drawing.Point(308, 237);
            this.MusteriMail.Name = "MusteriMail";
            this.MusteriMail.Size = new System.Drawing.Size(220, 32);
            this.MusteriMail.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(147, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 51;
            this.label8.Text = "E-Mail : ";
            // 
            // MusteriTC
            // 
            this.MusteriTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTC.Location = new System.Drawing.Point(308, 117);
            this.MusteriTC.Mask = "00000000000";
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.Size = new System.Drawing.Size(220, 32);
            this.MusteriTC.TabIndex = 50;
            this.MusteriTC.ValidatingType = typeof(int);
            // 
            // MusteriAd
            // 
            this.MusteriAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAd.Location = new System.Drawing.Point(308, 175);
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.Size = new System.Drawing.Size(220, 32);
            this.MusteriAd.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(129, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 28);
            this.label10.TabIndex = 48;
            this.label10.Text = "Ad-Soyad :";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(185, 117);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(50, 28);
            this.lblMusteriID.TabIndex = 47;
            this.lblMusteriID.Text = "T.C :";
            // 
            // İnisSaat
            // 
            this.İnisSaat.DataSource = this.rezervasyonBindingSource;
            this.İnisSaat.DisplayMember = "VarisSaati";
            this.İnisSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.İnisSaat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İnisSaat.FormattingEnabled = true;
            this.İnisSaat.Location = new System.Drawing.Point(308, 618);
            this.İnisSaat.Name = "İnisSaat";
            this.İnisSaat.Size = new System.Drawing.Size(220, 32);
            this.İnisSaat.TabIndex = 46;
            // 
            // KalkisSaat
            // 
            this.KalkisSaat.DataSource = this.rezervasyonBindingSource;
            this.KalkisSaat.DisplayMember = "KalkısSaati";
            this.KalkisSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KalkisSaat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalkisSaat.FormattingEnabled = true;
            this.KalkisSaat.Location = new System.Drawing.Point(308, 556);
            this.KalkisSaat.Name = "KalkisSaat";
            this.KalkisSaat.Size = new System.Drawing.Size(220, 32);
            this.KalkisSaat.TabIndex = 45;
            this.KalkisSaat.ValueMember = "VarisSaati";
            // 
            // UcusTarih
            // 
            this.UcusTarih.DataSource = this.rezervasyonBindingSource;
            this.UcusTarih.DisplayMember = "Tarih";
            this.UcusTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UcusTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcusTarih.FormattingEnabled = true;
            this.UcusTarih.Location = new System.Drawing.Point(308, 494);
            this.UcusTarih.Name = "UcusTarih";
            this.UcusTarih.Size = new System.Drawing.Size(220, 32);
            this.UcusTarih.TabIndex = 44;
            this.UcusTarih.ValueMember = "KalkısSaati";
            // 
            // KoltukNo
            // 
            this.KoltukNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KoltukNo.Location = new System.Drawing.Point(308, 745);
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.Size = new System.Drawing.Size(220, 32);
            this.KoltukNo.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(69, 749);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 28);
            this.label9.TabIndex = 42;
            this.label9.Text = "Koltuk Numarası : ";
            // 
            // Nereyee
            // 
            this.Nereyee.DataSource = this.rezervasyonBindingSource;
            this.Nereyee.DisplayMember = "Nereye";
            this.Nereyee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nereyee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nereyee.FormattingEnabled = true;
            this.Nereyee.Location = new System.Drawing.Point(308, 432);
            this.Nereyee.Name = "Nereyee";
            this.Nereyee.Size = new System.Drawing.Size(220, 32);
            this.Nereyee.TabIndex = 35;
            this.Nereyee.ValueMember = "Nereden";
            // 
            // Neredenn
            // 
            this.Neredenn.DataSource = this.rezervasyonBindingSource;
            this.Neredenn.DisplayMember = "Nereden";
            this.Neredenn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Neredenn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Neredenn.FormattingEnabled = true;
            this.Neredenn.Location = new System.Drawing.Point(308, 369);
            this.Neredenn.Name = "Neredenn";
            this.Neredenn.Size = new System.Drawing.Size(220, 32);
            this.Neredenn.TabIndex = 34;
            this.Neredenn.ValueMember = "Nereye";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(114, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Bilet Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(128, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "İniş Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kalkış Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Uçuş Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nereye : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(133, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nereden :";
            // 
            // RezervasyonİD
            // 
            this.RezervasyonİD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RezervasyonİD.Location = new System.Drawing.Point(308, 60);
            this.RezervasyonİD.Name = "RezervasyonİD";
            this.RezervasyonİD.Size = new System.Drawing.Size(220, 32);
            this.RezervasyonİD.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(191, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 28);
            this.label11.TabIndex = 56;
            this.label11.Text = "ID :";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(162, 824);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(113, 39);
            this.buttonSil.TabIndex = 60;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(292, 824);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(113, 39);
            this.buttonGuncelle.TabIndex = 59;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // PersonelKayıt
            // 
            this.PersonelKayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonelKayıt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelKayıt.Location = new System.Drawing.Point(417, 824);
            this.PersonelKayıt.Name = "PersonelKayıt";
            this.PersonelKayıt.Size = new System.Drawing.Size(113, 39);
            this.PersonelKayıt.TabIndex = 58;
            this.PersonelKayıt.Text = "Kaydet";
            this.PersonelKayıt.UseVisualStyleBackColor = false;
            this.PersonelKayıt.Click += new System.EventHandler(this.PersonelKayıt_Click);
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
            this.neredenDataGridViewTextBoxColumn,
            this.nereyeDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.kalkısSaatiDataGridViewTextBoxColumn,
            this.varisSaatiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.koltukNumarasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervasyonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(886, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 903);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbUcusDataSetRezervasyon
            // 
            this.dbUcusDataSetRezervasyon.DataSetName = "DbUcusDataSetRezervasyon";
            this.dbUcusDataSetRezervasyon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyonBindingSource
            // 
            this.rezervasyonBindingSource.DataMember = "Rezervasyon";
            this.rezervasyonBindingSource.DataSource = this.dbUcusDataSetRezervasyon;
            // 
            // rezervasyonTableAdapter
            // 
            this.rezervasyonTableAdapter.ClearBeforeFill = true;
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
            // neredenDataGridViewTextBoxColumn
            // 
            this.neredenDataGridViewTextBoxColumn.DataPropertyName = "Nereden";
            this.neredenDataGridViewTextBoxColumn.HeaderText = "Nereden";
            this.neredenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.neredenDataGridViewTextBoxColumn.Name = "neredenDataGridViewTextBoxColumn";
            this.neredenDataGridViewTextBoxColumn.Width = 125;
            // 
            // nereyeDataGridViewTextBoxColumn
            // 
            this.nereyeDataGridViewTextBoxColumn.DataPropertyName = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.HeaderText = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nereyeDataGridViewTextBoxColumn.Name = "nereyeDataGridViewTextBoxColumn";
            this.nereyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalkısSaatiDataGridViewTextBoxColumn
            // 
            this.kalkısSaatiDataGridViewTextBoxColumn.DataPropertyName = "KalkısSaati";
            this.kalkısSaatiDataGridViewTextBoxColumn.HeaderText = "KalkısSaati";
            this.kalkısSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkısSaatiDataGridViewTextBoxColumn.Name = "kalkısSaatiDataGridViewTextBoxColumn";
            this.kalkısSaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // varisSaatiDataGridViewTextBoxColumn
            // 
            this.varisSaatiDataGridViewTextBoxColumn.DataPropertyName = "VarisSaati";
            this.varisSaatiDataGridViewTextBoxColumn.HeaderText = "VarisSaati";
            this.varisSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisSaatiDataGridViewTextBoxColumn.Name = "varisSaatiDataGridViewTextBoxColumn";
            this.varisSaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // koltukNumarasiDataGridViewTextBoxColumn
            // 
            this.koltukNumarasiDataGridViewTextBoxColumn.DataPropertyName = "KoltukNumarasi";
            this.koltukNumarasiDataGridViewTextBoxColumn.HeaderText = "KoltukNumarasi";
            this.koltukNumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koltukNumarasiDataGridViewTextBoxColumn.Name = "koltukNumarasiDataGridViewTextBoxColumn";
            this.koltukNumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // RezervasyonGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1056);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RezervasyonGuncelleme";
            this.Text = "Rezervasyon Güncelleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RezervasyonGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetRezervasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox BiletFiyat;
        private System.Windows.Forms.TextBox MusteriTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MusteriMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MusteriTC;
        private System.Windows.Forms.TextBox MusteriAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.ComboBox İnisSaat;
        private System.Windows.Forms.ComboBox KalkisSaat;
        private System.Windows.Forms.ComboBox UcusTarih;
        private System.Windows.Forms.TextBox KoltukNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Nereyee;
        private System.Windows.Forms.ComboBox Neredenn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RezervasyonİD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button PersonelKayıt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbUcusDataSetRezervasyon dbUcusDataSetRezervasyon;
        private System.Windows.Forms.BindingSource rezervasyonBindingSource;
        private DbUcusDataSetRezervasyonTableAdapters.RezervasyonTableAdapter rezervasyonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkısSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukNumarasiDataGridViewTextBoxColumn;
    }
}