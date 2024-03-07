namespace waste_track_sa_core.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }         //No status table
        public int RegistrationNo { get; set; }
        public string ActivationCode { get; set; }
        public bool EmailVerified { get; set; }
        public DateTime EmailVerifiedDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public string PasswordHash { get; set; }


        public UserType UserType { get; set; }
    }
}