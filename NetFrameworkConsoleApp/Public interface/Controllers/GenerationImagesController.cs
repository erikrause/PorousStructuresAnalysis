using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
using ApiNetGenerationImageServiceBase;
using ApiNetOpenApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetOpenApi.Controllers
{
    [System.Web.Http.Route("api/PGGANs/")]
    //[ApiController]
    public class GenerationImagesController : ControllerBase
    {
        readonly IGenerationImageService _generationImageService;

        public Task<IEnumerable<GeneratedImageResponse>> Get(int pGGANId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneratedImageResponse> Get(int pGGANId, int id)
        {
            throw new NotImplementedException();
        }

        public void Post(int pGGANId, [FromBody] ControlVariablesRequest controlVariables)
        {
            throw new NotImplementedException();
        }

        public void Delete(int pGGANId, int id)
        {
        }
    }
}
