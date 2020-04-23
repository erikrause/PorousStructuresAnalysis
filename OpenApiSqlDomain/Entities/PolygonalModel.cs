using System;
using System.Collections.Generic;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    public class PolygonalModel : Entity
    {
        public byte[] Data { get; set; }
        public int? PolygonsCount { get; set; }
        public int? VertexCount { get; set; }
        public int MicroCTId { get; set; }
        public MicroCT MicroCT { get; set; }
    }
}
