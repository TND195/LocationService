using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class PlaceController : ApiController
    {
        // GET api/<controller>
        public List<Place> Get(String str)
        {

           PlaceDAO dvO = new PlaceDAO();
           List<Place> dv = dvO.Search(str);
           return dv;
        }
    }
}