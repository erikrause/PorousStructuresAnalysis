using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetGenerationImageServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs/")]
    [ApiController]
    public class GenerationImagesController : ControllerBase
    {
        readonly IGenerationImageService _generationImageService;
        [HttpGet("{pGGANId}/[controller]")]
        public Task<IEnumerable<GeneratedImage>> Get(int pGGANId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{pGGANId}/[controller]/{id}")]
        public Task<GeneratedImage> Get(int pGGANId, int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{pGGANId}/[controller]")]
        public void Post(int pGGANId, [FromBody] ControlVariables controlVariables)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{pGGANId}/[controller]/{id}")]
        public void Delete(int pGGANId, int id)
        {
        }
    }
}
