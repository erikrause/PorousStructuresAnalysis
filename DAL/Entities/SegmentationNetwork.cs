﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    [Table(nameof(SegmentationNetwork))]
    public class SegmentationNetwork : NeuralNetwork
    {
        public int SegmentationDatasetId { get; set; }

        public SegmentationDataset SegmentationDataset { get; set; }

        public int SegmentationNetworkId { get; set; }

        public List<SegmentedImage> SegmentedImage { get; set; }
    }
}
