namespace waste_track_sa_core.Entities
{
    public class Cooperative : BaseEntity
    {
        public string Name { get; set; }
        public string YearEstablish { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}