using BLL.Interfaces;
using DAL.Entities;
using DAL.Entity_Framework;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProbService : IProbService
    {
        IRepository repo;

        public ProbService(IRepository repository)
        {
            repo = repository;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            //var date = new DateTime(DateTime.Now.Day - 0);
            return await repo.GetBy<User>(t => t.Id > 0);
        }
        public async Task NewUser()
        {
            var p = new User()
            {
                Login = "erikrause",
                PasswordHash = "hello",
                RegistrationDate = DateTime.Now,
                Role = "admin"
            };
            await repo.Save(p);
        }
        public async Task<IEnumerable<GeneratedSample>> GetGeneratedSamples()
        {
            //var date = new DateTime(DateTime.Now.Day - 0);
            return await repo.GetBy<GeneratedSample>(t => t.Id > 0);
        }
        public async Task NewGeneratedSample()
        {
            var p = new GeneratedSample()
            {
                Accuracy = 0.5,
                CavernsVolume = 0.75,
                Resolution = "разрешение"
            };
            await repo.Save(p);
        }
        public async Task DeleteGeneratedSample(int id)
        {
            var sample = await repo.Get<GeneratedSample>(id);
            await repo.Remove(sample);
        }
    }
}
