using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWeb.Models
{
    public class GenerateImageRequest
    {
        [Display(Name = "Идентификатор нейронной сети")]
        public int pGGANId { get; set; }
        [Display(Name = "Seed (зерно случайной генерации)")]
        public int Seed { get; set; }
        [Display(Name = "Пористость (%)")]
        public double Porosity { get; set; }
    }
}
