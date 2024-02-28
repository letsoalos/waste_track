using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.Property(r => r.Name).IsRequired().HasMaxLength(10);
        }
    }
}