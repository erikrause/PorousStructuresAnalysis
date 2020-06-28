using ApiNetOpenApi.Models.Post.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiNetOpenApi.Models.Post
{
    public class MicroCTPostModel : PorousStructuresImagePostModel
    {
        public string Name { get; set; }
        public double? Depth { get; set; }
        public List<int> GenerationNetworkIds { get; set; }
        public int UserId { get; set; }
    }
}
