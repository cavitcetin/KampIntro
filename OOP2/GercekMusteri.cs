using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İndividual = Gerçek Müşteri
    class GercekMusteri: Musteri //Miras (İnheritance) ---İki ayrı müşterimiz olduğu için bunları tek classta toplamak için ikisine de müşteri dedik.
    {
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}



