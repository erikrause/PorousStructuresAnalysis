using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetPorousImageServiceBase
{
    public interface IPorousImageService
    {
        Task ComputeProperties(PorousStructuresImage image);
        Task<IEnumerable<PorousStructuresImage>> GetAll();
        Task<PorousStructuresImage> Get(int id);
        //Task Update(PorousStructuresImage image);
    }
}
