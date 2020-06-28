using OpenApiSqlDomain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetGenerationImageServiceBase
{
    public interface IGenerationImageService
    {
        Task<GeneratedImage> Generate(int pGGANId, ControlVariables controlVariables);
        Task<GeneratedImage> Get(int id);
        Task<IEnumerable<GeneratedImage>> GetAll();
        Task Update(int id, ControlVariables controlVariables);
        Task Delete(int id);
    }
}
