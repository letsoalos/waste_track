namespace waste_track_sa_core.Entities
{
    public class CooperativeInfo : BaseEntity
    {
        public int WastePickerId { get; set; }
        public int CooperativeId { get; set; }
        public DateTime WastePickerStartDate { get; set; }
        public int WorksiteId { get; set; }                 //LastWastePickerSite
        public int Consent { get; set; }
        public DateTime YearJoined { get; set; }
        public string Comment { get; set; }
        public bool IActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public WastePicker WastePicker { get; set; }
        public Cooperative Cooperative { get; set; }
        public Worksite Worksite { get; set; }
    }
}