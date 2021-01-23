using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id:"+musteri.Id+", Adi:"+musteri.Adi+ ", Soyadı:" +musteri.Soyadi+", Yaşı:"+musteri.Yasi+", Maaşı:"+musteri.Maasi+" "+"Bilgilerini içeren müşterimiz sistemimize eklenmiştir.\n");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Id:" + musteri.Id + ", Adi:" + musteri.Adi + ", Soyadı:" + musteri.Soyadi + ", Yaşı:" + musteri.Yasi + ", Maaşı:" + musteri.Maasi+" " + "Bilgilerini içeren müşterimiz sistemimizden silinmiştir.\n");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tüm müşteriler listelenmiştir:" + musteri.Adi + " " + musteri.Soyadi);

        }
    }
}
