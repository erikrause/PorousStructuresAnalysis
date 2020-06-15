using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetPGGANServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PGGANsController : ControllerBase
    {
        readonly IPGGANService _pGGANService;

        // GET: api/GenerationNetwork
        [HttpGet]
        public async Task<IEnumerable<PGGAN>> Get()
        {
            return await _pGGANService.GetAll();
        }

        // GET: api/GenerationNetwork/5
        [HttpGet("{id}")]
        public async  Task<PGGAN> Get(int id)
        {
            return await _pGGANService.Get(id);
        }

        // POST: api/GenerationNetwork
        [HttpPost]
        public void Post([FromBody] PGGAN network)
        {
        }

        // PUT: api/GenerationNetwork/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PGGAN network)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
