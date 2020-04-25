﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs/[controller]")]
    [ApiController]
    public class PGGANsTrainingController : ControllerBase
    {
        // GET: api/Trainings
        [HttpGet]
        public Task<IEnumerable<PGGANTraining>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Trainings/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Trainings
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Trainings/5
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
