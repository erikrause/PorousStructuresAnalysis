using ApiNetOpenApi.Models.Get.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiNetOpenApi.Models.Get
{
    public class MicroCTGetModel : PorousStructuresImageGetModel
    {
        public string Name { get; set; }
        public double? Depth { get; set; }
        public List<int> GenerationNetworkIds { get; set; }
        public int UserId { get; set; }
    }
}
