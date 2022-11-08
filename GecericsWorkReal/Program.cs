using System;

namespace GecericsWorkReal
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> ulkeler = new MyDictionary<int,string>();
            ulkeler.Add(1,"Türkiye");
            ulkeler.Add(2,"İngiltere");
            ulkeler.Add(3,"Fransa");
            ulkeler.Add(4,"Almanya");
            ulkeler.Add(5,"USA");
        }
    }
}
