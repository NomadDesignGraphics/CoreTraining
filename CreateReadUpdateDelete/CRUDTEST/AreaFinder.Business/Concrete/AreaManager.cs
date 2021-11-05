using AreaFinder.Business.Abstract;
using AreaHelper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AreaFinder.AreaDBContext;

namespace AreaFinder.Business.Concrete
{
    public class AreaController : IntrfcAreaService
    {
        //private IntrfcAreaService _AreaRepository;

        //public AreaController(IntrfcAreaService e)
        //{
        //    _AreaRepository = e;        
        //}


        public Area AreaCagirID(int ID)
        {
            using (var icerik = new MyClass())
            {
                return icerik.areas.Find(ID);
            }
        }

        public List<Area> GetirButunArealari()
        {
            using (var context = new MyClass())
            {
                return context.areas.ToList();
            }
        }

        public Area GuncelleArea(Area area)
        {
            using (var icerik = new MyClass())
            {
                icerik.areas.Update(area);
                return area;
            }
        }

        public void SilArea(int ID)
        {
            using (var AreaDestek = new MyClass())
            {
                var SilincekArea = AreaCagirID(ID);
                AreaDestek.areas.Remove(SilincekArea);
                AreaDestek.SaveChanges();
            }
        }

        public Area yaratArea(Area area)
        {
            using (var icerik = new MyClass())
            {
                icerik.areas.Add(area);
                icerik.SaveChanges();
                return area;
            }
        }
    }
    
}
