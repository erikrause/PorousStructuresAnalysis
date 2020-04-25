using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.IO;
using System.Configuration;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;

namespace OpenApiSqlDomain.Entity_Framework
{
    public class ApiDbContext : DbContext
    {
        //public PSADbContext() : base ("Server=(localdb)\\mssqllocaldb;Database=PSADB;Trusted_Connection=True;")
        public ApiDbContext(string connectionString) : base(connectionString)
        {
            //var prob = ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.DefaultConnection"].ConnectionString;
            //var prob2 = ConfigurationManager.ConnectionStrings[1];
            var init = Set<Image>().SingleOrDefaultAsync(t => t.Id == 1);
        }
        public DbSet<PolygonalModel> C3DModel { get; set; }
        public DbSet<GeneratedImage> GeneratedImage { get; set; }
        public DbSet<GeneratedSample> GeneratedSample { get; set; }
        public DbSet<PGGAN> GenerationNetwork { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<MicroCT> MicroCT { get; set; }
        public DbSet<NeuralNetwork> NeuralNetwork { get; set; }
        public DbSet<PorousStructuresImage> PorousStructuresImage { get; set; }
        public DbSet<SegmentationDataset> SegmentationDataset { get; set; }
        public DbSet<SegmentationNetwork> SegmentationNetwork { get; set; }
        public DbSet<SegmentedImage> SegmentedImage { get; set; }    
        public DbSet<PGGANResolution> ResolutionParameters { get; set; }
    }
}
