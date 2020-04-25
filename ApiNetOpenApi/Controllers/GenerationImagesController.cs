using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerationImagesController : ControllerBase
    {
        // GET: api/GenerationImage
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GenerationImage/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var prob = 
            return "value";
        }

        // POST: api/GenerationImage
        [HttpPost]
        public void Post([FromBody] PGGAN network)
        {
            //return 
        }

        // PUT: api/GenerationImage/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
