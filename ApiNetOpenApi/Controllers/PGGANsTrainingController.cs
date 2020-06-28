using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetPGGANsTrainingServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs/")]
    [ApiController]
    //[SwaggerDefaultResponse()]
    public class PGGANsTrainingController : ControllerBase
    {
        readonly IPGGANsTrainingService _pGGANsTrainingService;
        [HttpGet("{pGGANId}/Training")] 
        public ActionResult<PGGANTraining> Get(int pGGANId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Change training status.
        /// </summary>
        /// <param name="pGGANId"></param>
        /// <param name="status"> "InProgress", "Stopped" </param>
        [HttpPut("{pGGANId}/Training")]
        public ActionResult<PGGANTraining> Put(int pGGANId, [FromBody] string status)
        {
            throw new NotImplementedException();
        }
    }
}
