using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(MicroCT))]
    public class MicroCT : PorousStructuresImage
    {
        public string Name { get; set; }
        public double? Depth { get; set; }

        public virtual List<GenerationNetwork> GenerationNetwork { get; set; }

        //public User User { get; set; }
    }
}
