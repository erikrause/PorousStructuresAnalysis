using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class PGGANTrainingResolutionStatus : Entity
    {
        [ForeignKey(nameof(Entities.PGGANResolution))]
        public override int Id { get; set; }
        public virtual PGGANResolution PGGANResolution { get; set; }
        public int IterationsPassed { get; set; }
        public int FadeinUpsampleIterationsPassed { get; set; }
        public virtual PGGANTraining PGGANTraining { get; set; }
        public virtual List<PGGANSample> PGGANSample { get; set; }
    }
}
