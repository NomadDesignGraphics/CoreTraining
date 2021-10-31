using Bogus;
using KullaniciDenetimi.API.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KullaniciDenetimi.API.Gecici
{
    public static class GeciciVeri
    {
        private static List<Kullanici> kullanicilar;

        public static List<Kullanici> GetKullanicilar(int adet)
        {
            if (kullanicilar ==null)
            {
            kullanicilar = new Faker<Kullanici>()
                .RuleFor(u => u.ID, f => f.IndexFaker+1)
                .RuleFor(u => u.Ad, f => f.Name.FirstName())
                .RuleFor(u => u.SoyAd, f => f.Name.LastName())
                .RuleFor(u => u.adres, f => f.Address.FullAddress())
                .Generate(adet);
            }
            return kullanicilar;
        }
    }
}
