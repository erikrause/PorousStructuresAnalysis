using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Image : Entity
    {
        public byte[] VoxelArray { get; set; }
        public double? Scale { get; set; }
        public string Resolution { get; set; }
        public DateTime? CreatedDate { get; set; }
        public List<C3DModel> C3DModels { get; set; }
    }
}
