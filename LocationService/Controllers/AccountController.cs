using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationService.Controllers
{
    public class AccountController : ApiController
    {
        // POST: api/Account
        public bool Post([FromBody]Account tk)
        {
            AccountDAO tkO = new AccountDAO();
            return tkO.insertTaiKhoan(tk);
        }
        public bool Get(String id)
        {
            AccountDAO accDAO = new AccountDAO();
            return accDAO.Login(id);
        }
    }
}