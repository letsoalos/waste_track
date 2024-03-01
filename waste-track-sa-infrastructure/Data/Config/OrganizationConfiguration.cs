using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.Property(o => o.Name).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Address).IsRequired().HasMaxLength(250);
            builder.Property(o => o.Contacts).HasMaxLength(15);
            builder.Property(o => o.Code).IsRequired().HasMaxLength(50);
            builder.HasOne(m => m.Municipality).WithMany().HasForeignKey(o => o.MunicipalityId); //confirm this before you commit changes
        }
    }
}