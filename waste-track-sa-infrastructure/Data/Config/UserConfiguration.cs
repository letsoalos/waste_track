using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.RegistrationNo).IsRequired();
            builder.HasOne(u => u.UserType).WithMany().HasForeignKey(u => u.UserTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}