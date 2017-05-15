using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xestexana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shobeler yaranir
            var Endokrinologiya = new Shobe("Endokrinologiya");
            var Travmatologiya = new Shobe("Travmatologiya");
            var Stomotologiya = new Shobe("Stomotologiya");
            var Cerrahiyye = new Shobe("Cerrahiyye");
            var Oftolmoloq = new Shobe("Oftolmoloq");
            var Dermotologiya = new Shobe("Dermotologiya");
            var Urologiya = new Shobe("Urologiya");

            //Hekimler yaranir
            var Ismayil = new Hekim("Ismayil",Endokrinologiya,new IshQrafiki(true,false,true,false, true));
            var Hesen = new Hekim("Hesen", Urologiya, new IshQrafiki(false, false, true, false, false));
            var Xeyal = new Hekim("Xeyal", Stomotologiya, new IshQrafiki(true, false, true, false, true));
            var Vezir = new Hekim("Vezir", Travmatologiya, new IshQrafiki(true, true, true, true, false));
            var Kamran = new Hekim("Kamran", Endokrinologiya, new IshQrafiki(true, true, true, false, true));
            var Baxshi = new Hekim("Baxshi", Cerrahiyye, new IshQrafiki(false, false, true, false, false));
            var Nail = new Hekim("Nail", Oftolmoloq, new IshQrafiki(true, true, true, false, false));

            string UserInput = "";
            Hekim heminHekim = new Hekim();

            Console.Write("Salam xeste zehmet olmasa adinizi daxil edin...\nAd: ");
            string ad = Console.ReadLine();
            int ShobeNomresi;
            int hekimNomre;
            while (UserInput!="exit")
            {
            Console.Write($"Salam xeste {ad} shobeni secin...\n");
            Shobe.ShobeleriGoster();
            ShobeNomresi = int.Parse(Console.ReadLine());
            for (int i = 0; i < Xestexana.Shobeler.Count; i++)
            {
                if (i==ShobeNomresi-1)
                {
                    Console.WriteLine($"Shobe: {Xestexana.Shobeler[i].ShobeAd}\n\n");
                        int count = i;
                    foreach (var item in Xestexana.Shobeler[i].Hekimler)
                    {
                            Console.Write($"" +
                                $"\n{count+1}.");
                            item.QrafikiGoster();
                    }

                        Console.Write($"Hekiminizi secin:");
                        hekimNomre = int.Parse(Console.ReadLine());
                        Xestexana.Shobeler[count].Hekimler[hekimNomre - 1].QrafikiGoster();
                        Console.Write("Gorush saatinizi secin:");
                        int saat = int.Parse(Console.ReadLine());
                        if (Xestexana.Shobeler[count].Hekimler[hekimNomre - 1].IshSaati.IshSaatlari[saat-1] == true)
                        {
                            Console.WriteLine("Secdiyiniz saatda hekim vaxti yoxdu");
                        }
                        else
                        {
                            Console.WriteLine($"Goruwunuz teyin edildi..");
                            Xestexana.Shobeler[count].Hekimler[hekimNomre - 1].IshSaati.IshSaatlari[saat - 1] = true;
                        }
                    }
            }

                Console.WriteLine("Proqramdan cixmaq ucun exit sozunu daxil edin.");
                UserInput = Console.ReadLine();
            }
        }
    }
}
