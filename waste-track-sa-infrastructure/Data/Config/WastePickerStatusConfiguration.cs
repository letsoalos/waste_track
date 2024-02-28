using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class WastePickerStatusConfiguration : IEntityTypeConfiguration<WastePickerStatus>
    {
        public void Configure(EntityTypeBuilder<WastePickerStatus> builder)
        {
            builder.Property(w => w.Name).IsRequired().HasMaxLength(50);
            builder.Property(w => w.Code).IsRequired().HasMaxLength(10);
        }
    }
}