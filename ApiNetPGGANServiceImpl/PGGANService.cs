using ApiNetPGGANServiceBase;
using ApiNetPGGANServiceImpl.Models;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiNetPGGANServiceImpl
{
    public class PGGANService : IPGGANService
    {
        IRepository _repository;
        public PGGANService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Create(PGGAN entity)
        {
            entity.NetworkModel = await File.ReadAllBytesAsync("cwgan_generator.h5");
            await _repository.Create(entity);

            return entity.Id;
        }
        public async Task InitGenerator(int pGGANId)
        {
            var client = new RestClient("http://127.0.0.1:5000/");
            var request = new RestRequest("init_generator", Method.POST, DataFormat.Json);

            PGGAN pGGAN = await _repository.Get<PGGAN>(pGGANId);

            InitGeneratorRequest body = new InitGeneratorRequest
            {
                GeneratorModel = Convert.ToBase64String(pGGAN.NetworkModel)
            };
            request.AddJsonBody(body);
            var response = await Task.Run(() => client.Execute(request));
        }

        public Task Delete(PGGAN entity)
        {
            throw new NotImplementedException();
        }

        public Task<PGGAN> Get(int id)
        {
            return _repository.Get<PGGAN>(id);
        }

        public Task<IEnumerable<PGGAN>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PGGAN>> GetBy(Expression<Func<PGGAN, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task Update(PGGAN entity)
        {
            await _repository.Update(entity);
        }
    }
}
