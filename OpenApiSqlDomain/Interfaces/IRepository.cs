using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiSqlDomain.Interfaces
{
    public interface IRepository : IDisposable
    {
        Task<T> Get<T>(int id) where T : Entity;
        Task Create<T>(T entity) where T : Entity;
        Task<IEnumerable<T>> GetAll<T>() where T : Entity;
        Task Delete<T>(T entity) where T : Entity;
        Task<IEnumerable<T>> GetBy<T>(Expression<Func<T, bool>> predicate) where T : Entity;
        Task Update<T>(T enity) where T : Entity;
    }
}
