using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
         
         //c#'ta verinin türünü başına yazarız.

            //harfler
            string kategoriEtiketi = "kategori";

            //sayılar
            int ogrenciSayisi = 320000;

            //ondalıklı sayılar
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.43;


            //print kısmı c#'ta console writeline ile yapılır.
            Console.WriteLine(kategoriEtiketi);

            //sisteme giris yapmıs mi denetleme
            bool sistemeGirisYapmisMi = false;

         //if-elif-else kalıbını açmak için if yazıp iki tane tab'a basın.
            
            //örnek1
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            //örnek2
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarDun<dolarBugun) 
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Dolar Değişmedi");                   
            }





            

            
            
            



        }
    }
}




