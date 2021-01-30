using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "Eklendi");
 
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "Silindi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Id numarası : " + musteri.Id +  " Adı Soyadı : " + musteri.Adi + " " + musteri.Soyadi +  " Yaşı : "  + musteri.Yasi + " Cinsiyeti : " + musteri.Cinsiyeti );
        }
    }
}
