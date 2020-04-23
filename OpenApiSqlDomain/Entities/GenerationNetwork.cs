using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(GenerationNetwork))]
    public class GenerationNetwork : NeuralNetwork
    {
        public byte[] GeneratorModel { get; set; }

        public virtual List<GeneratedImage> GeneratedImage { get; set; }
        //public int MicroCTId { get; set; }
        public virtual List<MicroCT> MicroCT { get; set; }
        public string Type { get; set; }    // Example: CGAN, WGAN
        public virtual List<ResolutionParameters> ResolutionsParameters { get; set; }
        public string Optimizer { get; set; }   // Adam, RMSProp
        public string WeightInitializer { get; set; }
        public float ReLUAlpha { get; set; }
        public int HiddenShape { get; set; }
        public int CriticStep { get; set; }
        public int SampleInterval { get; set; }

    }
}
