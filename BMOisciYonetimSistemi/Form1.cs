using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//dosya okuma işlemi için eklendi.
using System.Collections;//arrayList bileşeni için eklendi.
namespace BMOisciYonetimSistemi
{   
    
    public partial class Form1 : Form
    {
        ArrayList calisanlar = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // AŞAĞIDA YAPILAN İŞLEM İÇİN BİR SINIF OLUŞTURULUP BURADAKİ KALABALIK TEMİZLENMESİ GEREKİYOR.
            //https://sanalkurs.net/c-openfiledialog-kullanimi-10552.html
            OpenFileDialog fdSource = new OpenFileDialog();
            fdSource.Filter = "kaynak |*.tsv| kaynak |*.csv"; // burada iki adet filtre verdik.
            fdSource.FilterIndex = 2;// bu kod ile varsayılan olarak 2. filtre ile açılacaktır.
            fdSource.ShowDialog();// openfiledialog ekranını açar
            fdSource.CheckFileExists = false;// bu kod dosya adı kısmına bir isim yazdığınızda dosya var mı yok mu kontrolünü yapar. varsa altta öneri çıkar.
                                             //fdSource.Title = "Lütfen Bir Kaynak Dosyası Seçiniz."; //Pencerenin üstünde çıkması gerekiyor. Fakat yok ??
            string DosyaYolu="Deneme.csv";//varsayılan dosya
            DosyaYolu = fdSource.FileName;
            //Dosya yolu seçilmediğinde hata veriyor. dosya yolu seçilmediğinde filedialog kapanmamalı.

            // AŞAĞIDA YAPILAN İŞLEM İÇİN BİR SINIF OLUŞTURULUP BURADAKİ KALABALIK TEMİZLENMESİ GEREKİYOR.
            string line;
            FileStream file = new FileStream(DosyaYolu,FileMode.Open);
            Encoding tr = Encoding.GetEncoding("iso-8859-9");
            StreamReader sr = new StreamReader(file, tr);

            char split;
            if (DosyaYolu.Split('.').Last() == "csv")
            {
                split = ',';
            }
            else
            {
                split = '\t';
            }
            while ((line = sr.ReadLine()) != null)
            {
                string[] bilgiler = line.Split(split);//burada dosya formatı csv ise ',' tsv ise '\t' koşulu eklenecek.
                lbxIsci.Items.Add(bilgiler[0] +'\t'+ bilgiler[1] + '\t' + bilgiler[2] + '\t' + bilgiler[3] + '\t' + bilgiler[4]);
                calisanlar.Add(new Calisan(bilgiler[0], bilgiler[1], bilgiler[2], bilgiler[3], Convert.ToDouble(bilgiler[4])));
            }
            file.Close();
             

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbIsim.Text == "İsim") || (tbSoyad.Text == "Soyisim") || (tbAdres.Text == "Adres") || (tbMaas.Text == "Maaş")||
                (cmbxAile.SelectedIndex==-1)||(cmbxDil.SelectedIndex==-1)||(cmbxSehirler.SelectedIndex==-1)||
                (cmbxYoneticilik.SelectedIndex==-1))
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurunuz.");
            }
            else
            {

            }
        }

        private void tbMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxIsci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form2 FormDetay = new Form2();
            FormDetay.Show();
        }
    }
}
