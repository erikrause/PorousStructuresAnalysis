using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Threading.Tasks;

namespace ApiNetImageProcessingServiceBase
{
    public interface IImageProcessingService
    {
        Task<Image> DeleteNoise(Image image);
        Task<Image> Binarize(Image image);
        //Task GeneratePolygons(Image image);

        //Task Compress(Image image.);
    }
}