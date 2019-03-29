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
            this.btnEkleI = new System.Windows.Forms.Button();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.cbxYoneticilik = new System.Windows.Forms.ComboBox();
            this.cbxAile = new System.Windows.Forms.ComboBox();
            this.grbxAkademik = new System.Windows.Forms.GroupBox();
            this.cbYuksekL = new System.Windows.Forms.CheckBox();
            this.cbDoktora = new System.Windows.Forms.CheckBox();
            this.cbDocent = new System.Windows.Forms.CheckBox();
            this.cbYuksekLN = new System.Windows.Forms.CheckBox();
            this.cbDrDocN = new System.Windows.Forms.CheckBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.IsimSoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbxAkademik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
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
            // 
            // btnEkleI
            // 
            this.btnEkleI.Location = new System.Drawing.Point(305, 166);
            this.btnEkleI.Name = "btnEkleI";
            this.btnEkleI.Size = new System.Drawing.Size(112, 32);
            this.btnEkleI.TabIndex = 1;
            this.btnEkleI.Text = "Calisan Ekle";
            this.btnEkleI.UseVisualStyleBackColor = true;
            this.btnEkleI.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(522, 12);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(151, 22);
            this.tbIsim.TabIndex = 2;
            this.tbIsim.Text = "İsim";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(522, 41);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(151, 22);
            this.tbSoyad.TabIndex = 3;
            this.tbSoyad.Text = "Soyisim";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(522, 100);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(151, 75);
            this.tbAdres.TabIndex = 4;
            this.tbAdres.Text = "Adres";
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(522, 181);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(151, 22);
            this.tbMaas.TabIndex = 5;
            this.tbMaas.Text = "Maaş";
            this.tbMaas.TextChanged += new System.EventHandler(this.tbMaas_TextChanged);
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Items.AddRange(new object[] {
            "Adana",
            "Ankara"});
            this.cmbSehirler.Location = new System.Drawing.Point(522, 70);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(151, 24);
            this.cmbSehirler.TabIndex = 6;
            this.cmbSehirler.Text = "Yaşanılan İl";
            // 
            // cmbDil
            // 
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Location = new System.Drawing.Point(522, 377);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(151, 24);
            this.cmbDil.TabIndex = 8;
            this.cmbDil.Text = "Yabancı Dil";
            // 
            // cbxYoneticilik
            // 
            this.cbxYoneticilik.FormattingEnabled = true;
            this.cbxYoneticilik.Location = new System.Drawing.Point(522, 408);
            this.cbxYoneticilik.Name = "cbxYoneticilik";
            this.cbxYoneticilik.Size = new System.Drawing.Size(151, 24);
            this.cbxYoneticilik.TabIndex = 9;
            this.cbxYoneticilik.Text = "Yöneticilik Görevi";
            // 
            // cbxAile
            // 
            this.cbxAile.FormattingEnabled = true;
            this.cbxAile.Location = new System.Drawing.Point(522, 439);
            this.cbxAile.Name = "cbxAile";
            this.cbxAile.Size = new System.Drawing.Size(121, 24);
            this.cbxAile.TabIndex = 10;
            this.cbxAile.Text = "Aile Durumu";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 480);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.grbxAkademik);
            this.Controls.Add(this.cbxAile);
            this.Controls.Add(this.cbxYoneticilik);
            this.Controls.Add(this.cmbDil);
            this.Controls.Add(this.cmbSehirler);
            this.Controls.Add(this.tbMaas);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbIsim);
            this.Controls.Add(this.btnEkleI);
            this.Controls.Add(this.lbxIsci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxAkademik.ResumeLayout(false);
            this.grbxAkademik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIsci;
        private System.Windows.Forms.Button btnEkleI;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.ComboBox cmbSehirler;
        private System.Windows.Forms.ComboBox cmbDil;
        private System.Windows.Forms.ComboBox cbxYoneticilik;
        private System.Windows.Forms.ComboBox cbxAile;
        private System.Windows.Forms.GroupBox grbxAkademik;
        private System.Windows.Forms.CheckBox cbDocent;
        private System.Windows.Forms.CheckBox cbDoktora;
        private System.Windows.Forms.CheckBox cbYuksekL;
        private System.Windows.Forms.CheckBox cbDrDocN;
        private System.Windows.Forms.CheckBox cbYuksekLN;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsimSoyisim;
    }
}

