﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(SegmentationDataset))]
    public class SegmentationDataset : MicroCT
    {
        public string Type { get; set; }
        public byte[] MaskVoxelArray { get; set; }

        public virtual List<SegmentationNetwork> SegmentationNetwork { get; set; }
    }
}
