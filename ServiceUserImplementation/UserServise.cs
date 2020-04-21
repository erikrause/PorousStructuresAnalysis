using System;
using System.Threading.Tasks;

namespace ServiceUserImplementation
{
    public class UserServise : ServiceUserBase.IUserService
    {
        public Task ChangePassword(byte[] oldPasswordHash, byte[] newPasswordHash)
        {
            throw new NotImplementedException();
        }

        public Task Create(string login, byte[] passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
