using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMOisciYonetimSistemi
{
    class Calisan
    {
        private string ID;
        private string ısim;
        private string Soyisim;
        private string Adres;//adres burada yaşadığı ili yazmasına gerek yok
        private double MinMaas;//Olabilecek minimum maaş
        private double Maas;//Aldığı maaş 
        private int Deneyim;//Deneyim süresi
        private string Sehir;//Yaşadığı İl
        private string AkademikD;//Alınan Akademik Derece
        private string YDS;//Yabancı dil seviyesi//int bir değer yapıp gösterirken derecelendirilebilir.
        private string Yoneticilik; //Yöneticilik
        private string AileDurumu;//evli, çocuklu vs.

        public string ID1 { get => ID; set => ID = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
        public string Adres1 { get => Adres; set => Adres = value; }
        public double MinMaas1 { get => MinMaas; set => MinMaas = value; }
        public double Maas1 { get => Maas; set => Maas = value; }
        public string Isim { get => ısim; set => ısim = value; }

        public Calisan(string iD, string isim, string soyisim, string adres, double maas)
        {
            ID = iD;
            //ID1 = ıD;
            Isim = ısim;
            Soyisim1 = soyisim;
            Adres1 = adres;
            Maas1 = maas;
        }




        //Katsayı Toplamı: 0,15 (İstanbul) + 0,60 (Deneyim) + 0,20 (Yabancı Dil)+ 0,20 (1 yaşında çocuk) = 1,15
        //En Az Aylık Brüt Ücret = Baz Ücret * (Katsayı Toplamı + 1) = 4.500 * (1,15 + 1) = 9.675 TL
    }
}
