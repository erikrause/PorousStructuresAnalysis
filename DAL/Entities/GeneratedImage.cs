using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    [Table(nameof(GeneratedImage))]
    public class GeneratedImage : PorousStructuresImage
    {
        public GenerationNetwork GenerationNetwork { get; set; }
    }
}
