using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class CardPrintWastePickerConfiguration : IEntityTypeConfiguration<CardPrintWastePicker>
    {
        public void Configure(EntityTypeBuilder<CardPrintWastePicker> builder)
        {
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.RegistrationNo).IsRequired();
        }
    }
}