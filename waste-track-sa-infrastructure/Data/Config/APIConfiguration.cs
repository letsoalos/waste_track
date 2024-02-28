using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class APIConfiguration : IEntityTypeConfiguration<API>
    {
        public void Configure(EntityTypeBuilder<API> builder)
        {
            builder.Property(a => a.Description).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
        }
    }
}