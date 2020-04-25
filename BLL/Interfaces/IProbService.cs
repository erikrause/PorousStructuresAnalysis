using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Entities.Abstract;

namespace BLL.Interfaces
{
    public interface IProbService
    {
        //IEnumerable<User> GetUsers();
        Task NewUser();

        Task <IEnumerable<GeneratedSample>> GetGeneratedSamples();
        Task NewGeneratedSample();

        Task DeleteGeneratedSample(int id);
    }
}
