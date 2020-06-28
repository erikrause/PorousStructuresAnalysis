using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetOpenApi.Models.Get
{
    public class PolygonalModelGetModel
    {
        public byte[] RockFaces { get; set; }
        public byte[] RockVertexes { get; set; }
        public byte[] PorousFaces { get; set; }
        public byte[] PorousVertexes { get; set; }
    }
}
