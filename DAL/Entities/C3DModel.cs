﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    public class C3DModel : Entity
    {
        public byte[] Data { get; set; }
        public int? PolygonsCount { get; set; }
        public int? VertexCount { get; set; }

    }
}
