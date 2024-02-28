using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class CooperativeInfoConfiguration : IEntityTypeConfiguration<CooperativeInfo>
    {
        public void Configure(EntityTypeBuilder<CooperativeInfo> builder)
        {

            builder.HasOne(w => w.WastePicker)
                   .WithOne()
                   .HasForeignKey<CooperativeInfo>(c => c.WastePickerId);
            builder.HasOne(c => c.Cooperative)
                   .WithMany()
                   .HasForeignKey(c => c.CooperativeId);
            builder.HasOne(w => w.Worksite)
                   .WithOne()
                   .HasForeignKey<CooperativeInfo>(c => c.WorksiteId);
            builder.Property(c => c.YearJoined).IsRequired();

        }
    }
}