using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RealEstateListing.Models
{
    public class RealEstateListingContext : DbContext
    {
        public RealEstateListingContext (DbContextOptions<RealEstateListingContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstateListing.Models.RealEstate> RealEstate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RealEstate>().HasData(
                            new RealEstate
                            {
                                Id = 1,
                                Type = "Apartment",
                                Sqft = 2100,
                                Cost = 300000
                            });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 2,
                    Type = "Condominium",
                    Sqft = 1350,
                    Cost = 170000
                });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 3,
                    Type = "Co-op",
                    Sqft = 1780,
                    Cost = 210000
                });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 4,
                    Type = "Single family",
                    Sqft = 2100,
                    Cost = 231000
                });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 5,
                    Type = "Apartment",
                    Sqft = 3000,
                    Cost = 450000
                });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 6,
                    Type = "Single family",
                    Sqft = 2050,
                    Cost = 185000
                });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 7,
                    Type = "Condominium",
                    Sqft = 2300,
                    Cost = 215200
                });

            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    Id = 8,
                    Type = "Single family",
                    Sqft = 1500,
                    Cost = 150000
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
