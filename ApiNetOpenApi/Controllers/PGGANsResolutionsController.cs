using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetPGGANResolutionServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs")]
    [ApiController]
    public class PGGANsResolutionsController : ControllerBase
    {
        readonly IPGGANResolutionService _resolutionService;

        [HttpGet("{pGGANId}/Resolutions/{id}")]
        public Task<PGGANResolution> Get(int pGGANId, int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{pGGANId}/Resolutions")]
        public Task<IEnumerable<PGGANResolution>> GetAll(int pGGANId)
        {
            throw new NotImplementedException();
        }
        [HttpPost("{pGGANId}/Resolutions")]
        public Task Post(int pGGANId, [FromBody] PGGANResolution pGGANResolution)
        {
            throw new NotImplementedException();
        }
        [HttpPut("{pGGANId}/Resolutions/{id}")]
        public Task Put(int pGGANId, int id, [FromBody] PGGANResolution pGGANResolution)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Удаляет последний слой.
        /// </summary>
        /// <param name="pGGANId"></param>
        /// <returns></returns>
        [HttpDelete("{pGGANId}/Resolutions/")]
        public Task Delete(int pGGANId)
        {
            throw new NotImplementedException();
        }
    }
}