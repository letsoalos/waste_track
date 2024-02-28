namespace waste_track_sa_core.Entities
{
    public class APIAccess : BaseEntity
    {
        public int ThirdPartySystemId { get; set; }
        public int APIId { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }


        public ThirdPartySystem? ThirdPartySystem { get; set; }
        public API? API { get; set; }
    }
}