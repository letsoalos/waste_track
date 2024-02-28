using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class SortingAreaConfiguration : IEntityTypeConfiguration<SortingArea>
    {
        public void Configure(EntityTypeBuilder<SortingArea> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
        }
    }
}