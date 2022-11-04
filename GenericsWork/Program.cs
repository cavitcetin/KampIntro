using System;

namespace GenericsWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <string> ulkeler = new MyDictionary<string>();
            ulkeler.Add("Türkiye");
            ulkeler.Add("İngiltere");
            ulkeler.Add("Fransa");
            ulkeler.Add("Almanya");
            ulkeler.Add("USA");

        }
    }
}
