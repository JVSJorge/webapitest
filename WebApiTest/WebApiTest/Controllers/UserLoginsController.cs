using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using DataModel;

namespace WebApiTest.Controllers
{
    public class UserLoginsController : ApiController
    {
        // GET: api/UserLogins
        public IQueryable<UserLogin> GetUserLogins()
        {
            BLUserLogin userLogin = new BLUserLogin();
            return userLogin.GetUserLogins();
        }

        // GET: api/UserLogins/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserLogins
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserLogins/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserLogins/5
        public void Delete(int id)
        {
        }
    }
}
