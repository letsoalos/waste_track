using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class IncomeMethodConfiguration : IEntityTypeConfiguration<IncomeMethod>
    {
        public void Configure(EntityTypeBuilder<IncomeMethod> builder)
        {
            builder.Property(i => i.Name).IsRequired().HasMaxLength(10);
        }
    }
}