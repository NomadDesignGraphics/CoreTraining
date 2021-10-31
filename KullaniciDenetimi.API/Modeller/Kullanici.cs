using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KullaniciDenetimi.API.Modeller
{
    public class Kullanici
    {
        public int ID { get; set; }

        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string adres { get; set; }
    }
}
