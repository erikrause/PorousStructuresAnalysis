using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(PGGAN))]
    public class PGGAN : NeuralNetwork
    {
        public byte[] GeneratorWeights { get; set; }
        public byte[] DiscriminatorWeights { get; set; }

        public virtual List<GeneratedImage> GeneratedImage { get; set; }
        //public int MicroCTId { get; set; }
        public virtual List<MicroCT> MicroCT { get; set; }
        public NetworkType Type { get; set; }    // Example: CGAN, WGAN, InfoGAN
        public virtual List<PGGANResolution> ResolutionsConfigurations { get; set; }
        public string Optimizer { get; set; }   // Adam, RMSProp
        public string WeightInitializer { get; set; }
        public float ReLUAlpha { get; set; }
        public int HiddenShape { get; set; }
        public int CriticSteps { get; set; }
        public virtual PGGANTraining PGGANTraining { get; set; }
    }
}
