﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    [Table(nameof(GeneratedImage))]
    public class GeneratedImage : PorousStructuresImage
    {
        public int GenerationNetworkId { get; set; }
        public GenerationNetwork GenerationNetwork { get; set; }
    }
}
