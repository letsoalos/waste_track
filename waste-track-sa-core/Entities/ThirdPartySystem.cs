namespace waste_track_sa_core.Entities
{
    public class ThirdPartySystem : BaseEntity
    {
        public string? SystemName { get; set; }
        public string? SystemURL { get; set; }
        public string? SystemDescription { get; set; }
        public string? OrganizationName { get; set; }
        public string? OrganizationWebsite { get; set; }
        public int AccountStatus { get; set; }              //We dont have status table
        public string? ReferenceNumber { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactNumber { get; set; }
        public string? ContactEmail { get; set; }
        public string? AccountActivationCode { get; set; }
        public DateTime AccountActivationDate { get; set; }
        public string? APIKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

    }
}