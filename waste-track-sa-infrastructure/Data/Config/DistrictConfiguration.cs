using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            //builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
            builder.Property(d => d.Address).IsRequired().HasMaxLength(250);
            builder.Property(d => d.Code).IsRequired().HasMaxLength(10);
            builder.HasOne(p => p.Province)
                   .WithMany()
                   .HasForeignKey(d => d.ProviceId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}