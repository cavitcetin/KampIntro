using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
        //Döngüler            
            //For döngüsü
            //1'den basla 10'a kadar devam et.
            // i++ bir bir arttır demek.
            // i=i+2 iki iki arttır. (i+=2 de iki iki arttır demek)
            for (int i = 1; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        //ARRAY-DİZİ

            string[] kurslar = new string[] { "A kursu", "B kursu", "C kursu","D kursu" };

            for (int i = 0; i<kurslar.Length; i++) //lenght eleman sayısı demektir. Dinamik hale getirdik sayı yazsak yeni eklenen eleman çıkmazdı.

            {
                Console.WriteLine(kurslar[i]);
            }

            //Kurslarsı tek tek dolaş ve ekrana yaz. Bu da farklı bir yazma methodu. For daha genel amaçlar için foreach dizileri daha kolay dolaşmak için kullanılır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            







        }
    }
}
