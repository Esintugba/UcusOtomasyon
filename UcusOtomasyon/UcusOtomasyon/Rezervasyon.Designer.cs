namespace UcusOtomasyon
{
    partial class Rezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervasyon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MusteriTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MusteriMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.MusteriAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.İnisSaat = new System.Windows.Forms.ComboBox();
            this.ucuslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUcusDataSet = new UcusOtomasyon.DbUcusDataSet();
            this.KalkisSaat = new System.Windows.Forms.ComboBox();
            this.UcusTarih = new System.Windows.Forms.ComboBox();
            this.KoltukNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Nereyee = new System.Windows.Forms.ComboBox();
            this.Neredenn = new System.Windows.Forms.ComboBox();
            this.Kayıt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ucuslarTableAdapter = new UcusOtomasyon.DbUcusDataSetTableAdapters.UcuslarTableAdapter();
            this.BiletFiyat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.Kayıt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(108, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 816);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // MusteriTelefon
            // 
            this.MusteriTelefon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTelefon.Location = new System.Drawing.Point(303, 238);
            this.MusteriTelefon.Name = "MusteriTelefon";
            this.MusteriTelefon.Size = new System.Drawing.Size(220, 32);
            this.MusteriTelefon.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(105, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Telefon No :";
            // 
            // MusteriMail
            // 
            this.MusteriMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriMail.Location = new System.Drawing.Point(303, 172);
            this.MusteriMail.Name = "MusteriMail";
            this.MusteriMail.Size = new System.Drawing.Size(220, 32);
            this.MusteriMail.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(142, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 51;
            this.label8.Text = "E-Mail : ";
            // 
            // MusteriTC
            // 
            this.MusteriTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTC.Location = new System.Drawing.Point(303, 52);
            this.MusteriTC.Mask = "00000000000";
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.Size = new System.Drawing.Size(220, 32);
            this.MusteriTC.TabIndex = 50;
            this.MusteriTC.ValidatingType = typeof(int);
            // 
            // MusteriAd
            // 
            this.MusteriAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAd.Location = new System.Drawing.Point(303, 110);
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.Size = new System.Drawing.Size(220, 32);
            this.MusteriAd.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(124, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 28);
            this.label10.TabIndex = 48;
            this.label10.Text = "Ad-Soyad :";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(180, 52);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(50, 28);
            this.lblMusteriID.TabIndex = 47;
            this.lblMusteriID.Text = "T.C :";
            // 
            // İnisSaat
            // 
            this.İnisSaat.DataSource = this.ucuslarBindingSource;
            this.İnisSaat.DisplayMember = "VarisSaati";
            this.İnisSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.İnisSaat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İnisSaat.FormattingEnabled = true;
            this.İnisSaat.Location = new System.Drawing.Point(303, 553);
            this.İnisSaat.Name = "İnisSaat";
            this.İnisSaat.Size = new System.Drawing.Size(220, 32);
            this.İnisSaat.TabIndex = 46;
            // 
            // ucuslarBindingSource
            // 
            this.ucuslarBindingSource.DataMember = "Ucuslar";
            this.ucuslarBindingSource.DataSource = this.dbUcusDataSet;
            // 
            // dbUcusDataSet
            // 
            this.dbUcusDataSet.DataSetName = "DbUcusDataSet";
            this.dbUcusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KalkisSaat
            // 
            this.KalkisSaat.DataSource = this.ucuslarBindingSource;
            this.KalkisSaat.DisplayMember = "KalkisSaati";
            this.KalkisSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KalkisSaat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalkisSaat.FormattingEnabled = true;
            this.KalkisSaat.Location = new System.Drawing.Point(303, 491);
            this.KalkisSaat.Name = "KalkisSaat";
            this.KalkisSaat.Size = new System.Drawing.Size(220, 32);
            this.KalkisSaat.TabIndex = 45;
            // 
            // UcusTarih
            // 
            this.UcusTarih.DataSource = this.ucuslarBindingSource;
            this.UcusTarih.DisplayMember = "UcusTarihi";
            this.UcusTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UcusTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcusTarih.FormattingEnabled = true;
            this.UcusTarih.Location = new System.Drawing.Point(303, 429);
            this.UcusTarih.Name = "UcusTarih";
            this.UcusTarih.Size = new System.Drawing.Size(220, 32);
            this.UcusTarih.TabIndex = 44;
            // 
            // KoltukNo
            // 
            this.KoltukNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KoltukNo.Location = new System.Drawing.Point(303, 680);
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.Size = new System.Drawing.Size(220, 32);
            this.KoltukNo.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(64, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 28);
            this.label9.TabIndex = 42;
            this.label9.Text = "Koltuk Numarası : ";
            // 
            // Nereyee
            // 
            this.Nereyee.DataSource = this.ucuslarBindingSource;
            this.Nereyee.DisplayMember = "Nereye";
            this.Nereyee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nereyee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nereyee.FormattingEnabled = true;
            this.Nereyee.Location = new System.Drawing.Point(303, 367);
            this.Nereyee.Name = "Nereyee";
            this.Nereyee.Size = new System.Drawing.Size(220, 32);
            this.Nereyee.TabIndex = 35;
            this.Nereyee.ValueMember = "Nereden";
            // 
            // Neredenn
            // 
            this.Neredenn.DataSource = this.ucuslarBindingSource;
            this.Neredenn.DisplayMember = "Nereden";
            this.Neredenn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Neredenn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Neredenn.FormattingEnabled = true;
            this.Neredenn.Location = new System.Drawing.Point(303, 304);
            this.Neredenn.Name = "Neredenn";
            this.Neredenn.Size = new System.Drawing.Size(220, 32);
            this.Neredenn.TabIndex = 34;
            this.Neredenn.ValueMember = "Nereye";
            // 
            // Kayıt
            // 
            this.Kayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kayıt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıt.Location = new System.Drawing.Point(439, 753);
            this.Kayıt.Name = "Kayıt";
            this.Kayıt.Size = new System.Drawing.Size(113, 39);
            this.Kayıt.TabIndex = 25;
            this.Kayıt.Text = "Satın Al";
            this.Kayıt.UseVisualStyleBackColor = false;
            this.Kayıt.Click += new System.EventHandler(this.Kayıt_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(109, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Bilet Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(123, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "İniş Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kalkış Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Uçuş Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nereye : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nereden :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.button25);
            this.groupBox2.Controls.Add(this.button24);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(1022, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 804);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // button25
            // 
            this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.Location = new System.Drawing.Point(663, 632);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(83, 80);
            this.button25.TabIndex = 66;
            this.button25.Text = "E - 5";
            this.button25.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click_1);
            // 
            // button24
            // 
            this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.Location = new System.Drawing.Point(524, 632);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(83, 80);
            this.button24.TabIndex = 65;
            this.button24.Text = "E - 4";
            this.button24.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click_1);
            // 
            // button23
            // 
            this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.Location = new System.Drawing.Point(382, 632);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(83, 80);
            this.button23.TabIndex = 64;
            this.button23.Text = "E - 3";
            this.button23.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // button22
            // 
            this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.Location = new System.Drawing.Point(248, 632);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(83, 80);
            this.button22.TabIndex = 63;
            this.button22.Text = "E - 2 ";
            this.button22.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click_1);
            // 
            // button21
            // 
            this.button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button21.BackgroundImage")));
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.Location = new System.Drawing.Point(104, 632);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(83, 80);
            this.button21.TabIndex = 62;
            this.button21.Text = "E - 1";
            this.button21.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click_1);
            // 
            // button20
            // 
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Location = new System.Drawing.Point(663, 484);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(83, 80);
            this.button20.TabIndex = 61;
            this.button20.Text = "D - 5";
            this.button20.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click_1);
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Location = new System.Drawing.Point(524, 484);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(83, 80);
            this.button19.TabIndex = 60;
            this.button19.Text = "D - 4";
            this.button19.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // button18
            // 
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(382, 484);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(83, 80);
            this.button18.TabIndex = 59;
            this.button18.Text = "D - 3";
            this.button18.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click_1);
            // 
            // button17
            // 
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(248, 484);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(83, 80);
            this.button17.TabIndex = 58;
            this.button17.Text = "D - 2 ";
            this.button17.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button16
            // 
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Location = new System.Drawing.Point(104, 484);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 80);
            this.button16.TabIndex = 57;
            this.button16.Text = "D - 1";
            this.button16.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button15
            // 
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Location = new System.Drawing.Point(663, 347);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(83, 80);
            this.button15.TabIndex = 56;
            this.button15.Text = "C - 5";
            this.button15.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button14
            // 
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(524, 347);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 80);
            this.button14.TabIndex = 55;
            this.button14.Text = "C - 4 ";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Location = new System.Drawing.Point(388, 347);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(83, 80);
            this.button13.TabIndex = 54;
            this.button13.Text = "C - 3";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(248, 347);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 80);
            this.button12.TabIndex = 53;
            this.button12.Text = " C - 2 ";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(104, 347);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(83, 80);
            this.button11.TabIndex = 52;
            this.button11.Text = "C - 1 ";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(663, 211);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 80);
            this.button10.TabIndex = 51;
            this.button10.Text = "B - 5 ";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(524, 213);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 80);
            this.button9.TabIndex = 50;
            this.button9.Text = "B - 4 ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(382, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 80);
            this.button8.TabIndex = 49;
            this.button8.Text = "B - 3";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(248, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 80);
            this.button7.TabIndex = 48;
            this.button7.Text = "B - 2";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(104, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 80);
            this.button6.TabIndex = 47;
            this.button6.Text = "B -1 ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(663, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 80);
            this.button5.TabIndex = 46;
            this.button5.Text = "A - 5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(524, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 80);
            this.button4.TabIndex = 45;
            this.button4.Text = "A - 4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(382, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 80);
            this.button3.TabIndex = 44;
            this.button3.Text = "A -3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(242, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 80);
            this.button2.TabIndex = 43;
            this.button2.Text = "A - 2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(104, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 80);
            this.button1.TabIndex = 42;
            this.button1.Text = "A - 1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucuslarTableAdapter
            // 
            this.ucuslarTableAdapter.ClearBeforeFill = true;
            // 
            // BiletFiyat
            // 
            this.BiletFiyat.DataSource = this.ucuslarBindingSource;
            this.BiletFiyat.DisplayMember = "BiletFiyat";
            this.BiletFiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BiletFiyat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletFiyat.FormattingEnabled = true;
            this.BiletFiyat.Location = new System.Drawing.Point(303, 614);
            this.BiletFiyat.Name = "BiletFiyat";
            this.BiletFiyat.Size = new System.Drawing.Size(220, 32);
            this.BiletFiyat.TabIndex = 55;
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1056);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Rezervasyon";
            this.Text = "Rezervasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcusDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Nereyee;
        private System.Windows.Forms.ComboBox Neredenn;
        private System.Windows.Forms.Button Kayıt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox KoltukNo;
        private System.Windows.Forms.Label label9;
        private DbUcusDataSet dbUcusDataSet;
        private System.Windows.Forms.BindingSource ucuslarBindingSource;
        private DbUcusDataSetTableAdapters.UcuslarTableAdapter ucuslarTableAdapter;
        private System.Windows.Forms.ComboBox İnisSaat;
        private System.Windows.Forms.ComboBox KalkisSaat;
        private System.Windows.Forms.ComboBox UcusTarih;
        private System.Windows.Forms.TextBox MusteriTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MusteriMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MusteriTC;
        private System.Windows.Forms.TextBox MusteriAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.ComboBox BiletFiyat;
    }
}