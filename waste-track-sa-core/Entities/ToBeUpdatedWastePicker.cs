namespace waste_track_sa_core.Entities
{
    public class ToBeUpdatedWastePicker : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int WastePickerNo { get; set; }
        public DateTime CreatedDate { get; set; }
        
    }
}