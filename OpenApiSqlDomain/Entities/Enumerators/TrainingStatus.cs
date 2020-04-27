using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities.Enumerators
{
    public enum TrainingStatus
    {
        InProgress,
        Stopped,
        LossIncreaseError,
        LossConstantError,
        LossZeroError
    }
}
