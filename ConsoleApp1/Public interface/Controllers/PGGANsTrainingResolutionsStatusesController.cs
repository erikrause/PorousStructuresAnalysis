using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCRUDServiceBase;
using ApiNetPGGANTrainingResolutionStatus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs")]
    [ApiController]
    public class PGGANsTrainingResolutionsStatusesController : ControllerBase
    {
        readonly IPGGANTrainingResolutionStatusService _resolutionStatusService;

        [HttpGet("{pGGANId}/Training/ResolutionsStatuses/{id}")]
        public Task<PGGANTrainingResolutionStatus> Get(int pGGANId, int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{pGGANId}/Training/ResolutionsStatuses/")]
        public Task<IEnumerable<PGGANTrainingResolutionStatus>> Get(int pGGANId)
        {
            throw new NotImplementedException();
        }
    }
}