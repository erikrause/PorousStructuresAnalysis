using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetOpenApi.Models.Abstract
{
    public class Image : Entity
    {
        public byte[] VoxelArray { get; set; }
        public double? Scale { get; set; }
        public int DimX { get; set; }
        public int DimY { get; set; }
        public int DimZ { get; set; }
        public DateTime? CreatedDate { get; set; }
        //public virtual PolygonalModel PolygonalModel { get; set; }
    }
}
