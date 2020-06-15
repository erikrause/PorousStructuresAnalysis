using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(SegmentedImage))]
    public class SegmentedImage : Image
    {
        public string Type { get; set; }
        public int SegmentationNetworkId { get; set; }
        public virtual SegmentationNetwork SegmentationNetwork { get; set; }
    }
}
