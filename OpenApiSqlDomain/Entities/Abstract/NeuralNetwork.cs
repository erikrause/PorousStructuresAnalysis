using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities.Abstract
{
    public class NeuralNetwork : Entity
    {
        //public string InputScale { get; set; }  // TODO: сделать кортеж
        public int InputScaleX { get; set; }
        public int InputScaleY { get; set; }
        public int InputScaleZ { get; set; }
        public byte[] NetworkModel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsPrivate { get; set; }
    }
}
