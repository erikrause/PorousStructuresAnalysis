using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetGenerationNetworkServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PGGANsController : ControllerBase
    {
        IGenerationService GenerationService;

        // GET: api/GenerationNetwork
        [HttpGet]
        public async Task<IEnumerable<PGGAN>> Get()
        {
            return await GenerationService.GetAll();
        }

        // GET: api/GenerationNetwork/5
        [HttpGet("{id}")]
        public async  Task<PGGAN> Get(int id)
        {
            return await GenerationService.Get(id);
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

        [HttpPost]
        [Route("{id}/Trainings")]
        public void PostTraining(int networkId)
        {

        }
    }
}
