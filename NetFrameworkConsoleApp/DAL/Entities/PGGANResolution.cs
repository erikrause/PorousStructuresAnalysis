using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class PGGANResolution : Entity
    {
        public byte[] GeneratorWeights { get; set; }
        public byte[] DiscriminatorWeights { get; set; }
        public int ImageScaleX { get; set; }
        public int ImageScaleY { get; set; }
        public int ImageScaleZ { get; set; }
        public int FiltersCount { get; set; }
        public int FiltersSize { get; set; }
        public int FiltersStride { get; set; }
        public int FiltersPadding { get; set; }
        
        ////////////////////////////////////////
        // Training Parameters:
        public int Iterations { get; set; }
        public int BatchSize { get; set; }
        public int LearningRateStart { get; set; }
        public int LearningRateEnd { get; set; }
        public int LearningRateDecay { get; set; }

        // Fadein training parameters:
        public int FadeinUpsampleIterations { get; set; }
        public int FadeinBatchSize { get; set; }
        public int FadeinLearningRateStart { get; set; }
        public int FadeinLearningRateEnd { get; set; }
        public int FadeinLearningRateDecay { get; set; }

        public int GenerationNetworkId { get; set; }
        public virtual PGGAN GenerationNetwork { get; set; }
        public virtual PGGANTrainingResolutionStatus PGGANTrainingResolutionStatus { get; set; }

        // Sampling parameters:
        public int SampleInterval { get; set; }
    }
}
