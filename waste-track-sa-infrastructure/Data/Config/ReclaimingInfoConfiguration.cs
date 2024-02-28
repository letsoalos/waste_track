using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class ReclaimingInfoConfiguration : IEntityTypeConfiguration<ReclaimingInfo>
    {
        public void Configure(EntityTypeBuilder<ReclaimingInfo> builder)
        {
            builder.Property(r => r.Address).IsRequired().HasMaxLength(250);
            builder.HasOne(w => w.WastePicker).WithMany().HasForeignKey(r => r.WastePickerId);
            builder.HasOne(w => w.Worksite).WithMany().HasForeignKey(r => r.WorksiteId);
            builder.HasOne(w => w.Municipality).WithMany().HasForeignKey(r => r.MunicipalityId);
            builder.HasOne(w => w.IncomeMethod).WithMany().HasForeignKey(r => r.IncomeMethodId);
            builder.HasOne(w => w.SortingArea).WithMany().HasForeignKey(r => r.SortingAreaId);
        }
    }
}