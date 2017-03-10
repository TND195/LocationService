using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class CommentController : ApiController
    {
        public IEnumerable<Comment> Get(int id)
        {
            CommentDAO blO = new CommentDAO();
            List<Comment> list = blO.getDsBinhLuan(id);
            return list;
        }

        // POST: api/BinhLuan
  
        public bool Post([FromBody]Comment bl)
        {
            CommentDAO blO = new CommentDAO();
            return blO.insertBinhLuan(bl);
        }
    }
}