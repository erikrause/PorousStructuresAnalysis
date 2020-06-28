using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWeb.Models
{
    public class GenerateImageRequest
    {
        public int pGGANId { get; set; }
        public int Seed { get; set; }
        public double Porosity { get; set; }
    }
}
