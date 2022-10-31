using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖNEMLİ!!!
            //Productın özelliği aşağıda isimlendirdiğim 1 ve 2 numaralı methotlarda girebilirim.
            
            // *3. aşamaproductsımıza ekliyeceğimiz verileri girdiğimiz alanı burada oluşturuyoruz.
            //1
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //2
            Product product2 = new Product 
            {Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            //PASCAL CASE //CAMEL CASE = Yazım türleri genel kültür.

            // *4. aşama ProductManagerde oluşturduğumuz add fonksiyonu ile product class'ına yuarıda girdiğimiz verileri atayacağız.
            // Bu yüzden ProdctManagerdeki add operasyonunu kullanarak ekleme işemini simüle ederiz.

            //case sensetive
            //               stack                 heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //***KONU MANTIĞI***

            // int, double, bool... =değer tip ==> değer tiplerde atama yapıldığında sadece sayı gönderilir.
            // dizileri classi abstract classi interface... referans tip ==> referans tiplerde her şey referansın numarasıyla yapılır.

            //SORU1: Product1 ürününün yukarıda özelliklerini girdik ve ProductName için Masa dedik. ProductManagere git orada command ile yazılan yerde product1 ürününü adını Kamera
            // olarak değiştirdim. Sonra tekrar buraya gelip aşağıya console.writeline ile yazdırdığımda ekranda ne sonuç çıkar?

            //ProductManager productManager = new ProductManager();
            //productManager.Add(product1);
            //Console.WriteLine(product1.ProductName);

            //SORU1 CEVAP:
            // ProductName bir referans değer tipidir. Bu yüzden ben ProductManager'de void içinde ProductName'i "Kamera" ile eşleştirirsem ProductName benim program.cs'imde "Masa"
            // olarak atadığım yerde değişir ve Kamera olur. Bu yukarıdaki konu mantığında da yazdığım gibi referans veri tiplerinin bir özelliğidir.


            //SORU2: int sayi değerini 100 atadım ve ProductManagere simüle ettim. Ardından ProductManagerde sayi değerini 99 e eşitledim. Sonra tekrar buraya gelip console.writeline
            // ile yazdığımda ekrana ne sonuç çıkar?
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);

            //SORU 2 CEVAP:
            // sayi değişkenim bir değer tip veridir. Sayı değişkeninin program.cs'de ilk başta 100 atayıp daha sonra ProductManager'de void içinde 99'a eşitlersem ve ardından tekrar
            // program.cs'ye gelip ekrana sayi değişkenini yazdırırsam ProductManager'de yaptığım eşitlemenin hiçbir önemi yoktur ve ekrana 100 yazar. Bunun sebebi değer veri tiplerinde
            // başka yerde değer ataması yapıldığında oraya sadece değeri yollar, değişken adıyla hiçbir alaksı yoktur.
            
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





            //*************************************************************************************************************************************************************************************************************

            //*** VOİD ***

            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu);

            productManager.Topla2(3, 6);

            //*************************************************************************************************************************************************************************************************************-














        }
    }
}
