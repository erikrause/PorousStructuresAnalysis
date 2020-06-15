using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities.Abstract
{
    [Table(nameof(PorousStructuresImage))]
    public class PorousStructuresImage : Image
    {
        public double Porosity { get; set; }
        public int? ElementsCount { get; set; }
        public double? MinElementSize { get; set; }
        public double? MaxElementSize { get; set; }
        public double? AvgElementSize { get; set; }
        public double? Сohesion { get; set; }
        public double? CavernsVolume { get; set; }
        public double? ChanelsVolume { get; set; }
        public double? Permeability { get; set; }
    }
}
