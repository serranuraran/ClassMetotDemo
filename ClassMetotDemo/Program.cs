using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 79;
            musteri1.Adi = "Serra";
            musteri1.Soyadi = "Aran";
            musteri1.Yasi = 29;
            musteri1.Maasi = 9800;


            Musteri musteri2 = new Musteri();

            musteri2.Id = 86;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Aran";
            musteri2.Yasi = 34;
            musteri2.Maasi = 7500;


            Musteri musteri3 = new Musteri();

            musteri3.Id = 86;
            musteri3.Adi = "Furkan";
            musteri3.Soyadi = "Aran";
            musteri3.Yasi = 23;
            musteri3.Maasi = 5250;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
           
            Console.WriteLine("--------Ekle--------");

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
         
            Console.WriteLine("--------Sil---------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            
            Console.WriteLine("---------Listele--------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("İşlemleriniz tamamlanmıştır.");
        }
    }
}
