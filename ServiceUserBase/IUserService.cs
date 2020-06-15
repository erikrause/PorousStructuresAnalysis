using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceUserBase
{
    public interface IUserService
    {
        Task Registration(IdentityUser user);
        Task Authorization(IdentityUser user);
        Task Authentification(IdentityUser user);
        Task<IEnumerable<IdentityUser>> GetAll();
        Task<IdentityUser> Get(int id);
    }
}