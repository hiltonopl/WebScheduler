using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebScheduler.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET: api/Values
    

        // GET: api/Values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }

       
         // GET api/values
            public string Get()
            {
                var userName = this.RequestContext.Principal.Identity.Name;
                return String.Format("Hello, {0}.", userName);
            }
       
    }
}
