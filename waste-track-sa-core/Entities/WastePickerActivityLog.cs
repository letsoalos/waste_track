namespace waste_track_sa_core.Entities
{
    public class WastePickerActivityLog : BaseEntity
    {
        public string RegistrationNo { get; set; }
        public int WastePickerStatusId { get; set; }
        public string LogCode { get; set; }
        public string Description { get; set; }
        public DateTime ActivityDate { get; set; }
        public int ActivityStatusId { get; set; }          //status table not available
        public DateTime CreatedDate { get; set; }


        public WastePickerStatus WastePickerStatus { get; set; }
    }
}