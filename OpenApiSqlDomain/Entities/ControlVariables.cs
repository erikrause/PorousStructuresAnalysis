using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenApiSqlDomain.Entities
{
    public class ControlVariables : Entity
    {
        [ForeignKey(nameof(Entities.GeneratedImage))]
        public override int Id { get; set; }
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
