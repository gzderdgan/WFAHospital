namespace WFAHospital
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbHastaKayıt = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbErkek = new System.Windows.Forms.CheckBox();
            this.cbRandevuSaat = new System.Windows.Forms.ComboBox();
            this.cbRandevuDakika = new System.Windows.Forms.ComboBox();
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.dateRandevuDate = new System.Windows.Forms.DateTimePicker();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.lbHastalar = new System.Windows.Forms.ListBox();
            this.lblToplamHasta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstHastalar = new System.Windows.Forms.ListView();
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbHastaKayıt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHastaKayıt
            // 
            this.gbHastaKayıt.Controls.Add(this.btnEkle);
            this.gbHastaKayıt.Controls.Add(this.btnSil);
            this.gbHastaKayıt.Controls.Add(this.cbErkek);
            this.gbHastaKayıt.Controls.Add(this.cbRandevuSaat);
            this.gbHastaKayıt.Controls.Add(this.cbRandevuDakika);
            this.gbHastaKayıt.Controls.Add(this.cbDoktor);
            this.gbHastaKayıt.Controls.Add(this.cbBrans);
            this.gbHastaKayıt.Controls.Add(this.dateRandevuDate);
            this.gbHastaKayıt.Controls.Add(this.dateDogumTarihi);
            this.gbHastaKayıt.Controls.Add(this.tbAdSoyad);
            this.gbHastaKayıt.Controls.Add(this.tbTc);
            this.gbHastaKayıt.Controls.Add(this.lbHastalar);
            this.gbHastaKayıt.Controls.Add(this.lblToplamHasta);
            this.gbHastaKayıt.Controls.Add(this.label8);
            this.gbHastaKayıt.Controls.Add(this.label7);
            this.gbHastaKayıt.Controls.Add(this.label6);
            this.gbHastaKayıt.Controls.Add(this.label5);
            this.gbHastaKayıt.Controls.Add(this.label4);
            this.gbHastaKayıt.Controls.Add(this.label3);
            this.gbHastaKayıt.Controls.Add(this.label2);
            this.gbHastaKayıt.Controls.Add(this.label9);
            this.gbHastaKayıt.Controls.Add(this.label1);
            this.gbHastaKayıt.Location = new System.Drawing.Point(3, 1);
            this.gbHastaKayıt.Name = "gbHastaKayıt";
            this.gbHastaKayıt.Size = new System.Drawing.Size(562, 290);
            this.gbHastaKayıt.TabIndex = 3;
            this.gbHastaKayıt.TabStop = false;
            this.gbHastaKayıt.Text = "Yeni Hasta Kayıt Formu";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(192, 252);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(86, 252);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbErkek
            // 
            this.cbErkek.AutoSize = true;
            this.cbErkek.Location = new System.Drawing.Point(86, 224);
            this.cbErkek.Name = "cbErkek";
            this.cbErkek.Size = new System.Drawing.Size(54, 17);
            this.cbErkek.TabIndex = 6;
            this.cbErkek.Text = "Erkek";
            this.cbErkek.UseVisualStyleBackColor = true;
            // 
            // cbRandevuSaat
            // 
            this.cbRandevuSaat.FormattingEnabled = true;
            this.cbRandevuSaat.Location = new System.Drawing.Point(86, 194);
            this.cbRandevuSaat.Name = "cbRandevuSaat";
            this.cbRandevuSaat.Size = new System.Drawing.Size(38, 21);
            this.cbRandevuSaat.TabIndex = 5;
            // 
            // cbRandevuDakika
            // 
            this.cbRandevuDakika.FormattingEnabled = true;
            this.cbRandevuDakika.Location = new System.Drawing.Point(135, 194);
            this.cbRandevuDakika.Name = "cbRandevuDakika";
            this.cbRandevuDakika.Size = new System.Drawing.Size(38, 21);
            this.cbRandevuDakika.TabIndex = 5;
            // 
            // cbDoktor
            // 
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Location = new System.Drawing.Point(86, 132);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(200, 21);
            this.cbDoktor.TabIndex = 4;
            // 
            // cbBrans
            // 
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(86, 102);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(200, 21);
            this.cbBrans.TabIndex = 4;
            this.cbBrans.SelectedIndexChanged += new System.EventHandler(this.cbBrans_SelectedIndexChanged);
            // 
            // dateRandevuDate
            // 
            this.dateRandevuDate.Location = new System.Drawing.Point(86, 167);
            this.dateRandevuDate.Name = "dateRandevuDate";
            this.dateRandevuDate.Size = new System.Drawing.Size(200, 20);
            this.dateRandevuDate.TabIndex = 3;
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Location = new System.Drawing.Point(86, 72);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateDogumTarihi.TabIndex = 3;
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(86, 48);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(200, 20);
            this.tbAdSoyad.TabIndex = 2;
            // 
            // tbTc
            // 
            this.tbTc.Location = new System.Drawing.Point(86, 22);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(200, 20);
            this.tbTc.TabIndex = 2;
            // 
            // lbHastalar
            // 
            this.lbHastalar.FormattingEnabled = true;
            this.lbHastalar.Location = new System.Drawing.Point(317, 38);
            this.lbHastalar.Name = "lbHastalar";
            this.lbHastalar.Size = new System.Drawing.Size(230, 238);
            this.lbHastalar.TabIndex = 1;
            this.lbHastalar.Click += new System.EventHandler(this.lbHastalar_Click);
            // 
            // lblToplamHasta
            // 
            this.lblToplamHasta.AutoSize = true;
            this.lblToplamHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHasta.Location = new System.Drawing.Point(325, 279);
            this.lblToplamHasta.Name = "lblToplamHasta";
            this.lblToplamHasta.Size = new System.Drawing.Size(0, 13);
            this.lblToplamHasta.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Randevu Saati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Randevu Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doktor Seçimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Branş Seçimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tüm Hastalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstHastalar);
            this.groupBox2.Location = new System.Drawing.Point(3, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bugün Bekleyen Randevular";
            // 
            // lstHastalar
            // 
            this.lstHastalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TC,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstHastalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHastalar.Location = new System.Drawing.Point(3, 16);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(556, 210);
            this.lstHastalar.TabIndex = 0;
            this.lstHastalar.UseCompatibleStateImageBehavior = false;
            this.lstHastalar.View = System.Windows.Forms.View.Details;
            // 
            // TC
            // 
            this.TC.Text = "TC";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doğum Tarihi";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Branş";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doktor";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Tarihi";
            this.columnHeader5.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbHastaKayıt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbHastaKayıt.ResumeLayout(false);
            this.gbHastaKayıt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHastaKayıt;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox cbErkek;
        private System.Windows.Forms.ComboBox cbRandevuSaat;
        private System.Windows.Forms.ComboBox cbRandevuDakika;
        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.DateTimePicker dateRandevuDate;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.ListBox lbHastalar;
        private System.Windows.Forms.Label lblToplamHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstHastalar;
        public System.Windows.Forms.ColumnHeader TC;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

