using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Bu bir operasyon class'ıdır. Bu class'ta ekleme silme güncelleme arama filtreleme gibi...
    
    // *2. aşama product managerimizi açıp herhangi bir operasyon oluşturduk. Misal ekleme operasyonu. 
    class ProductManager
    {

        public void Add(Product product)
        {
            //product.ProductName = "Kamera";

            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        //*************************************************************************************************************************************************************************************************************
        
        //*** VOİD ***

        //Aşağıda iki örnek var ikisi de toplama yapıyor. sayi1=3 sayi2=6 olsun. Void ile bu işlemi yap bitir mantığı ile yaparız ve ikisinin toplamı olan 9'u sadece ekrana yazdırabiliriz.
        //Faket public int ve return kullandığımız yerdeki sonucu farklı bir değere atabiliriz ve kullanabiliriz. Yani sonucunu kullanacak isek VOİD kullanmayız. VOİD YAP BİTİR ATTIR.
        //Program.cs'deki Void command'i altında return kullanarak nasıl elde edilen değerin tekrardan kullanılacağını gösterdim.

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        //*************************************************************************************************************************************************************************************************************





        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Aşağısı konu mantığı adlı commande ait.
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    }
}
