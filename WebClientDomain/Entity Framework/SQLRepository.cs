using WebClientDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebClientDomain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebClientDomain.Entity_Framework
{
    public class SQLRepository : IRepository
    {
        readonly WebClientDbContext db;
        public UserStore<IdentityUser> UserStore { get; private set; }
        public RoleStore<IdentityRole> RoleStore { get; private set; }
        public SQLRepository(string connectionString)
        {
            db = new WebClientDbContext();
            UserStore = new UserStore<IdentityUser>(db);
            RoleStore = new RoleStore<IdentityRole>(db);
        }
        public async Task<T> Get<T>(int id) where T : Entity
        {
            return await db.Set<T>().SingleOrDefaultAsync(t => t.Id == id);
        }
        public async Task Create<T>(T entity) where T : Entity
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
            //return await db.Set<T>().OrderBy(t => t.Id).ToListAsync();//.AsQueryable(); // спросить у Егорова
            var result = await db.Set<T>().OrderBy(t => t.Id).ToListAsync();
            return result.AsQueryable();    // спросить у егорова
        }
        public async Task Delete<T>(T entity) where T : Entity
        {
            var cache = await db.Set<T>().FindAsync(entity.Id);    //Todo
            db.Set<T>().Remove(cache);
            await db.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetBy<T>(Expression<Func<T, bool>> predicate) where T : Entity
        {
            var result = await db.Set<T>().Where (predicate).ToListAsync();
            return result;
        }

        public async Task Update<T>(T entity) where T : Entity
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
        public void Dispose()     // Async?
        {
            db.Dispose();
        }
    }
}
