namespace waste_track_sa_core.Entities
{
    public class UserInfo : BaseEntity
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Telephone { get; set; }
        public DateTime RegDate { get; set; }
        public int? MunicipalityId { get; set; }
        public int? OrganizationId { get; set; }
        public int Consent { get; set; }
        public int? OfficialTypeId { get; set; }


        public User? User { get; set; }
        public Municipality? Municipality { get; set; }
        public Organization? Organization { get; set; }
        public OfficialType? OfficialType { get; set; }
    }
}