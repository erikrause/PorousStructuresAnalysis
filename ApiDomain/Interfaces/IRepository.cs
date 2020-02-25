using ApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApiDomain.Interfaces
{
    public interface IRepository
    {
        T Get<T>(int id) where T : Entity;
        void Save<T>(T entity) where T : Entity;
        IEnumerable<T> GetAll<T>() where T : Entity;
        void Remove<T>(T entity) where T : Entity;
        IEnumerable<T> GetBy<T>(Expression<Func<T, bool>> predicate) where T : Entity;
    }
}
