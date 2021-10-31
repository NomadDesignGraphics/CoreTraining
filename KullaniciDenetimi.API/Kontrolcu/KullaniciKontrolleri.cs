using Bogus;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using KullaniciDenetimi.API.Gecici;
using KullaniciDenetimi.API.Modeller;

namespace KullaniciDenetimi.API.Kontrolcu
{
    [Route("load")]
    public class KullaniciKontrolleri : ControllerBase
    {
        private List<Kullanici> kullanicilar = GeciciVeri.GetKullanicilar(200);
        
        [Route("test")]
        public class TEST
        {
            public string VeriAl() { return "Kullanicilari al"; }
        }

        
        public List<Kullanici> GetKullanici()
        {
            return kullanicilar;
        }
        [HttpGet("{id}")]
        public Kullanici GetKullanici(int id)
        {
            var KLLNC = kullanicilar.FirstOrDefault(x => x.ID == id);
            return KLLNC;
        }
        [HttpPost]
        public Kullanici Post([FromBody]Kullanici kullanici)
        {
            kullanicilar.Add(kullanici);
            return kullanici;
        }

        [HttpPut]
        public Kullanici Put([FromBody] Kullanici kullanici)
        {
            var ellenenkullanici = kullanicilar.FirstOrDefault(x => x.ID == kullanici.ID);
            ellenenkullanici.Ad = kullanici.Ad;
            ellenenkullanici.SoyAd = kullanici.SoyAd;
            ellenenkullanici.adres = kullanici.adres;
            return kullanici;
        }

        [HttpDelete]
        public void Sil(int id)
        {
            var SilinecekKullanici = kullanicilar.FirstOrDefault(x => x.ID == id);
            kullanicilar.Remove(SilinecekKullanici);
        }
    }
}
