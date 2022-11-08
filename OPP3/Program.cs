using OOP3;
using System.Collections.Generic;

namespace OPP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //İnterface-İnheritance Farkı
            //İnheritance'da kesişim kümesi gibidir. Ortaklar bir yere yazılır ve ebeveyn olarak atanıp çocukların içine de tanımlanır.
            //İnterface ise ortak işlemin farklı yollarda yapıldığı durumlarda kullanılır. Kredi hesabının ihtiyaç ve taşıtta farklı olması gibi.

  
        }
    }
}
