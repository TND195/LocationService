using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class CategoryController : ApiController
    {
        
        public List<Category> Get()
        {
       
            CategoryDAO dvO = new CategoryDAO();

            
             List<Category> dv = dvO.getDsDichVu();
            return dv;
        }
    }
}