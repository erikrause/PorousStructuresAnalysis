using ApiDomain.Entities;
using ApiDomain.Interfaces;
using ApiService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiService.Services
{
    public class Service : IService
    {
        IRepository Data;

        public Service(IRepository repository)
        {
            Data = repository;
        }

        public void InitializeRepository()
        {
            var newEntity = new Entity
            {
                Id = 1,
                DateCreated = DateTime.Now
            };
        }
        public IEnumerable<Entity> GetAll()
        {
            //return repo.GetBy<User>(t => t.Id > 0);
            return Data.GetAll<Entity>();
        }
    }
}
