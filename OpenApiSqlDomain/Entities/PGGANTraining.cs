using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class PGGANTraining : Entity
    {
        [ForeignKey(nameof(Entities.PGGAN))]
        public override int Id { get; set; }
        public virtual PGGAN PGGAN { get; set; }
        public int CurrentIteration { get; set; }
        public int CurrentScaleX { get; set; }
        public int CurrentScaleY { get; set; }
        public int CurrentScaleZ { get; set; }
        public int SampleInterval { get; set; }
        public int CurrentResolution { get; set; }
        public bool IsCurrentFadein { get; set; }
        public virtual List<PGGANResolutionTraining> PGGANResolutionsTrainings { get; set; }    // TODO: Check database cycle! (with PGGAN entity.
        public TrainingStatus TrainingStatus { get; set; }
        public virtual List<GeneratedSample> GeneratedSamples { get; set; }
    }

    public enum TrainingStatus
    {
        InProgress,
        Stopped,
        LossIncreaseError
    }
}