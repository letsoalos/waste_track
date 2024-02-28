namespace waste_track_sa_core.Entities
{
    public class SystemLog : BaseEntity
    {
        public int UserId { get; set; }             //still deciding on the main table
        public DateTime LogDate { get; set; }
        public string? LogAction { get; set; }
        public int RecordId { get; set; }
        public string? Group { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Username { get; set; }
        public string? SourceAddress { get; set; }
    }
}