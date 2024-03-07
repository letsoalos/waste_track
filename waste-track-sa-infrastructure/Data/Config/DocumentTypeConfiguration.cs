using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            //builder.Property(d => d.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(d => d.DocType).IsRequired().HasMaxLength(20);
            builder.HasOne(m => m.MasterCode).WithMany().HasForeignKey(d => d.MasterCodeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}