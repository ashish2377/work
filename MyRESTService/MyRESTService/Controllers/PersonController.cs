using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyRESTService.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        // GET: api/Person
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "Ashish", "Amit","Shubham", "Aashay" };
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var strArray = new[] { "Ashish", "Amit", "Shubham", "Aashay" };
            return strArray[id];
        }
        
        // POST: api/Person
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
