using ApiDomain.Entities;
using ApiDomain.Entity_Framework;
using ApiDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain.EntityFramework
{
    public class SQLRepository : IRepository
    {
        ApiContext db;

        public SQLRepository(string connectionString)
        {
            db = new ApiContext(connectionString);
        }
        public async Task<T> Get<T>(int id) where T : Entity
        {
            return await db.Set<T>().SingleOrDefaultAsync(t => t.Id == id);
        }
        public async Task Save<T>(T entity) where T : Entity
        {
            if (entity.Id < 1)
            {
                db.Set<T>().Add(entity);
                await db.SaveChangesAsync();
            }
            else
            {
                var cache = db.Set<T>().Find(entity.Id);
                db.Entry<T>(cache).CurrentValues.SetValues(entity);
                await db.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<T>> GetAll<T>() where T : Entity
        {
            var result = await db.Set<T>().OrderBy(t => t.Id).ToListAsync();
            return result.AsQueryable();
        }
        public async Task Remove<T>(T entity) where T : Entity
        {
            var cache = db.Set<T>().Find(entity.Id);    //Todo
            db.Set<T>().Remove(cache);
            await db.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetBy<T>(Expression<Func<T, bool>> predicate) where T : Entity
        {
            return await db.Set<T>().Where(predicate).ToListAsync();
        }
    }
}
