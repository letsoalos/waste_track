namespace waste_track_sa_core.Entities
{
    public class WastePickerDocument : BaseEntity
    {
        public int WastePickerId { get; set; }
        public int DocumentTypeId { get; set; }
        public int MasterCodeId { get; set; }
        public string Potrait { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString();
        public string CreatedBy { get; set; }
        public string LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

       
        public DocumentType DocumentType { get; set; }
        public WastePicker WastePicker { get; set; }
        public MasterCode MasterCode { get; set; }
    }
}