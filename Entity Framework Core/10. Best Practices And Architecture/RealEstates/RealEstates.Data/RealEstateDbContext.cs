﻿using RealEstates.Models;
using Microsoft.EntityFrameworkCore;

namespace RealEstates.Data
{
    public class RealEstateDbContext : DbContext
    {
        public RealEstateDbContext()
        {

        }

        public RealEstateDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<RealEstateProperty> RealEstateProperties { get; set;}

        public DbSet<District> Districts { get; set;}

        public DbSet<PropertyType> PropertyTypes { get; set;}

        public DbSet<BuildingType> BuildingTypes { get; set;}

        public DbSet<Tag> Tags { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=RealEstate;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RealEstatePropertyTag>(entity =>
            {
                entity.HasKey(x => new { x.PropertyId, x.TagId });
            });

            modelBuilder.Entity<District>()
                .HasMany(x => x.Properties)
                .WithOne(x => x.District)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
