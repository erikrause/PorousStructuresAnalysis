using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetOpenApi.Models.Post;
using ApiNetPGGANServiceBase;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Enumerators;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PGGANsController : ControllerBase
    {
        readonly IPGGANService _pGGANService;
        readonly Mapper _mapper;
        public PGGANsController(IPGGANService pGGANService)
        {
            _pGGANService = pGGANService;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PGGANPostModel, PGGAN>());
            _mapper = new Mapper(config);

        }
        // GET: api/GenerationNetwork
        [HttpGet]
        public async Task<IEnumerable<PGGAN>> Get()
        {
            return await _pGGANService.GetAll();
        }

        // GET: api/GenerationNetwork/5
        /// <summary>
        /// Получить модель нейронной сети
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async  Task<PGGAN> Get(int id)
        {
            return await _pGGANService.Get(id);
        }

        // POST: api/GenerationNetwork
        /// <summary>
        /// Создать модель нейронной сети
        /// </summary>
        /// <param name="network"> Гиперпараметры нейронной сети </param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> Post([FromBody] PGGANPostModel network)
        {
            PGGAN pGGAN = new PGGAN
            {
                CreatedDate = DateTime.Now,
                CriticSteps = 5,
                Channels = 1,
                Cashed = false,
                ConvolutionalActivations = ConvolutionalActivation.LeakyReLU,
                GeneratorOutputActivation = GeneratorOutputActivation.Tanh,
                HiddenShape = 256,
                ImageScaleX = 64,
                ImageScaleY = 64,
                ImageScaleZ = 64,
                //NetworkModel = File.ReadAllBytes("cwgan_generator.h5"),
                Optimizer = Optimizer.Adam,
                ReLUAlpha = 0.1f,
                Type = NetworkType.CWGAN,
                WeightInitializer = "he_normal"
            };
            return await _pGGANService.Create(pGGAN);
        }

        // PUT: api/GenerationNetwork/5
        /// <summary>
        /// Обновить существующую модель нейронной сети
        /// </summary>
        /// <param name="id"></param>
        /// <param name="network"> Гиперпараметры нейронной сети </param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PGGANPostModel network)
        {
            PGGAN pGGAN = _mapper.Map<PGGAN>(network);
            _pGGANService.Update(pGGAN);
        }

        [HttpPut("{id}/cached")]
        public void PutCache(int id, bool cached)
        {
            if (cached == true)
            {
                _pGGANService.InitGenerator(id);
            }
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Удалить существующую модель нейронной сети
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
