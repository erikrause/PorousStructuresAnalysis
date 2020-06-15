using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetPolygonalModelingServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/Images")]
    [ApiController]
    public class PolygonalModelsController : ControllerBase
    {
        readonly IPolygonalModelingService _polygonalModelingService;

        [HttpGet("{imageId}/PolygonalModel")]
        public Task<PolygonalModel> Get(int imageId)
        {
            throw new NotImplementedException();
        }
    }
}