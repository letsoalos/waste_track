using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class EmailContentConfiguration : IEntityTypeConfiguration<EmailContent>
    {
        public void Configure(EntityTypeBuilder<EmailContent> builder)
        {
            builder.Property(e => e.Content).IsRequired();
            builder.Property(e => e.Subject).IsRequired().HasMaxLength(250);
            builder.Property(e => e.Type).IsRequired();
            builder.Property(e => e.Attachment).HasMaxLength(500);
            builder.Property(e => e.ToAddress).IsRequired().HasMaxLength(50);
            builder.Property(e => e.CCAddress).HasMaxLength(50);
            builder.Property(e => e.BCAddress).HasMaxLength(50);
        }
    }
}