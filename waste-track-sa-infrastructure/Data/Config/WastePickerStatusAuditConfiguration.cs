using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class WastePickerStatusAuditConfiguration : IEntityTypeConfiguration<WastePickerStatusAudit>
    {
        public void Configure(EntityTypeBuilder<WastePickerStatusAudit> builder)
        {
            builder.HasOne(w => w.WastePickerStatus).WithMany().HasForeignKey(w => w.WastePickerStatusId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(w => w.WastePicker).WithMany().HasForeignKey(w => w.WastePickerId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}