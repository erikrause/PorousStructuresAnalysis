using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    [Table(nameof(GenerationNetwork))]
    public class GenerationNetwork : NeuralNetwork
    {
        public byte[] GeneratorModel { get; set; }

        public List<GeneratedImage> GeneratedImage { get; set; }
        public MicroCT MicroCT { get; set; }
    }
}
