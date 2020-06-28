using ApiNetGenerationImageServiceBase;
using ApiNetPolygonalModelingServiceBase;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetGenerationImageServiceImplementation
{
    public class GenerationImageService : IGenerationImageService
    {
        readonly IRepository _repository;
        readonly IPolygonalModelingService _polygonalModelingService;
        //readonly Mapper _mapper;
        public GenerationImageService(IRepository repository, IPolygonalModelingService polygonalModelingService)
        {
            _repository = repository;
            _polygonalModelingService = polygonalModelingService;
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<ControlVariables, RawPredictRequest>());
            //_mapper = new Mapper(config);
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GeneratedImage> Generate(int pGGANId, ControlVariables controlVariables)
        {
            GeneratedImage generatedImage = new GeneratedImage
            {
                ControlVariables = controlVariables,
                CreatedDate = DateTime.Now,
                GenerationNetworkId = pGGANId
            };

            var client = new RestClient("http://127.0.0.1:5000/");
            var request = new RestRequest("predict/raw", Method.POST, DataFormat.Json);

            request.AddJsonBody(controlVariables);

            var response = client.Execute(request);

            generatedImage.VoxelArray = response.RawBytes;
            generatedImage.VoxelArrayFormat = "raw";

            await _polygonalModelingService.ComputePolygons(generatedImage);
            await _repository.Create(generatedImage);

            return generatedImage;      // TODO: переделать в return id.
        }

        public async Task<GeneratedImage> Get(int id)
        {
            return await _repository.Get<GeneratedImage>(id);
        }

        public Task<IEnumerable<GeneratedImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ControlVariables controlVariables)
        {
            throw new NotImplementedException();
        }
    }
}
