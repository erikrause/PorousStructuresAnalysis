using ApiNetPolygonalModelingServiceBase;
using ApiNetPolygonalModelingServiceImpl.Models;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;
using OpenApiSqlDomain.Interfaces;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace ApiNetPolygonalModelingServiceImpl
{
    public class PolygonalModelingService : IPolygonalModelingService
    {
        IRepository _repository;
        public PolygonalModelingService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task ComputePolygons(Image image)
        {
            var client = new RestClient("http://127.0.0.1:5001/");
            var request = new RestRequest("compute", Method.POST, DataFormat.Json);

            PolygonsRequest polygonsRequest = new PolygonsRequest
            {
                VoxelArray = Convert.ToBase64String(image.VoxelArray),
                VoxelArrayFormat = image.VoxelArrayFormat
            };
            request.AddJsonBody(polygonsRequest);

            var response = client.Execute(request);

            image.PolygonalModel = new PolygonalModel
            {
                RockFaces = response.RawBytes
            };
            //await _repository.Update(image);
        }
    }
}
