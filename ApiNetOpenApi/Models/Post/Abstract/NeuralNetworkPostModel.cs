using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace ApiNetOpenApi.Models.Post.Abstract
{
    public class NeuralNetworkPostModel : EntityPostModel
    {
        public int ImageScaleX { get; set; }
        public int ImageScaleY { get; set; }
        public int ImageScaleZ { get; set; }
        public int Channels { get; set; }
        /// <summary>
        /// Base64 string format for data
        /// </summary>
        public string NetworkModel { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
