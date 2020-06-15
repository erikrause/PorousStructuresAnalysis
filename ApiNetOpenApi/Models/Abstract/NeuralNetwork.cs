using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetOpenApi.Models.Abstract
{
    public class NeuralNetwork : Entity
    {
        public int ImageScaleX { get; set; }
        public int ImageScaleY { get; set; }
        public int ImageScaleZ { get; set; }
        public int Channels { get; set; }
        public byte[] NetworkModel { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
