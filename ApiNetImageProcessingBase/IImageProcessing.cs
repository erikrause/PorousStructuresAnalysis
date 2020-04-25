using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Threading.Tasks;

namespace ApiNetImageProcessingBase
{
    public interface IImageProcessing
    {
        Task<Image> DeleteNoise(Image image);
        Task<Image> Binarize(Image image);
        Task GeneratePolygons(Image image);
        
        //Task Compress(Image image.);
    }
}
