using InventorySystem.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InventorySystem.Contract;

namespace InventorySystem.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        GuideManager _guideManager = new GuideManager();

        // GET api/values
        public IEnumerable<string> Get()
        {
            _guideManager.CreateUnit(new Unit(){Name = "New Unit From Web Api"});
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}