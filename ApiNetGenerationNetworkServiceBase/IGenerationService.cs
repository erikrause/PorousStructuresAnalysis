using OpenApiSqlDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiNetGenerationNetworkServiceBase
{
    public interface IGenerationService
    {
        Task Create(GenerationNetwork network);
        Task Save(GeneratedImage image);
        Task Save(GeneratedSample sample);
        Task GenerateImage(GenerationNetwork network);
        Task<GenerationNetwork> Get(int id);
        Task<IEnumerable<GenerationNetwork>> GetAll();
        Task<IEnumerable<GenerationNetwork>> GetBy(Expression<Func<GenerationNetwork, bool>> predicate);
        Task Update(GenerationNetwork network);
        Task Delete(GenerationNetwork network);
        Task StartTraining(int networkId);
        Task InterruptTraining(int networkId);
    }
}
