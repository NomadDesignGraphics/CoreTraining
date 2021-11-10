using AreaFinder.Business.Abstract;
using AreaFinder.Business.Concrete;
using AreaHelper.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AreaFinder.API.Kontrolculer
{

    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {

        private IntrfcAreaService _AreaService;

        public AreaController(IntrfcAreaService e)
        {
           _AreaService = e;
        }

        [HttpGet]
        public List<Area> GetAll()
        {
           
            return _AreaService.GetirButunArealari();
        }

        [HttpGet("{ID}")]
        public Area Get(int ID)
        {
            return _AreaService.AreaCagirID(ID);
        }

        [HttpPost]
        public Area Gonder([FromBody]Area area)
        {
            return _AreaService.yaratArea(area);
        }

        [HttpPut]
        public Area Guncelle([FromBody] Area area)
        {
            return _AreaService.GuncelleArea(area);
        }


        [HttpDelete("{id}")]
        public void SIL(int ID)
        {
            _AreaService.SilArea(ID);            
        }
    }
}
