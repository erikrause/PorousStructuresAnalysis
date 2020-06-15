using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenApiSqlDomain.Entities.Abstract;
using OpenApiSqlDomain.Entities.Enumerators;

namespace OpenApiSqlDomain.Entities
{
    [Table(nameof(PGGAN))]
    public class PGGAN : NeuralNetwork
    {
        public virtual List<GeneratedImage> GeneratedImage { get; set; }
        public virtual List<MicroCT> MicroCT { get; set; }  // TODO: test many to many relationship.
        public NetworkType Type { get; set; }
        public virtual List<PGGANResolution> PGGANResolutions { get; set; }
        public Optimizer Optimizer { get; set; }   // Adam, RMSProp
        public string WeightInitializer { get; set; }
        public GeneratorOutputActivation GeneratorOutputActivation { get; set; }
        public ConvolutionalActivation ConvolutionalActivations { get; set; }
        public float? ReLUAlpha { get; set; }
        public int HiddenShape { get; set; }
        public int CriticSteps { get; set; }
        public virtual PGGANTraining PGGANTraining { get; set; }
        public bool Cashed { get; set; }
    }
}
