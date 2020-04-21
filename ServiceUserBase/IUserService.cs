using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceUserBase
{
    public interface IUserService
    {
        Task Create(string login, byte[] passwordHash);
        Task GetAllUsers();
        Task ChangePassword(byte[] oldPasswordHash, byte[] newPasswordHash);
    }
}