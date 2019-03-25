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
            this.btnEkleI.Location = new System.Drawing.Point(614, 24);
            this.btnEkleI.Name = "btnEkleI";
            this.btnEkleI.Size = new System.Drawing.Size(75, 23);
            this.btnEkleI.TabIndex = 1;
            this.btnEkleI.Text = "İşçi Ekle";
            this.btnEkleI.UseVisualStyleBackColor = true;
            this.btnEkleI.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkleI);
            this.Controls.Add(this.lbxIsci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIsci;
        private System.Windows.Forms.Button btnEkleI;
    }
}

