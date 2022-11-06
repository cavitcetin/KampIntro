using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // İnterface'leri birbirinin alternetifi olan(kredi türleri hesabı) ama kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager //Base görevindeki sınıftaki iştemler her kredi için farklı her kredi farklı hesaplanır o yüzden class değil interface kullanırız.
    {
        void Hesapla();
        void BiseyYap();        
    }
}
