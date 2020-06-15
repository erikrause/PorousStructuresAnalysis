using ApiNetOpenApi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiNetOpenApi.Models
{
    public class MicroCTDTO : PorousStructuresImage
    {
        public string Name { get; set; }
        public double? Depth { get; set; }
    }
}
