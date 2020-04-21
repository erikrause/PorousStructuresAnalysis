using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenApiSqlDomain.Entities.Abstract
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
