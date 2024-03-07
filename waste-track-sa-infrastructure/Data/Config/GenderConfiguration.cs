using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            //builder.Property(g => g.Id).ValueGeneratedOnAdd();
            builder.Property(g => g.Name).IsRequired().HasMaxLength(10);
        }
    }
}