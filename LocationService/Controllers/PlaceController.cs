using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationService.Controllers
{
    [RoutePrefix("api/Place")]
    public class PlaceController : ApiController
    {
        [Route("Search")]
        [HttpGet]
        public List<Place> Get(String str)
        {

           PlaceDAO dvO = new PlaceDAO();
           List<Place> dv = dvO.Search2(str);
           return dv;
        }
        [Route("Category")]
        [HttpGet]
        public List<Place> GetCategory(String str)
        {

            PlaceDAO dvO = new PlaceDAO();
            List<Place> dv = dvO.GetCategory(str);
            return dv;
        }
        public Place Get(int id)
        {
            PlaceDAO placeDAO = new PlaceDAO();
            Place place = placeDAO.getPlace(id);
            return place;
        }
    }
}