using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class WorksiteConfigure : IEntityTypeConfiguration<Worksite>
    {
        public void Configure(EntityTypeBuilder<Worksite> builder)
        {
            builder.Property(w => w.Name).IsRequired().HasMaxLength(100);
        }
    }
}