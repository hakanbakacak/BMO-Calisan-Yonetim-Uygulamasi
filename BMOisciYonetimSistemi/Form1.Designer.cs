namespace BMOisciYonetimSistemi
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
            this.lbxIsci = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.cmbxSehirler = new System.Windows.Forms.ComboBox();
            this.cmbxDil = new System.Windows.Forms.ComboBox();
            this.cmbxYoneticilik = new System.Windows.Forms.ComboBox();
            this.cmbxAile = new System.Windows.Forms.ComboBox();
            this.grbxAkademik = new System.Windows.Forms.GroupBox();
            this.cbDrDocN = new System.Windows.Forms.CheckBox();
            this.cbYuksekLN = new System.Windows.Forms.CheckBox();
            this.cbDocent = new System.Windows.Forms.CheckBox();
            this.cbDoktora = new System.Windows.Forms.CheckBox();
            this.cbYuksekL = new System.Windows.Forms.CheckBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.IsimSoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.picBxFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.grbxAkademik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxIsci
            // 
            this.lbxIsci.FormattingEnabled = true;
            this.lbxIsci.ItemHeight = 16;
            this.lbxIsci.Location = new System.Drawing.Point(12, 12);
            this.lbxIsci.Name = "lbxIsci";
            this.lbxIsci.Size = new System.Drawing.Size(405, 148);
            this.lbxIsci.TabIndex = 0;
            this.lbxIsci.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbxIsci.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxIsci_MouseDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(271, 166);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 32);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Yeni Çalışan";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(522, 12);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(191, 22);
            this.tbIsim.TabIndex = 2;
            this.tbIsim.Text = "İsim";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(522, 41);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(191, 22);
            this.tbSoyad.TabIndex = 3;
            this.tbSoyad.Text = "Soyisim";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(522, 100);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(191, 75);
            this.tbAdres.TabIndex = 4;
            this.tbAdres.Text = "Adres";
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(522, 181);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(191, 22);
            this.tbMaas.TabIndex = 5;
            this.tbMaas.Text = "Maaş";
            this.tbMaas.TextChanged += new System.EventHandler(this.tbMaas_TextChanged);
            // 
            // cmbxSehirler
            // 
            this.cmbxSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbxSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxSehirler.FormattingEnabled = true;
            this.cmbxSehirler.Items.AddRange(new object[] {
            "Adana",
            "Ankara"});
            this.cmbxSehirler.Location = new System.Drawing.Point(522, 70);
            this.cmbxSehirler.Name = "cmbxSehirler";
            this.cmbxSehirler.Size = new System.Drawing.Size(191, 24);
            this.cmbxSehirler.TabIndex = 6;
            this.cmbxSehirler.Text = "Yaşanılan İl";
            // 
            // cmbxDil
            // 
            this.cmbxDil.FormattingEnabled = true;
            this.cmbxDil.Items.AddRange(new object[] {
            "a"});
            this.cmbxDil.Location = new System.Drawing.Point(522, 377);
            this.cmbxDil.Name = "cmbxDil";
            this.cmbxDil.Size = new System.Drawing.Size(191, 24);
            this.cmbxDil.TabIndex = 8;
            this.cmbxDil.Text = "Yabancı Dil";
            // 
            // cmbxYoneticilik
            // 
            this.cmbxYoneticilik.FormattingEnabled = true;
            this.cmbxYoneticilik.Items.AddRange(new object[] {
            "a"});
            this.cmbxYoneticilik.Location = new System.Drawing.Point(522, 408);
            this.cmbxYoneticilik.Name = "cmbxYoneticilik";
            this.cmbxYoneticilik.Size = new System.Drawing.Size(191, 24);
            this.cmbxYoneticilik.TabIndex = 9;
            this.cmbxYoneticilik.Text = "Yöneticilik Görevi";
            // 
            // cmbxAile
            // 
            this.cmbxAile.FormattingEnabled = true;
            this.cmbxAile.Items.AddRange(new object[] {
            "a"});
            this.cmbxAile.Location = new System.Drawing.Point(522, 439);
            this.cmbxAile.Name = "cmbxAile";
            this.cmbxAile.Size = new System.Drawing.Size(191, 24);
            this.cmbxAile.TabIndex = 10;
            this.cmbxAile.Text = "Aile Durumu";
            // 
            // grbxAkademik
            // 
            this.grbxAkademik.Controls.Add(this.cbDrDocN);
            this.grbxAkademik.Controls.Add(this.cbYuksekLN);
            this.grbxAkademik.Controls.Add(this.cbDocent);
            this.grbxAkademik.Controls.Add(this.cbDoktora);
            this.grbxAkademik.Controls.Add(this.cbYuksekL);
            this.grbxAkademik.Location = new System.Drawing.Point(522, 210);
            this.grbxAkademik.Name = "grbxAkademik";
            this.grbxAkademik.Size = new System.Drawing.Size(340, 161);
            this.grbxAkademik.TabIndex = 11;
            this.grbxAkademik.TabStop = false;
            this.grbxAkademik.Text = "Akademik Derece";
            // 
            // cbDrDocN
            // 
            this.cbDrDocN.AutoSize = true;
            this.cbDrDocN.Location = new System.Drawing.Point(7, 134);
            this.cbDrDocN.Name = "cbDrDocN";
            this.cbDrDocN.Size = new System.Drawing.Size(326, 21);
            this.cbDrDocN.TabIndex = 4;
            this.cbDrDocN.Text = "Meslek alanı ile ilgili olmayan doktora/doçentlik ";
            this.cbDrDocN.UseVisualStyleBackColor = true;
            // 
            // cbYuksekLN
            // 
            this.cbYuksekLN.AutoSize = true;
            this.cbYuksekLN.Location = new System.Drawing.Point(7, 106);
            this.cbYuksekLN.Name = "cbYuksekLN";
            this.cbYuksekLN.Size = new System.Drawing.Size(298, 21);
            this.cbYuksekLN.TabIndex = 3;
            this.cbYuksekLN.Text = "Meslek alanı ile ilgili olmayan yüksek lisans";
            this.cbYuksekLN.UseVisualStyleBackColor = true;
            // 
            // cbDocent
            // 
            this.cbDocent.AutoSize = true;
            this.cbDocent.Location = new System.Drawing.Point(7, 78);
            this.cbDocent.Name = "cbDocent";
            this.cbDocent.Size = new System.Drawing.Size(213, 21);
            this.cbDocent.TabIndex = 2;
            this.cbDocent.Text = "Meslek alanı ile ilgili doçentlik";
            this.cbDocent.UseVisualStyleBackColor = true;
            // 
            // cbDoktora
            // 
            this.cbDoktora.AutoSize = true;
            this.cbDoktora.Location = new System.Drawing.Point(7, 50);
            this.cbDoktora.Name = "cbDoktora";
            this.cbDoktora.Size = new System.Drawing.Size(205, 21);
            this.cbDoktora.TabIndex = 1;
            this.cbDoktora.Text = "Meslek alanı ile ilgili doktora";
            this.cbDoktora.UseVisualStyleBackColor = true;
            // 
            // cbYuksekL
            // 
            this.cbYuksekL.AutoSize = true;
            this.cbYuksekL.Location = new System.Drawing.Point(7, 22);
            this.cbYuksekL.Name = "cbYuksekL";
            this.cbYuksekL.Size = new System.Drawing.Size(241, 21);
            this.cbYuksekL.TabIndex = 0;
            this.cbYuksekL.Text = "Meslek alanı ile ilgili yüksek lisans";
            this.cbYuksekL.UseVisualStyleBackColor = true;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToOrderColumns = true;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsimSoyisim});
            this.dgvListe.Location = new System.Drawing.Point(13, 210);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowTemplate.Height = 24;
            this.dgvListe.Size = new System.Drawing.Size(404, 150);
            this.dgvListe.TabIndex = 12;
            // 
            // IsimSoyisim
            // 
            this.IsimSoyisim.HeaderText = "Ad Soyad";
            this.IsimSoyisim.Name = "IsimSoyisim";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(35, 166);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 32);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(153, 166);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 32);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // picBxFoto
            // 
            this.picBxFoto.Location = new System.Drawing.Point(735, 12);
            this.picBxFoto.Name = "picBxFoto";
            this.picBxFoto.Size = new System.Drawing.Size(127, 148);
            this.picBxFoto.TabIndex = 16;
            this.picBxFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(735, 167);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(126, 31);
            this.btnFoto.TabIndex = 17;
            this.btnFoto.Text = "Fotoğraf Yükle";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 480);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.picBxFoto);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.grbxAkademik);
            this.Controls.Add(this.cmbxAile);
            this.Controls.Add(this.cmbxYoneticilik);
            this.Controls.Add(this.cmbxDil);
            this.Controls.Add(this.cmbxSehirler);
            this.Controls.Add(this.tbMaas);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbIsim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbxIsci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxAkademik.ResumeLayout(false);
            this.grbxAkademik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIsci;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.ComboBox cmbxSehirler;
        private System.Windows.Forms.ComboBox cmbxDil;
        private System.Windows.Forms.ComboBox cmbxYoneticilik;
        private System.Windows.Forms.ComboBox cmbxAile;
        private System.Windows.Forms.GroupBox grbxAkademik;
        private System.Windows.Forms.CheckBox cbDocent;
        private System.Windows.Forms.CheckBox cbDoktora;
        private System.Windows.Forms.CheckBox cbYuksekL;
        private System.Windows.Forms.CheckBox cbDrDocN;
        private System.Windows.Forms.CheckBox cbYuksekLN;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsimSoyisim;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox picBxFoto;
        private System.Windows.Forms.Button btnFoto;
    }
}

