using ApiNetOpenApi.Models.Post.Abstract;
using OpenApiSqlDomain.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetOpenApi.Models.Post
{
    public class PGGANPostModel : NeuralNetworkPostModel
    {
        //public virtual List<GeneratedImage> GeneratedImages { get; set; }
        public int MicroCTId { get; set; }  // TODO: test many to many relationship.
        public NetworkType Type { get; set; }
        //public virtual List<PGGANResolution> PGGANResolutions { get; set; }
        public Optimizer Optimizer { get; set; }   // Adam, RMSProp
        public string WeightInitializer { get; set; }
        public GeneratorOutputActivation GeneratorOutputActivation { get; set; }
        public ConvolutionalActivation ConvolutionalActivations { get; set; }
        public float? ReLUAlpha { get; set; }
        public int HiddenShape { get; set; }
        public int CriticSteps { get; set; }
        //public virtual PGGANTraining PGGANTraining { get; set; }
        public bool Cashed { get; set; }
    }
}
