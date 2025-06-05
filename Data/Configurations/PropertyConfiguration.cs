using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CityBreaks.Web.Models;

namespace CityBreaks.Web.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("Name");

            builder.Property(p => p.PricePerNight)
                .IsRequired()
                .HasColumnName("PricePerNight");

            builder.HasData(
                new Property { Id = 1, Name = "Central Park Hotel", PricePerNight = 150.00m, CityId = 1 },
                new Property { Id = 2, Name = "Hollywood Inn", PricePerNight = 120.00m, CityId = 2 },
                new Property { Id = 3, Name = "Downtown Toronto Suites", PricePerNight = 180.00m, CityId = 3 },
                new Property { Id = 4, Name = "Vancouver Bay Hotel", PricePerNight = 200.00m, CityId = 4 },
                new Property { Id = 5, Name = "London Eye Apartments", PricePerNight = 250.00m, CityId = 5 },
                new Property { Id = 6, Name = "Parisian Charm Hotel", PricePerNight = 300.00m, CityId = 6 },
                new Property { Id = 7, Name = "Berlin Central Hostel", PricePerNight = 80.00m, CityId = 7 },
                new Property { Id = 8, Name = "Rio Beach Resort", PricePerNight = 220.00m, CityId = 8 }
            );

        }
    }
}
