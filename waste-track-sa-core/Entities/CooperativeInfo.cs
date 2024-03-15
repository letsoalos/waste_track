namespace waste_track_sa_core.Entities
{
    public class CooperativeInfo : BaseEntity
    {
        public int WastePickerId { get; set; }
        public int CooperativeId { get; set; }
        public string WastePickerStartDate { get; set; }
        public int WorksiteId { get; set; }                 //LastWastePickerSite
        public int Consent { get; set; }
        public string YearJoined { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString("YYYY-MM-DD");
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedDate { get; set; }

        public WastePicker WastePicker { get; set; }
        public Cooperative Cooperative { get; set; }
        public Worksite Worksite { get; set; }
    }
}