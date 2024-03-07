namespace waste_track_sa_core.Entities
{
    public class UserRole : BaseEntity
    {
        public int UserTypeId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }


        public UserType UserType { get; set; }
        public User User { get; set; }
    }
}