using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository
    {
        Task<T> Get<T>(int id) where T : Entity;
        Task Save<T>(T entity) where T : Entity;
        Task<IEnumerable<T>> GetAll<T>() where T : Entity;
        Task Remove<T>(T entity) where T : Entity;
        Task<IEnumerable<T>> GetBy<T>(Expression<Func<T, bool>> predicate) where T : Entity;
    }
}
