using System;
using System.Collections.Generic;

namespace xestexana
{
    class Shobe
    {
        public string ShobeAd;
        public List<Hekim> Hekimler = new List<Hekim>();
        public Shobe(string shobeAd)
        {
            ShobeAd = shobeAd;
            Xestexana.Shobeler.Add(this);
        }
        public static void ShobeleriGoster()
        {
            var i = 0;
            foreach (var item in Xestexana.Shobeler)
            {
                i++;
                Console.WriteLine($"{i}. {item.ShobeAd}");

            }
        }
    }
}
