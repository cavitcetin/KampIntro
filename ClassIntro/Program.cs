using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cavit";
            int yas = 23;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Cavit Çetin";
            kurs1.IzlenmeOrani = "55";

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Fatma Çetin";
            kurs2.IzlenmeOrani = "65";

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Mehmet Çetin";
            kurs3.IzlenmeOrani = "75";

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "C##";
            kurs4.Egitmen = "Furkan Kızlırmak";
            kurs4.IzlenmeOrani = "100";

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

            //////////////////////////////////////////////////////ödev/////////////////////////////////////////////////////////////
            product urun1 = new product();
            urun1.UrunAdi = "Enjoy Tavuklu Yetişkin Çok Renkli Kedi Maması";

            product urun2 = new product();
            urun2.UrunAdi = "Hills Science Plan Kitten Tuna Balıklı Yavru Kedi Maması";

            product urun3 = new product();
            urun3.UrunAdi = "N & D Düşük Tahıllı Balıklı Portakallı Yetişkin Kedi Maması";

            product urun4 = new product();
            urun4.UrunAdi = "Felicia Az Tahıllı 12 Kg Sterilised Somonlu Hypoallergenic";

            product urun5 = new product();
            urun5.UrunAdi = "Royal Canin Kitten Yavru Kedi Maması ";

            product[] products = new product[] {urun1, urun2, urun3, urun4, urun5};

            foreach (var product in products)
            {
                Console.WriteLine(product.UrunAdi);
            }

            for (int i = 0; i <products.Length; i++) 
            {
                Console.WriteLine(products[i].UrunAdi);
            }

            int k = 0;
            while (k< products.Length)
            {
                Console.WriteLine(products[k].UrunAdi);
                k++;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////



        }
        }
    }


    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }

    }

    ///////////////////////////////////////////////////ödev/////////////////////////////////////////////////////
    class product
    {
        public string UrunAdi { get; set; }

    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////



