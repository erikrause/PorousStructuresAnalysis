using OpenApiSqlDomain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(GeneratedSample))]
    public class GeneratedSample : GeneratedImage
    {
        public int? Iteration { get; set; }
        public double? Accuracy { get; set; }
        public double? Loss { get; set; }
    }
}
