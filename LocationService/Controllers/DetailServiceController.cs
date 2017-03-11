using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class DetailServiceController : ApiController
    {
        // GET api/<controller>
        public List<DetailService> Get_DanhSach_DichVu(int id)
        {
            DetailServiceDAO detail = new DetailServiceDAO();
            List<DetailService> list = detail.get_ChiTiet_DichVu(id);

            return list;
        }
    }
}