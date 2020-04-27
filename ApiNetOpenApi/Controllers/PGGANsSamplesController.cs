using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetPGGANSampleServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs")]
    [ApiController]
    public class PGGANsSamplesController : ControllerBase
    {
        readonly IPGGANSampleService _pGGANSampleService;

        [HttpGet("{pGGANId}/Training/ResolutionsStatuses/{resolutionStatusId}/Samples")]
        public async Task<IEnumerable<PGGANSample>> Get(int pGGANId, int resolutionStatusId)
        {
            return await _pGGANSampleService.GetBy(sample => (sample.GenerationNetworkId == pGGANId) && 
                                                       (sample.PGGANResolutionTrainingStatusId == resolutionStatusId));
        }
        [HttpGet("{pGGANId}/Training/ResolutionsStatuses/{resolutionStatusId}/Samples/{id}")]
        public async Task<PGGANSample> Get(int pGGANId, int resolutionStatusId, int id)
        {
            return (await _pGGANSampleService.GetBy(sample => (sample.GenerationNetworkId == pGGANId) &&
                                                       (sample.PGGANResolutionTrainingStatusId == resolutionStatusId) && 
                                                       (sample.Id == id))).FirstOrDefault();
        }
    }
}