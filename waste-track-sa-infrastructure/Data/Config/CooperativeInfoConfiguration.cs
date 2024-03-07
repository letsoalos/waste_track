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
                   .HasForeignKey<CooperativeInfo>(c => c.WastePickerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(c => c.Cooperative)
                   .WithMany()
                   .HasForeignKey(c => c.CooperativeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(w => w.Worksite)
                   .WithOne()
                   .HasForeignKey<CooperativeInfo>(c => c.WorksiteId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(c => c.YearJoined).IsRequired();

        }
    }
}