using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{
    public class ForestContext : DbContext
    {

        public DbSet<ForestFarm> ForestFarms { get; set; }

        public DbSet<Forestry> Forestries { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        public DbSet<GroundCover> GroundCovers { get; set; }

        public DbSet<ForestryProductionAssociation> ForestryProductionAssociations { get; set; }

        public DbSet<Region> Regions { get; set; }

        public ForestContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=172.16.193.234;Port=5432;Database=postgres;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}