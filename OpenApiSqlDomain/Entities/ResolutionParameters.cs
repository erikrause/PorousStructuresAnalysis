using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class ResolutionParameters : Entity
    {
        public int FiltersCount { get; set; }
        public int FiltersSize { get; set; }
        public int FiltersStride { get; set; }
        public int FiltersPadding { get; set; }
        public int BatchSize { get; set; }
        public int LearningRateStart { get; set; }
        public int LearningRateEnd { get; set; }
        public int LearningRateDecay { get; set; }
        public int Iterations { get; set; }
        public int GenerationNetworkId { get; set; }
        public GenerationNetwork GenerationNetwork { get; set; }

    }
}
