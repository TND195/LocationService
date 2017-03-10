using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class RatesController : ApiController
    {
        public bool Put([FromBody]Rates dg)
        {
            RatesDAO dgO = new RatesDAO();
            if (!dgO.insertDanhGia(dg))
            {
              return  dgO.updateDanhGia(dg);
            }
            return true;
        }
        public float Get(int madiadiem)
        { 
            RatesDAO dgO = new RatesDAO();
            return dgO.getRate(madiadiem);
        }
    }
}