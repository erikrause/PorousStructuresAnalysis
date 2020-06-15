using OpenApiSqlDomain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(PGGANSample))]
    public class PGGANSample : GeneratedImage
    {
        public int Iteration { get; set; }
        public float? DiscriminatorAccuracy { get; set; }
        public float GeneratorLoss { get; set; }
        public float DiscriminatorLoss { get; set; }
        public int PGGANResolutionTrainingStatusId { get; set; }
        public virtual PGGANTrainingResolutionStatus PGGANTrainingResolutionStatus { get; set; }
    }
}
