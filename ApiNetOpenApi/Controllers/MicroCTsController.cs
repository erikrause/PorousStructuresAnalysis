using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetMicroCTServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicroCTsController : ControllerBase
    {
        IMicroCTService MicroCTService;

        // GET: api/MicroCT
        [HttpGet]
        public IEnumerable<MicroCT> Get()
        {
            //return MicroCTService.GetAll();
            return null;
        }

        // GET: api/MicroCT/5
        [HttpGet("{id}")]
        public async Task<MicroCT> Get(int id)
        {
            return await MicroCTService.Get(id);
        }

        // POST: api/MicroCT
        [HttpPost]
        public void Post([FromBody] MicroCT microCT)
        {
        }

        // PUT: api/MicroCT/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MicroCT microCT)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
