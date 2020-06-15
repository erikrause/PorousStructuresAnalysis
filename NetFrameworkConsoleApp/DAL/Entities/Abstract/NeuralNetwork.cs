using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities.Abstract
{
    public class NeuralNetwork : Entity
    {
        //public string InputScale { get; set; }  // TODO: сделать кортеж
        public int ImageScaleX { get; set; }
        public int ImageScaleY { get; set; }
        public int ImageScaleZ { get; set; }
        public int Channels { get; set; }
        public byte[] NetworkModel { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
