using ApiNetOpenApi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetOpenApi.Models
{
    public class GeneratedImageResponse : PorousStructuresImage
    {
        public bool isBinarized { get; set; }
        public int GenerationNetworkId { get; set; }
        public byte[] NoizeVector { get; set; }
        public ControlVariablesRequest ControlVariables { get; set; }
    }
}
