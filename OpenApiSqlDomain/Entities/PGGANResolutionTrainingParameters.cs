using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class PGGANResolutionTrainingParameters : Entity
    {
        public int BatchSize { get; set; }
        public int LearningRateStart { get; set; }
        public int LearningRateEnd { get; set; }
        public int LearningRateDecay { get; set; }
        public int Iterations { get; set; }

        // Fadein parameters:
        public int FadeinUpsampleIterations { get; set; }
        public int FadeinLearningRateStart { get; set; }
        public int FadeinLearningRateEnd { get; set; }
        public int FadeinLearningRateDecay { get; set; }

        [ForeignKey(nameof(Entities.PGGANResolution))]
        public override int Id { get; set; }
        public virtual PGGANResolution ResolutionConfiguration { get; set; }
    }
}
