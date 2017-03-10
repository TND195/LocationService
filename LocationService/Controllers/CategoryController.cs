using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class CategoryController : ApiController
    {
        
        public IEnumerable<Category> Get()
        {
       
            CategoryDAO dvO = new CategoryDAO();

            Category[] dv = new Category[dvO.getDsDichVu().Count];
            dv = dvO.getDsDichVu().ToArray();
            return dv;
        }
    }
}