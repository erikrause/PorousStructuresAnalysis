using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDomain.Entities;
using ApiService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        IService Service;
        public ApiController(IService service)
        {
            Service = service;
        }
        // GET: api/Api
        [HttpGet]
        public IEnumerable<Entity> Get()
        {
            return Service.GetAll();
        }

        // GET: api/Api/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Api
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Api/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
