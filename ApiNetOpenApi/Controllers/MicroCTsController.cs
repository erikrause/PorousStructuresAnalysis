using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetMicroCTServiceBase;
using ApiNetOpenApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicroCTsController : ControllerBase
    {
        readonly IMicroCTService _microCTService;

        // GET: api/MicroCT
        /// <summary>
        /// Получить все доступные микро-КТ
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<MicroCT> Get()
        {
            //return MicroCTService.GetAll();
            return null;
        }

        /// <summary>
        /// Получить микро-КТ
        /// </summary>
        /// <param name="id"> Идентификатор микро-КТ</param>
        /// <returns></returns>
        // GET: api/MicroCT/5
        [HttpGet("{id}")]
        public async Task<MicroCT> Get(int id)
        {
            return await _microCTService.Get(id);
        }

        // POST: api/MicroCT
        /// <summary>
        /// Загрузить микро-КТ в систему
        /// </summary>
        /// <param name="microCT"></param>
        [HttpPost]
        public void Post([FromBody] MicroCT microCT)
        {
        }

        /// <summary>
        /// Обновить существующее микро-КТ
        /// </summary>
        /// <param name="id"></param>
        /// <param name="microCT"></param>
        // PUT: api/MicroCT/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MicroCT microCT)
        {
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Удалить существующее микро-КТ
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
