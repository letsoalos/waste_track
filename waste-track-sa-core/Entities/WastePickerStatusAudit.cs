namespace waste_track_sa_core.Entities
{
    public class WastePickerStatusAudit : BaseEntity
    {
        public int WastePickerId { get; set; }
        public int WastePickerStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Comment { get; set; }


        public WastePicker WastePicker { get; set; }
        public WastePickerStatus WastePickerStatus { get; set; }
    }
}