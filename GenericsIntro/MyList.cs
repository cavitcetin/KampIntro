using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor  = bu arrayi çalıştırdığın an bunu da çalıştır komutu.
        public MyList()
        {
            items = new T[0];
        }


        public void Add(T item)
        {
            T[] tempArray = items; //103'ü yazdırcam 102'yi emaneten tut kodu.
            items = new T[items.Length+1]; //Mevcut eleman sayın kaçsa say +1 arttır ile eklenir.
            for (int i = 0; i < tempArray.Length; i++) //emaneten tuttuğun kodları geri alıyorsun.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;


            

        }

    }
}
