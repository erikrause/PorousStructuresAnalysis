using OpenApiSqlDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MicroCTServiceBase
{
    public interface IMicroCTService
    {
        Task Create(MicroCT microCT);
        Task Get(int id);
        Task<IEnumerable<MicroCT>> GetAll();
        Task<IEnumerable<MicroCT>> GetBy(Expression<Func<MicroCT, bool>> predicate);
        Task Update(MicroCT microCT);
        Task Delete(MicroCT microCT);
    }
}
