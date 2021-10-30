using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWEB.Controllers
{
    [Route("control")]
    public class Control : ControllerBase
    {
        [Route("kontrol")]
        public string kontrol()
        {
            return "işe yarıyor evlat";
        }

        [Route("anasayfa")]
        public string ANASAYFA()
        {
            return "ANA SAYFA işe yarıyor evlat";
        }
    }
}
