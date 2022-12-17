using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region HotelData

            modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Trident",
                Address = "xxxx",
                Rating = 3,
                CountryId = 3

            },
            new Hotel
            {
                Id = 2,
                Name = "sangham",
                Address = "yyyy",
                Rating = 3.4,
                CountryId = 1

            },
            new Hotel
            {
                Id = 3,
                Name = "aravindo",
                Address = "zzzz",
                Rating = 4.4,
                CountryId = 1

            },
            new Hotel
            {
                Id = 4,
                Name = "tension",
                Address = "xxxx",
                Rating = 1.4,
                CountryId = 3

            }, new Hotel
            {
                Id = 5,
                Name = "non-Sense",
                Address = "oooo",
                Rating = 3.3,
                CountryId = 4

            },
            new Hotel
            {
                Id = 6,
                Name = "tim tin",
                Address = "pppp",
                Rating = 3.8,
                CountryId = 2

            });

            #endregion HotelData

            #region CountryData



            modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "pakistan",
                ShortName = "pak"

            },
            new Country
            {
                Id = 2,
                Name = "japan",
                ShortName = "Jap"
            },
            new Country
            {
                Id = 3,
                Name = "india",
                ShortName = "Ind"

            },
            new Country
            {
                Id = 4,
                Name = "srilanka",
                ShortName = "SL"
            });


            #endregion CountryData


        }



    }
}
