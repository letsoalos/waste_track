using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class MunicipalityConfiguration : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Address).IsRequired().HasMaxLength(250);
            builder.Property(m => m.Code).IsRequired().HasMaxLength(10);
            builder.Property(m => m.Contacts).IsRequired().HasMaxLength(15);
            builder.HasOne(d => d.District).WithMany().HasForeignKey(m => m.DistrictId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}