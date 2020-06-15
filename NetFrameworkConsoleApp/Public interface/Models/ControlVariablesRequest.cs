using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetOpenApi.Models
{
    public class ControlVariablesRequest
    {
        public byte[] NoiseVector { get; set; }
        public double? Porosity { get; set; }
        public double? ElementsCount { get; set; }
        public double? MinElementSize { get; set; }
        public double? MaxElementSize { get; set; }
        public double? AvgElementSize { get; set; }
        public double? Сohesion { get; set; }
        public double? CavernsVolume { get; set; }
        public double? ChanelsVolume { get; set; }
        public double? Permeability { get; set; }
        public bool Binarisation { get; set; }
        public bool DeleteNoize { get; set; }
    }
}
