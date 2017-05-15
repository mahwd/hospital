using System;
using System.Collections.Generic;

namespace xestexana
{
    class Hekim
    {
        public string HekimAd;
        public Shobe HekimShobe;
        public IshQrafiki IshSaati;

        public Hekim()
        {

        }

        public Hekim(string hekimAd,Shobe hekimShobe,IshQrafiki ishSaati)
        {
            HekimAd = hekimAd;
            HekimShobe = hekimShobe;
            IshSaati = ishSaati;
            hekimShobe.Hekimler.Add(this);
        }
        public void QrafikiGoster()
        {
            Console.WriteLine($"Hekim: {this.HekimAd} \nIs Qrafiki: \n" +
                $"{IshSaati.BirinciNovbe}: {this.IshSaati.qrafik[0]}\n" +
                $"{IshSaati.IkinciNovbe}: {this.IshSaati.qrafik[1]}\n" +
                $"{IshSaati.UcuncuNovbe}: {this.IshSaati.qrafik[2]}\n" +
                $"{IshSaati.DorduncuNovbe}: {this.IshSaati.qrafik[3]}\n" +
                $"{IshSaati.BesinciNovbe}: {this.IshSaati.qrafik[4]}\n");
        }

            

    }
}
