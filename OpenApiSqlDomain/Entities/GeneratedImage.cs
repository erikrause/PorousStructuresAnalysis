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
        public bool isBinarized { get; set; }
        public int GenerationNetworkId { get; set; }
        public virtual PGGAN GenerationNetwork { get; set; }
        public byte[] NoizeVector { get; set; }
        public ControlVariables ControlVariables { get; set; }
    }
}
