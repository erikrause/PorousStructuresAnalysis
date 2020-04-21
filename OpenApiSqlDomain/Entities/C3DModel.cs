using System;
using System.Collections.Generic;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    public class C3DModel : Entity
    {
        public byte[] Data { get; set; }
        public int? PolygonsCount { get; set; }
        public int? VertexCount { get; set; }

    }
}
