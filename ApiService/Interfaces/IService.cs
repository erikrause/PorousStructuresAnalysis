using ApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiService.Interfaces
{
    public interface IService
    {
        public void InitializeRepository();
        public IEnumerable<Entity> GetAll();    // TODO: Delete

        //public void repository
    }
}
