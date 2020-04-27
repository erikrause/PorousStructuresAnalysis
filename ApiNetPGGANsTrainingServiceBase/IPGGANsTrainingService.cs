using ApiCRUDServiceBase;
using OpenApiSqlDomain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetPGGANsTrainingServiceBase
{
    public interface IPGGANsTrainingService : ICRUDService<PGGANTraining>
    {
        Task Start(PGGANTraining pGGANTraining);
        Task Stop(PGGANTraining pGGANTraining);
        Task Reset(PGGANTraining pGGANTraining);
    }
}
