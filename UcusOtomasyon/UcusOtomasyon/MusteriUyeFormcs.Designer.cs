namespace UcusOtomasyon
{
    partial class MusteriUyeFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriUyeFormcs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MusteriDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.MusteriUye = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1539, 845);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.MusteriDogumTarihi);
            this.groupBox1.Controls.Add(this.MusteriUye);
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
            this.groupBox1.Location = new System.Drawing.Point(50, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 629);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // MusteriDogumTarihi
            // 
            this.MusteriDogumTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriDogumTarihi.Location = new System.Drawing.Point(231, 334);
            this.MusteriDogumTarihi.Name = "MusteriDogumTarihi";
            this.MusteriDogumTarihi.Size = new System.Drawing.Size(220, 32);
            this.MusteriDogumTarihi.TabIndex = 26;
            // 
            // MusteriUye
            // 
            this.MusteriUye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MusteriUye.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriUye.Location = new System.Drawing.Point(338, 544);
            this.MusteriUye.Name = "MusteriUye";
            this.MusteriUye.Size = new System.Drawing.Size(113, 39);
            this.MusteriUye.TabIndex = 25;
            this.MusteriUye.Text = "Üye Ol";
            this.MusteriUye.UseVisualStyleBackColor = false;
            this.MusteriUye.Click += new System.EventHandler(this.MusteriUye_Click);
            // 
            // MusteriSifre
            // 
            this.MusteriSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriSifre.Location = new System.Drawing.Point(231, 477);
            this.MusteriSifre.Name = "MusteriSifre";
            this.MusteriSifre.Size = new System.Drawing.Size(220, 32);
            this.MusteriSifre.TabIndex = 24;
            this.MusteriSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(88, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Şifre:";
            // 
            // MusteriDogumYeri
            // 
            this.MusteriDogumYeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriDogumYeri.Location = new System.Drawing.Point(231, 404);
            this.MusteriDogumYeri.Name = "MusteriDogumYeri";
            this.MusteriDogumYeri.Size = new System.Drawing.Size(220, 32);
            this.MusteriDogumYeri.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Doğum Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // MusteriTelefon
            // 
            this.MusteriTelefon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTelefon.Location = new System.Drawing.Point(231, 265);
            this.MusteriTelefon.Name = "MusteriTelefon";
            this.MusteriTelefon.Size = new System.Drawing.Size(220, 32);
            this.MusteriTelefon.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon No:";
            // 
            // MusteriMail
            // 
            this.MusteriMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriMail.Location = new System.Drawing.Point(231, 194);
            this.MusteriMail.Name = "MusteriMail";
            this.MusteriMail.Size = new System.Drawing.Size(220, 32);
            this.MusteriMail.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "E-Mail : ";
            // 
            // MusteriTC
            // 
            this.MusteriTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriTC.Location = new System.Drawing.Point(231, 52);
            this.MusteriTC.Mask = "00000000000";
            this.MusteriTC.Name = "MusteriTC";
            this.MusteriTC.Size = new System.Drawing.Size(220, 32);
            this.MusteriTC.TabIndex = 14;
            this.MusteriTC.ValidatingType = typeof(int);
            // 
            // MusteriAd
            // 
            this.MusteriAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAd.Location = new System.Drawing.Point(231, 120);
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.Size = new System.Drawing.Size(220, 32);
            this.MusteriAd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad-Soyad :";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(127, 56);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(50, 28);
            this.lblMusteriID.TabIndex = 11;
            this.lblMusteriID.Text = "T.C :";
            // 
            // MusteriUyeFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 845);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusteriUyeFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Üye Formu";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MusteriTC;
        private System.Windows.Forms.TextBox MusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox MusteriMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MusteriTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MusteriSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MusteriDogumYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker MusteriDogumTarihi;
        private System.Windows.Forms.Button MusteriUye;
    }
}