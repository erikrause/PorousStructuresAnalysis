using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetPolygonalModelingServiceImpl.Models
{
    public class PolygonsRequest
    {
        /// <summary>
        /// Base64 string
        /// </summary>
        public string VoxelArray { get; set; }
        public string VoxelArrayFormat { get; set; }
    }
}
