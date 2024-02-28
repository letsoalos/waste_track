namespace waste_track_sa_core.Entities
{
    public class Municipality : BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Code { get; set; }
        public string? Contacts { get; set; }
        public int DistrictId { get; set; }
        

        public District? District { get; set; }
    }
}