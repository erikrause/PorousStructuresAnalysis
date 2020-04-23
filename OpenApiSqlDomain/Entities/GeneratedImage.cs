using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(GeneratedImage))]
    public class GeneratedImage : PorousStructuresImage
    {
        public int GenerationNetworkId { get; set; }
        public virtual GenerationNetwork GenerationNetwork { get; set; }
    }
}
