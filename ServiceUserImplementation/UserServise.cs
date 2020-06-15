using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceUserImplementation
{
    public class UserServise : ServiceUserBase.IUserService
    {
        UserManager<IdentityUser> UserManager;
        RoleManager<IdentityRole> RoleManager;
        
        public Task Registration(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task Authorization(IdentityUser user)
        {
            throw new NotImplementedException();
        }
        public Task Authentification(IdentityUser user)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<IdentityUser>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<IdentityUser> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
