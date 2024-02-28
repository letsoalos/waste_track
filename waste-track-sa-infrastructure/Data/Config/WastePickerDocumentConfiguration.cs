using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class WastePickerDocumentConfiguration : IEntityTypeConfiguration<WastePickerDocument>
    {
        public void Configure(EntityTypeBuilder<WastePickerDocument> builder)
        {
            builder.HasOne(w => w.WastePicker).WithOne().HasForeignKey<WastePickerDocument>(w => w.WastePickerId);
            builder.HasOne(d => d.DocumentType).WithMany().HasForeignKey(w => w.DocumentTypeId);
            builder.HasOne(m => m.MasterCode).WithOne().HasForeignKey<WastePickerDocument>(w => w.MasterCodeId);
            builder.Property(w => w.Potrait).IsRequired();
        }
    }
}