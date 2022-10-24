using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Cavit";
            musteri1.Soyad = "Çetin";
            musteri1.Tc = "60040895577";
            musteri1.Tel = "05346578941";
            

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Çetin";
            musteri2.Tc = "76632148899";
            musteri2.Tel = "05396874152";
            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Fatma";
            musteri3.Soyad = "Çetin";
            musteri3.Tc = "56674125633";
            musteri3.Tel = "05426398745";
            

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Reşide";
            musteri4.Soyad = "Kömürcü";
            musteri4.Tc = "63320145588";
            musteri4.Tel = "05563214789";
            

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Ad = "Filiz";
            musteri5.Soyad = "Kamilçelebi";
            musteri5.Tc = "32214523366";
            musteri5.Tel = "05579634512";

            Musteri musteri6 = new Musteri();
            musteri6.Id = 6;
            musteri6.Ad = "Feride";
            musteri6.Soyad = "Acar";
            musteri6.Tc = "63354752211";
            musteri6.Tel = "05365987412";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6 };

            MusteriManager musteriManager = new MusteriManager();

            //Ekleme
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);
            musteriManager.Ekle(musteri6);

            //Silme
            musteriManager.Sil(musteri1);


            //Listeleme
            musteriManager.Listele(musteriler);











        }
    }
}
