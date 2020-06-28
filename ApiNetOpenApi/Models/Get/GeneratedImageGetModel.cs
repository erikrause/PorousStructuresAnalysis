using ApiNetOpenApi.Models.Get.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetOpenApi.Models.Get
{
    public class GeneratedImageGetModel : PorousStructuresImageGetModel
    {
        public bool isBinarized { get; set; }
        public int GenerationNetworkId { get; set; }
        public List<float> NoizeVector { get; set; }
        public ControlVariablesModel ControlVariables { get; set; }
    }
}
