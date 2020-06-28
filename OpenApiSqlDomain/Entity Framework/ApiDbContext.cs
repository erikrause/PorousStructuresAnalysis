using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.IO;
using System.Configuration;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;
using System.Linq;

namespace OpenApiSqlDomain.Entity_Framework
{
    public class ApiDbContext : DbContext
    {
        //public PSADbContext() : base ("Server=(localdb)\\mssqllocaldb;Database=PSADB;Trusted_Connection=True;")
        public ApiDbContext(string connectionString) : base(connectionString)
        {
            //var prob = ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.DefaultConnection"].ConnectionString;
            //var prob2 = ConfigurationManager.ConnectionStrings[1];
            var init = Set<Image>().SingleOrDefault(t => t.Id == 1);
        }
        public DbSet<PolygonalModel> PolygonalModels { get; set; }
        public DbSet<GeneratedImage> GeneratedImages { get; set; }
        public DbSet<PGGANSample> PGGANSamples { get; set; }
        public DbSet<PGGAN> GenerationNetworks { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MicroCT> MicroCTs { get; set; }
        public DbSet<NeuralNetwork> NeuralNetworks { get; set; }
        public DbSet<PorousStructuresImage> PorousStructuresImages { get; set; }
        public DbSet<SegmentationDataset> SegmentationDatasets { get; set; }
        public DbSet<SegmentationNetwork> SegmentationNetworks { get; set; }
        public DbSet<SegmentedImage> SegmentedImages { get; set; }
        public DbSet<PGGANResolution> ResolutionParameters { get; set; }
        public DbSet<PGGANTraining> PGGANTrainings { get; set; }
        public DbSet<PGGANTrainingResolutionStatus> PGGANTrainingResolutionStatuses { get; set; }
        public DbSet<ControlVariables> ControlVariables { get; set; }
    }
}
