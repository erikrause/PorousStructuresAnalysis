using ApiDomain.Entities;
using ApiDomain.Entity_Framework;
using ApiDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApiDomain.EntityFramework
{
    public class SQLRepository : IRepository
    {
        ApiContext db;

        public SQLRepository(string connectionString)
        {
            db = new ApiContext(connectionString);
        }
        public T Get<T>(int id) where T : Entity
        {
            return db.Set<T>().SingleOrDefault(t => t.Id == id);
        }
        public void Save<T>(T entity) where T : Entity
        {
            if (entity.Id < 1)
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
            else
            {
                var cache = db.Set<T>().Find(entity.Id);
                db.Entry<T>(cache).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }
        }
        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            return db.Set<T>().OrderBy(t => t.Id).ToList().AsQueryable();
        }
        public void Remove<T>(T entity) where T : Entity
        {
            var cache = db.Set<T>().Find(entity.Id);    //Todo
            db.Set<T>().Remove(cache);
        }
        public IEnumerable<T> GetBy<T>(Expression<Func<T, bool>> predicate) where T : Entity
        {
            return db.Set<T>().Where(predicate).ToList();
        }
    }
}
