using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("Name");

            builder.HasData(
                    new City { Id = 1, Name = "New York", CountryId = 1 },
                    new City { Id = 2, Name = "Los Angeles", CountryId = 1 },
                    new City { Id = 3, Name = "Toronto", CountryId = 2 },
                    new City { Id = 4, Name = "Vancouver", CountryId = 2 },
                    new City { Id = 5, Name = "London", CountryId = 3 },
                    new City { Id = 6, Name = "Paris", CountryId = 4 },
                    new City { Id = 7, Name = "Berlin", CountryId = 5 },
                    new City { Id = 8, Name = "Rio de Janeiro", CountryId = 6 }
                );

        }
    }

}
