using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    // 1-) MyDictionary class'ını oluşturduk. (Class tipimizi random isim seçerek T olarak atadık. Bunun sebebi içine int mı string mi veya başka bir tip mi
    // vereceğimizin belli olmamasıdır. Program.cs kısmında bu oluşturduğumuz listeye veri eklerken eklediğimiz verinin türünü girerek ekleriz, MyDictionar[T] classımız da
    // onu bizim eklerken belirttiğimiz türde kaydeder. Daha iyi anlamak için program.cs'de dediğim kısma bakabilirsiniz.)
    class MyDictionary<T>
    {
        T[] items;

        // 3-) Program.cs kısmından yeni veri eklediğimde çalışacak kodu yazıyorum. Bu kodu yazma sebebim yapay oluşturduğum MyDictionary'mde kaç eleman olduğunu belirtmek.
        // yani aşağıdaki kodun türkçesi 0 elemanlı bir liste oluşturdum.
        public MyDictionary()
        {
            items = new T[0];
        }              

        // 2-) MyDictionary listemizin operasyonu olan add operasyonunu yazdık.
        public void Add(T item)
        {
            // 5-) Her eleman eklediğimde çalışan 4. maddede yazdığım kodun mantığı şu idi; eski elemanları say yeni elemanı +1 olarak ekle. Fakat şöyle bir sorunumuz var. 
            // Yeni eleman ekleme işlemi yaparken eski elemanları kaybediyoruz. Bu yüzden yeni tampArray adında bir liste oluşturup eski elemanlara (items) eşitledik ve eski
            // verilerimizi kaybetmeden sakladık.
            T[] tempArray = items;
            
            // 4-) Ben üçüncü maddede de dediğim gibi sıfır elemanlı bir liste oluşturdum. Bu listem 0 elemanlı bir liste yazdım fakat benbu listeye yeni eleman eklesem
            // eleman sayısının da artması gerekiyor. Bu yüzden her eleman eklediğimde eleman sayısını 1 arttıracak ve yeni listeyi oluşturacak kodu yazıyorum.
            items = new T[items.Length + 1]; 

            // 6-) tampArray'de sakladığımız eski verileri yeni oluşacak güncel items verilerimizle eşleyerek veri kaybetmeden yeni listeyi oluşturcağımız kodu yazdık.
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];
            }
            // 7-) Eski elemanları güncel listeye ekledikten sonra yeni eleman olan son elemanı, length-1 ile son diye belirterek sona ekledik.  
            items[items.Length - 1] = item;
        }

    }
}
