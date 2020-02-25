using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    [Table(nameof(SegmentedImage))]
    public class SegmentedImage : Image
    {
        public string Type { get; set; }
        public SegmentationNetwork SegmentationNetwork { get; set; }
    }
}
