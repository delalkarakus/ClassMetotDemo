using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Murat";
            musteri1.Soyadi = "Altınok";
            musteri1.Yasi = 28;
            musteri1.Id = 555;
            musteri1.Cinsiyeti = "Erkek";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Berfin";
            musteri2.Soyadi = "Karakuş";
            musteri2.Yasi = 21;
            musteri2.Id = 444;
            musteri2.Cinsiyeti = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Delal";
            musteri3.Soyadi = "Karakuş";
            musteri3.Yasi = 25;
            musteri3.Id = 375;
            musteri3.Cinsiyeti = "Kadın";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Ali";
            musteri4.Soyadi = "Kar";
            musteri4.Yasi = 18;
            musteri4.Id = 254;
            musteri4.Cinsiyeti = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad Soyad : " + musteri.Adi + " " +musteri.Soyadi);
                Console.WriteLine("Yaş : " + musteri.Yasi);
                Console.WriteLine("Id : " + musteri.Id);
                Console.WriteLine("Cinsiyet : " + musteri.Cinsiyeti);
                Console.WriteLine("  ");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            Console.WriteLine("                ");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
            musteriManager.Silme(musteri4);
            Console.WriteLine("               ");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);




        }
    }
}
