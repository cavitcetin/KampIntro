using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //DO NOT REPEAT YOURSELF... / CLEAN CODE - BEST PRACTİCE

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"elma","çilek"};

            ///Bir aşağıya bak bir yukarıya hangisi daha verimli ve gelişmiş.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Dağ Çileği";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //in ürünler= urunler dizimdeki her bi elemanı tek tek gez ve ekrana bas demek.
            //yesil urun veri tipidir. BU programlama dili ben çalışacağım veriyi bilmek istiyorum diyor. 
            //Yani bu urun clasındaki urunleri urun olarak tek tek dolas ve yazdır.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...............");

            }

            Console.WriteLine("-----------METOTLAR-------------");

            //İNSTANCE-CLASS ÖRNEĞİ OLUŞTURACAĞIZ.
            //sepet meneger fonksiyon classımızı çağırıyoruz.
            //encapsulation = kapsülleme

            SepetMeneger sepetMeneger = new SepetMeneger();
            sepetMeneger.Ekle(urun1);
            sepetMeneger.Ekle(urun2);

            sepetMeneger.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetMeneger.Ekle2("Elma", "Yşil Elma", 12, 9);
            sepetMeneger.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);

















        }
    }
}

