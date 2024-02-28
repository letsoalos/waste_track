namespace waste_track_sa_core.Entities
{
    public class UserSession : BaseEntity
    {
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string? Username { get; set; }
        public string? LoginStatus { get; set; }        //no status table
        public string? LogoutStatus { get; set; }
        public string? Token { get; set; }
    }
}