using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMOisciYonetimSistemi
{
    class Kaynak
    {
        public string DosyaYolu1;
        public string KaynakDegistir()
        {
            OpenFileDialog fdSource = new OpenFileDialog();
            fdSource.Filter = "kaynak |*.tsv| kaynak |*.csv"; // burada iki adet filtre verdik.
            fdSource.FilterIndex = 2;// bu kod ile varsayılan olarak 2. filtre ile açılacaktır.
            fdSource.ShowDialog();// openfiledialog ekranını açar
            fdSource.CheckFileExists = false;// bu kod dosya adı kısmına bir isim yazdığınızda dosya var mı yok mu kontrolünü yapar. varsa altta öneri çıkar.
                                             //fdSource.Title = "Lütfen Bir Kaynak Dosyası Seçiniz."; //Pencerenin üstünde çıkması gerekiyor. Fakat yok ??
            string DosyaYolu = "Deneme.csv";//varsayılan dosya
            DosyaYolu = fdSource.FileName;
            //Dosya yolu seçilmediğinde hata veriyor. dosya yolu seçilmediğinde filedialog kapanmamalı.

            return DosyaYolu;
        }


    }
}
