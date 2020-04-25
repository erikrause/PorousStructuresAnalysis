using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class PGGANResolution : Entity
    {
        public int ImageScaleX { get; set; }
        public int ImageScaleY { get; set; }
        public int ImageScaleZ { get; set; }
        public int FiltersCount { get; set; }
        public int FiltersSize { get; set; }
        public int FiltersStride { get; set; }
        public int FiltersPadding { get; set; }

        public int GenerationNetworkId { get; set; }
        public virtual PGGAN GenerationNetwork { get; set; }
        public virtual PGGANResolutionTrainingParameters ResolutionTrainingParameters { get; set; }
    }
}
