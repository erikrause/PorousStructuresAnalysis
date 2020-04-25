using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCRUDServiceBase
{
    public interface ICRUDService<T> where T : Entity
    {
        Task Create(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetBy(Expression<Func<T, bool>> predicate);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
