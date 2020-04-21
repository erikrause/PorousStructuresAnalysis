using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    public class User : Entity
    {
        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LastOnlineDate { get; set; }
        public string Role { get; set; }

        public List<MicroCT> MicroCT { get; set; }
        public List<NeuralNetwork> NeuralNetwork { get; set; }
    }
}
