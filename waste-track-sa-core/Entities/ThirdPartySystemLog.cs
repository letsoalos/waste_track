namespace waste_track_sa_core.Entities
{
    public class ThirdPartySystemLog : BaseEntity
    {
        public int ThirdPartySystemId { get; set; }
        public int APIId { get; set; }
        public string? Details { get; set; }
        public string? Description { get; set; }
        public string? SourceIP { get; set; }
        public DateTime CreatedDate { get; set; }


        public ThirdPartySystem? ThirdPartySystem { get; set; }
        public API? API { get; set; }
    }
}