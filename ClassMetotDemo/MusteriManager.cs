using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Ekledi : " +musteri.Ad+" "+musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi :" +musteri.Ad+" "+musteri.Soyad);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Ad : "+musteri.Ad);
                Console.WriteLine("Müşteri Soyad : "+musteri.Soyad);
                Console.WriteLine("Müşteri TC : "+musteri.Tc);
                Console.WriteLine("Müşteri Telefon Numarası : "+musteri.Tel);
            }





        }


    }
}
