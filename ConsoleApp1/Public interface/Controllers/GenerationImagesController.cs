using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetGenerationImageServiceBase;
using ApiNetOpenApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs/")]
    [ApiController]
    public class GenerationImagesController : ControllerBase
    {
        readonly IGenerationImageService _generationImageService;
        [HttpGet("{pGGANId}/[controller]")]
        public Task<IEnumerable<GeneratedImageGetModel>> Get(int pGGANId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{pGGANId}/[controller]/{id}")]
        public Task<GeneratedImageGetModel> Get(int pGGANId, int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{pGGANId}/[controller]")]
        public void Post(int pGGANId, [FromBody] ControlVariablesModel controlVariables)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{pGGANId}/[controller]/{id}")]
        public void Delete(int pGGANId, int id)
        {
        }
    }
}
