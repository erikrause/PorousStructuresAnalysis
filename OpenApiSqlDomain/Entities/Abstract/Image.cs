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
        public int DimX { get; set; }
        public int DimY { get; set; }
        public int DimZ { get; set; }
        //public string Resolution { get; set; }
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Полигоны песчинок горной породы
        /// </summary>
        public virtual PolygonalModel RockPolygonalModel { get; set; }      
        /// <summary>
        /// Полигоны пустот горной породы
        /// </summary>
        public virtual PolygonalModel PorousPolygonalModel { get; set; }       
    }
}
