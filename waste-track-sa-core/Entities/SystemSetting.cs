namespace waste_track_sa_core.Entities
{
    public class SystemSetting : BaseEntity
    {
        public string SystemSettingName { get; set; }
        public string SystemSettingValue { get; set; }
        public int ValueDataType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}