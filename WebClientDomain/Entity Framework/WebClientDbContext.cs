using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using WebClientDomain.Entities;
using WebClientDomain.Entities.Abstract;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebClientDomain.Entity_Framework
{
    public class WebClientDbContext : IdentityDbContext
    {
        //public PSADbContext() : base ("Server=(localdb)\\mssqllocaldb;Database=PSADB;Trusted_Connection=True;")
        /*
        public WebClientDbContext(string connectionString) : base(connectionString)
        {
            var init = Set<MicroCT>().SingleOrDefaultAsync(t => t.Id == 1);
        }*/
        public DbSet<GeneratedImage> GeneratedImages { get; set; }
        public DbSet<PGGANSample> PGGANSamples { get; set; }
        public DbSet<PGGAN> GenerationNetworks { get; set; }
        public DbSet<MicroCT> MicroCTs { get; set; }
        public DbSet<SegmentationDataset> SegmentationDatasets { get; set; }
        public DbSet<SegmentationNetwork> SegmentationNetworks { get; set; }
        public DbSet<SegmentedImage> SegmentedImages { get; set; }
    }
}
