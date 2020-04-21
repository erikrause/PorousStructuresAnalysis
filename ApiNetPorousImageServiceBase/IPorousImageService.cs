using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Threading.Tasks;

namespace ApiNetPorousImageServiceBase
{
    public interface IPorousImageService
    {
        Task Create(PorousStructuresImage image);
        Task Get
    }
}
