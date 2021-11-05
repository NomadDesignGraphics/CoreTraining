using AreaHelper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinder.Business.Abstract
{
    public interface IntrfcAreaService
    {
        /*
         * ELDEKİ BÜTÜN VERİLERİ ÇAĞIR LİSTE HALİNDE
        */
        List<Area> GetirButunArealari();
        /*
         * ID Sİ NE İSE ONU ÇAĞIRACAK SİSTEM
        */
        Area AreaCagirID(int ID);
        /*
         * YENİ ARENA YARAT
        */
        Area yaratArea(Area area);
        /*
         * AREA VERİSİNİ GÜNCELLE
        */
        Area GuncelleArea(Area area);
        /*
         * CLASS TA BELİRTTİĞİMİ DÜŞÜNÜYORUM NE İŞE YARADIĞINI
        */
        void SilArea(int ID);
    }
}
