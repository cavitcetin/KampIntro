using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetMeneger
    {
        //SONUNDA MENEGER GİBİ İSİMLER OLAN CLASSLAR GENELLİKLE BİR OPERASYON TUTAR.

        //naming convention

        //fonksiyonlar gibi çalışır

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi );
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        
        }

    }
}
