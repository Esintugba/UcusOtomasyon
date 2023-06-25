namespace UcusOtomasyon
{
    partial class Uçuşlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uçuşlar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UcusNo = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.UcusİD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UcusTarih = new System.Windows.Forms.DateTimePicker();
            this.Kayıt = new System.Windows.Forms.Button();
            this.BiletFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KalkisSaati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.İnisSaati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neredenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucusTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucuslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUcusDataSetUcus = new UcusOtomasyon.DbUcusDataSetUcus();
            this.ucuslarTableAdapter = new UcusOtomasyon.DbUcusDataSetUcusTableAdapters.UcuslarTableAdapter();
            this.Neredenn = new System.Windows.Forms.ComboBox();
            this.Nereyee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetUcus)).BeginInit();
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
            this.groupBox1.Controls.Add(this.Nereyee);
            this.groupBox1.Controls.Add(this.Neredenn);
            this.groupBox1.Controls.Add(this.UcusNo);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.UcusİD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.UcusTarih);
            this.groupBox1.Controls.Add(this.Kayıt);
            this.groupBox1.Controls.Add(this.BiletFiyati);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.KalkisSaati);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.İnisSaati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Location = new System.Drawing.Point(194, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 742);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // UcusNo
            // 
            this.UcusNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcusNo.Location = new System.Drawing.Point(327, 140);
            this.UcusNo.Name = "UcusNo";
            this.UcusNo.Size = new System.Drawing.Size(220, 32);
            this.UcusNo.TabIndex = 33;
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
            // UcusİD
            // 
            this.UcusİD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcusİD.Location = new System.Drawing.Point(327, 77);
            this.UcusİD.Name = "UcusİD";
            this.UcusİD.Size = new System.Drawing.Size(220, 32);
            this.UcusİD.TabIndex = 30;
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
            // UcusTarih
            // 
            this.UcusTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcusTarih.Location = new System.Drawing.Point(327, 353);
            this.UcusTarih.Name = "UcusTarih";
            this.UcusTarih.Size = new System.Drawing.Size(220, 32);
            this.UcusTarih.TabIndex = 26;
            // 
            // Kayıt
            // 
            this.Kayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kayıt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıt.Location = new System.Drawing.Point(452, 640);
            this.Kayıt.Name = "Kayıt";
            this.Kayıt.Size = new System.Drawing.Size(113, 39);
            this.Kayıt.TabIndex = 25;
            this.Kayıt.Text = "Kaydet";
            this.Kayıt.UseVisualStyleBackColor = false;
            this.Kayıt.Click += new System.EventHandler(this.Kayıt_Click);
            // 
            // BiletFiyati
            // 
            this.BiletFiyati.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletFiyati.Location = new System.Drawing.Point(327, 563);
            this.BiletFiyati.Name = "BiletFiyati";
            this.BiletFiyati.Size = new System.Drawing.Size(220, 32);
            this.BiletFiyati.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(138, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Bilet Fiyatı :";
            // 
            // KalkisSaati
            // 
            this.KalkisSaati.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalkisSaati.Location = new System.Drawing.Point(327, 426);
            this.KalkisSaati.Name = "KalkisSaati";
            this.KalkisSaati.Size = new System.Drawing.Size(220, 32);
            this.KalkisSaati.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(153, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "İniş Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(130, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kalkış Saati :";
            // 
            // İnisSaati
            // 
            this.İnisSaati.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İnisSaati.Location = new System.Drawing.Point(327, 492);
            this.İnisSaati.Name = "İnisSaati";
            this.İnisSaati.Size = new System.Drawing.Size(220, 32);
            this.İnisSaati.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Uçuş Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nereye : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(148, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nereden :";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(157, 144);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(97, 28);
            this.lblMusteriID.TabIndex = 11;
            this.lblMusteriID.Text = "Uçak No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.ucakNoDataGridViewTextBoxColumn,
            this.neredenDataGridViewTextBoxColumn,
            this.nereyeDataGridViewTextBoxColumn,
            this.ucusTarihiDataGridViewTextBoxColumn,
            this.kalkisSaatiDataGridViewTextBoxColumn,
            this.varisSaatiDataGridViewTextBoxColumn,
            this.biletFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ucuslarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1019, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 742);
            this.dataGridView1.TabIndex = 8;
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
            // ucakNoDataGridViewTextBoxColumn
            // 
            this.ucakNoDataGridViewTextBoxColumn.DataPropertyName = "UcakNo";
            this.ucakNoDataGridViewTextBoxColumn.HeaderText = "UcakNo";
            this.ucakNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakNoDataGridViewTextBoxColumn.Name = "ucakNoDataGridViewTextBoxColumn";
            this.ucakNoDataGridViewTextBoxColumn.Width = 125;
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
            // ucusTarihiDataGridViewTextBoxColumn
            // 
            this.ucusTarihiDataGridViewTextBoxColumn.DataPropertyName = "UcusTarihi";
            this.ucusTarihiDataGridViewTextBoxColumn.HeaderText = "UcusTarihi";
            this.ucusTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucusTarihiDataGridViewTextBoxColumn.Name = "ucusTarihiDataGridViewTextBoxColumn";
            this.ucusTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalkisSaatiDataGridViewTextBoxColumn
            // 
            this.kalkisSaatiDataGridViewTextBoxColumn.DataPropertyName = "KalkisSaati";
            this.kalkisSaatiDataGridViewTextBoxColumn.HeaderText = "KalkisSaati";
            this.kalkisSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkisSaatiDataGridViewTextBoxColumn.Name = "kalkisSaatiDataGridViewTextBoxColumn";
            this.kalkisSaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // varisSaatiDataGridViewTextBoxColumn
            // 
            this.varisSaatiDataGridViewTextBoxColumn.DataPropertyName = "VarisSaati";
            this.varisSaatiDataGridViewTextBoxColumn.HeaderText = "VarisSaati";
            this.varisSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisSaatiDataGridViewTextBoxColumn.Name = "varisSaatiDataGridViewTextBoxColumn";
            this.varisSaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // biletFiyatDataGridViewTextBoxColumn
            // 
            this.biletFiyatDataGridViewTextBoxColumn.DataPropertyName = "BiletFiyat";
            this.biletFiyatDataGridViewTextBoxColumn.HeaderText = "BiletFiyat";
            this.biletFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biletFiyatDataGridViewTextBoxColumn.Name = "biletFiyatDataGridViewTextBoxColumn";
            this.biletFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucuslarBindingSource
            // 
            this.ucuslarBindingSource.DataMember = "Ucuslar";
            this.ucuslarBindingSource.DataSource = this.dbUcusDataSetUcus;
            // 
            // dbUcusDataSetUcus
            // 
            this.dbUcusDataSetUcus.DataSetName = "DbUcusDataSetUcus";
            this.dbUcusDataSetUcus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucuslarTableAdapter
            // 
            this.ucuslarTableAdapter.ClearBeforeFill = true;
            // 
            // Neredenn
            // 
            this.Neredenn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Neredenn.FormattingEnabled = true;
            this.Neredenn.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak\t",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.Neredenn.Location = new System.Drawing.Point(327, 212);
            this.Neredenn.Name = "Neredenn";
            this.Neredenn.Size = new System.Drawing.Size(220, 32);
            this.Neredenn.TabIndex = 34;
            // 
            // Nereyee
            // 
            this.Nereyee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nereyee.FormattingEnabled = true;
            this.Nereyee.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak\t",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.Nereyee.Location = new System.Drawing.Point(327, 286);
            this.Nereyee.Name = "Nereyee";
            this.Nereyee.Size = new System.Drawing.Size(220, 32);
            this.Nereyee.TabIndex = 35;
            // 
            // Uçuşlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1056);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Uçuşlar";
            this.Text = "Uçuşlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Uçuşlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSetUcus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox UcusİD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker UcusTarih;
        private System.Windows.Forms.Button Kayıt;
        private System.Windows.Forms.TextBox BiletFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KalkisSaati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox İnisSaati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox UcusNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbUcusDataSetUcus dbUcusDataSetUcus;
        private System.Windows.Forms.BindingSource ucuslarBindingSource;
        private DbUcusDataSetUcusTableAdapters.UcuslarTableAdapter ucuslarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucusTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox Neredenn;
        private System.Windows.Forms.ComboBox Nereyee;
    }
}