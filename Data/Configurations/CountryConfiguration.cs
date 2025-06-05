using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.CountryCode)
                .IsRequired()
                .HasColumnName("Code");

            builder.Property(c => c.CountryName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Name");

            builder.HasData(
                new Country { Id = 1, CountryCode = "US", CountryName = "United States" },
                new Country { Id = 2, CountryCode = "CA", CountryName = "Canada" },
                new Country { Id = 3, CountryCode = "GB", CountryName = "United Kingdom" },
                new Country { Id = 4, CountryCode = "FR", CountryName = "France" },
                new Country { Id = 5, CountryCode = "DE", CountryName = "Germany" },
                new Country { Id = 6, CountryCode = "BR", CountryName = "Brazil" }
            );

        }
    }
}
