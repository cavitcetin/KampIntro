using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate = Tüzel Müsteri
    class TuzelMusteri:Musteri //Miras (İnheritance) ---İki ayrı müşterimiz olduğu için bunları tek classta toplamak için ikisine de müşteri dedik.
    {     
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
