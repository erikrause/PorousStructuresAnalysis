using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(SegmentationNetwork))]
    public class SegmentationNetwork : NeuralNetwork
    {
        public int SegmentationDatasetId { get; set; }

        public virtual List<SegmentationDataset> SegmentationDataset { get; set; } // TODO: check many to many relationship.

        public virtual List<SegmentedImage> SegmentedImage { get; set; }
    }
}
