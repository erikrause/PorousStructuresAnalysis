using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using ApiDomain.Entities;
using System.IO;
using System.Configuration;

namespace ApiDomain.Entity_Framework
{
    public class ApiContext : DbContext
    {
        //public PSADbContext() : base ("Server=(localdb)\\mssqllocaldb;Database=PSADB;Trusted_Connection=True;")
        public ApiContext(string connectionString) : base(connectionString)
            //base("Server=(localdb)\\mssqllocaldb;Database=PSADBApi;Trusted_Connection=True;")
        {
            //var prob = ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.DefaultConnection"].ConnectionString;
            //var prob2 = ConfigurationManager.ConnectionStrings[1];
    }

        public DbSet<Entity> Entities { get; set; }
        /*
        public DbSet<C3DModel> C3DModel { get; set; }
        public DbSet<GeneratedImage> GeneratedImage { get; set; }
        public DbSet<GeneratedSample> GeneratedSample { get; set; }
        public DbSet<GenerationNetwork> GenerationNetwork { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<MicroCT> MicroCT { get; set; }
        public DbSet<NeuralNetwork> NeuralNetwork { get; set; }
        public DbSet<PorousStructuresImage> PorousStructuresImage { get; set; }
        public DbSet<SegmentationDataset> SegmentationDataset { get; set; }
        public DbSet<SegmentationNetwork> SegmentationNetwork { get; set; }
        public DbSet<SegmentedImage> SegmentedImage { get; set; }
        public DbSet<User> User { get; set; }*/
    }
}
