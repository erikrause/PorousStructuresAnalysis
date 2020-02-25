using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProbService
    {
        Task<IEnumerable<User>> GetUsers();
        Task NewUser();

        Task<IEnumerable<GeneratedSample>> GetGeneratedSamples();
        Task NewGeneratedSample();

        Task DeleteGeneratedSample(int id);
    }
}
