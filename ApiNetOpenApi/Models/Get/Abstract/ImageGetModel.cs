using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetOpenApi.Models.Get.Abstract
{
    public class ImageGetModel : EntityGetModel
    {
        public byte[] VoxelArray { get; set; }
        public double? Scale { get; set; }
        public int DimX { get; set; }
        public int DimY { get; set; }
        public int DimZ { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual PolygonalModelGetModel PolygonalModel { get; set; }
        public string VoxelArrayFormat { get; set; }
    }
}
