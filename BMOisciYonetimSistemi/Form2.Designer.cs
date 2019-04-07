namespace BMOisciYonetimSistemi
{
    partial class Form2
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
            this.btnFoto = new System.Windows.Forms.Button();
            this.picBxFoto = new System.Windows.Forms.PictureBox();
            this.grbxAkademik = new System.Windows.Forms.GroupBox();
            this.cbDrDocN = new System.Windows.Forms.CheckBox();
            this.cbYuksekLN = new System.Windows.Forms.CheckBox();
            this.cbDocent = new System.Windows.Forms.CheckBox();
            this.cbDoktora = new System.Windows.Forms.CheckBox();
            this.cbYuksekL = new System.Windows.Forms.CheckBox();
            this.cmbxAile = new System.Windows.Forms.ComboBox();
            this.cmbxYoneticilik = new System.Windows.Forms.ComboBox();
            this.cmbxDil = new System.Windows.Forms.ComboBox();
            this.cmbxSehirler = new System.Windows.Forms.ComboBox();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbIsim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoto)).BeginInit();
            this.grbxAkademik.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(225, 175);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(126, 31);
            this.btnFoto.TabIndex = 28;
            this.btnFoto.Text = "Fotoğraf Yükle";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // picBxFoto
            // 
            this.picBxFoto.Location = new System.Drawing.Point(225, 20);
            this.picBxFoto.Name = "picBxFoto";
            this.picBxFoto.Size = new System.Drawing.Size(127, 148);
            this.picBxFoto.TabIndex = 27;
            this.picBxFoto.TabStop = false;
            // 
            // grbxAkademik
            // 
            this.grbxAkademik.Controls.Add(this.cbDrDocN);
            this.grbxAkademik.Controls.Add(this.cbYuksekLN);
            this.grbxAkademik.Controls.Add(this.cbDocent);
            this.grbxAkademik.Controls.Add(this.cbDoktora);
            this.grbxAkademik.Controls.Add(this.cbYuksekL);
            this.grbxAkademik.Location = new System.Drawing.Point(12, 218);
            this.grbxAkademik.Name = "grbxAkademik";
            this.grbxAkademik.Size = new System.Drawing.Size(340, 161);
            this.grbxAkademik.TabIndex = 26;
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
            // cmbxAile
            // 
            this.cmbxAile.FormattingEnabled = true;
            this.cmbxAile.Items.AddRange(new object[] {
            "a"});
            this.cmbxAile.Location = new System.Drawing.Point(12, 447);
            this.cmbxAile.Name = "cmbxAile";
            this.cmbxAile.Size = new System.Drawing.Size(191, 24);
            this.cmbxAile.TabIndex = 25;
            this.cmbxAile.Text = "Aile Durumu";
            // 
            // cmbxYoneticilik
            // 
            this.cmbxYoneticilik.FormattingEnabled = true;
            this.cmbxYoneticilik.Items.AddRange(new object[] {
            "a"});
            this.cmbxYoneticilik.Location = new System.Drawing.Point(12, 416);
            this.cmbxYoneticilik.Name = "cmbxYoneticilik";
            this.cmbxYoneticilik.Size = new System.Drawing.Size(191, 24);
            this.cmbxYoneticilik.TabIndex = 24;
            this.cmbxYoneticilik.Text = "Yöneticilik Görevi";
            // 
            // cmbxDil
            // 
            this.cmbxDil.FormattingEnabled = true;
            this.cmbxDil.Items.AddRange(new object[] {
            "a"});
            this.cmbxDil.Location = new System.Drawing.Point(12, 385);
            this.cmbxDil.Name = "cmbxDil";
            this.cmbxDil.Size = new System.Drawing.Size(191, 24);
            this.cmbxDil.TabIndex = 23;
            this.cmbxDil.Text = "Yabancı Dil";
            // 
            // cmbxSehirler
            // 
            this.cmbxSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbxSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxSehirler.FormattingEnabled = true;
            this.cmbxSehirler.Items.AddRange(new object[] {
            "Adana",
            "Ankara"});
            this.cmbxSehirler.Location = new System.Drawing.Point(12, 78);
            this.cmbxSehirler.Name = "cmbxSehirler";
            this.cmbxSehirler.Size = new System.Drawing.Size(191, 24);
            this.cmbxSehirler.TabIndex = 22;
            this.cmbxSehirler.Text = "Yaşanılan İl";
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(12, 189);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(191, 22);
            this.tbMaas.TabIndex = 21;
            this.tbMaas.Text = "Maaş";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(12, 108);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(191, 75);
            this.tbAdres.TabIndex = 20;
            this.tbAdres.Text = "Adres";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(12, 49);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(191, 22);
            this.tbSoyad.TabIndex = 19;
            this.tbSoyad.Text = "Soyisim";
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(12, 20);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(191, 22);
            this.tbIsim.TabIndex = 18;
            this.tbIsim.Text = "İsim";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 520);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.picBxFoto);
            this.Controls.Add(this.grbxAkademik);
            this.Controls.Add(this.cmbxAile);
            this.Controls.Add(this.cmbxYoneticilik);
            this.Controls.Add(this.cmbxDil);
            this.Controls.Add(this.cmbxSehirler);
            this.Controls.Add(this.tbMaas);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbIsim);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picBxFoto)).EndInit();
            this.grbxAkademik.ResumeLayout(false);
            this.grbxAkademik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox picBxFoto;
        private System.Windows.Forms.GroupBox grbxAkademik;
        private System.Windows.Forms.CheckBox cbDrDocN;
        private System.Windows.Forms.CheckBox cbYuksekLN;
        private System.Windows.Forms.CheckBox cbDocent;
        private System.Windows.Forms.CheckBox cbDoktora;
        private System.Windows.Forms.CheckBox cbYuksekL;
        private System.Windows.Forms.ComboBox cmbxAile;
        private System.Windows.Forms.ComboBox cmbxYoneticilik;
        private System.Windows.Forms.ComboBox cmbxDil;
        private System.Windows.Forms.ComboBox cmbxSehirler;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbIsim;
    }
}