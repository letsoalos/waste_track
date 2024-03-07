using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class CooperativeConfiguration : IEntityTypeConfiguration<Cooperative>
    {
        public void Configure(EntityTypeBuilder<Cooperative> builder)
        {
            //builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        }
    }
}