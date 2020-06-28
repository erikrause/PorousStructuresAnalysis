using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetOpenApi.Models.Get.Abstract
{
    public class NeuralNetworkGetModel : EntityGetModel
    {
        public int ImageScaleX { get; set; }
        public int ImageScaleY { get; set; }
        public int ImageScaleZ { get; set; }
        public int Channels { get; set; }
        public byte[] NetworkModel { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
