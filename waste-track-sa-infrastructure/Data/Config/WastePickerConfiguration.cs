using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class WastePickerConfiguration : IEntityTypeConfiguration<WastePicker>
    {
        public void Configure(EntityTypeBuilder<WastePicker> builder)
        {
            builder.Property(w => w.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(w => w.LastName).IsRequired().HasMaxLength(50);
            builder.Property(w => w.DOB).IsRequired();
            builder.Property(w => w.Age).IsRequired();
            builder.HasOne(d => d.DocumentType).WithMany().HasForeignKey(w => w.DocumentTypeId);
            builder.Property(w => w.RegistrationLocation).IsRequired().HasMaxLength(100);
            builder.HasOne(w => w.WastePickerStatus).WithMany().HasForeignKey(w => w.WastePickerStatusId);
            builder.HasOne(g => g.Gender).WithMany().HasForeignKey(w => w.GenderId);
            builder.HasOne(r => r.Race).WithMany().HasForeignKey(w => w.RaceId);
        }
    }
}