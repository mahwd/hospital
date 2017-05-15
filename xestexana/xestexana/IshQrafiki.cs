using System;
using System.Collections.Generic;

namespace xestexana
{
    class IshQrafiki
    {
        public List<bool> IshSaatlari = new List<bool>();
        public List<string> qrafik = new List<string>();
        public string BirinciNovbe = "08:00 - 10:00";
        public string IkinciNovbe = "10:00 - 12:00";
        public string UcuncuNovbe = "12:00 - 14:00";
        public string DorduncuNovbe = "14:00 - 16:00";
        public string BesinciNovbe = "16:00 - 18:00";

        public IshQrafiki(bool birinciNovbe, bool ikinciNovbe, bool ucuncuNovbe, bool dorduncuNovbe, bool besinciNovbe)
        {
            IshSaatlari.Add(birinciNovbe);
            IshSaatlari.Add(ikinciNovbe);
            IshSaatlari.Add(ucuncuNovbe);
            IshSaatlari.Add(dorduncuNovbe);
            IshSaatlari.Add(besinciNovbe);
            foreach (var item in IshSaatlari)
            {
                if (item == true)
                {
                    qrafik.Add("Dolu");
                }
                else
                {
                    qrafik.Add("Bosh");
                }
            }
        }
    }
}
