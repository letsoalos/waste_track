using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class OrganizationTypeConfiguration : IEntityTypeConfiguration<OrganizationType>
    {
        public void Configure(EntityTypeBuilder<OrganizationType> builder)
        {
            //builder.Property(o => o.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(o => o.Name).IsRequired().HasMaxLength(50);
        }
    }
}