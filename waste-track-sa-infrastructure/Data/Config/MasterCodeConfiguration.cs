using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class MasterCodeConfiguration : IEntityTypeConfiguration<MasterCode>
    {
        public void Configure(EntityTypeBuilder<MasterCode> builder)
        {
            //builder.Property(m => m.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(50);
        }
    }
}