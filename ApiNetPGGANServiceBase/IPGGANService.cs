using ApiCRUDServiceBase;
using OpenApiSqlDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiNetPGGANServiceBase
{
    public interface IPGGANService : ICRUDService<PGGAN>
    {
        public Task InitGenerator(int pGGANId);
    }
}
