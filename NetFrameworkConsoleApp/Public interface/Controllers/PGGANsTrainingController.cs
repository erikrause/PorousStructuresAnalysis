using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetPGGANsTrainingServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs/")]
    [ApiController]
    public class PGGANsTrainingController : ControllerBase
    {
        readonly IPGGANTrainingService _pGGANsTrainingService;
        [HttpGet("{pGGANId}/Training")] 
        public PGGANTraining Get(int pGGANId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Change training status.
        /// </summary>
        /// <param name="pGGANId"></param>
        /// <param name="status"> "InProgress", "Stopped" </param>
        [HttpPut("{pGGANId}/Training")]
        public void Put(int pGGANId, [FromBody] string status)
        {
        }
    }
}
