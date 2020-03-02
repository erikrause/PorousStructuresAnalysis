using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities.Abstract
{
    public class NeuralNetwork : Entity
    {
        public string InputScale { get; set; }  // TODO: сделать кортеж
        public byte[] NetworkModel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsPrivate { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
