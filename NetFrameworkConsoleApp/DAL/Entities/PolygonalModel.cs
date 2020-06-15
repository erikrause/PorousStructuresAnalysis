using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    public class PolygonalModel : Entity
    {
        public byte[] RockFaces { get; set; }
        public byte[] RockVertexes { get; set; }
        public byte[] PorousFaces { get; set; }
        public byte[] PorousVertexes { get; set; }

        [ForeignKey(nameof(Abstract.Image))]
        public override int Id { get; set; }
        public virtual Image Image { get; set; }
    }
}
