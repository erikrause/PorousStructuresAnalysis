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
    /// <summary>
    /// Генерация трехмерных моделей
    /// </summary>
    [Route("api/Images")]
    [ApiController]
    public class PolygonalModelsController : ControllerBase
    {
        readonly IPolygonalModelingService _polygonalModelingService;
        public PolygonalModelsController(IPolygonalModelingService polygonalModelingService)
        {
            _polygonalModelingService = polygonalModelingService;
        }
        /// <summary>
        /// Сгенерировать трехмерную полигональную модель на основе вокселей
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        [HttpPost("{imageId}/PolygonalModel")]
        public Task<ActionResult<PolygonalModel>> Post(int imageId)
        {
            throw new NotImplementedException();
        }
    }
}