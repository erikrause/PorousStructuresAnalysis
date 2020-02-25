using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    [Table(nameof(SegmentationNetwork))]
    public class SegmentationNetwork : NeuralNetwork
    {
        public SegmentationDataset SegmentationDataset { get; set; }

        public List<SegmentedImage> SegmentedImage { get; set; }
    }
}
