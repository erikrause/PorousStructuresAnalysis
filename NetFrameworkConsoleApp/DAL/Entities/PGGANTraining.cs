using OpenApiSqlDomain.Entities.Abstract;
using OpenApiSqlDomain.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class PGGANTraining : Entity
    {
        [ForeignKey(nameof(Entities.PGGAN))]
        public override int Id { get; set; }
        public virtual PGGAN PGGAN { get; set; }
        public virtual List<PGGANTrainingResolutionStatus> PGGANTrainingResolutionsStatuses { get; set; }    // TODO: Check database cycle! (with PGGAN entity).
        public TrainingStatus TrainingStatus { get; set; }
    }
}