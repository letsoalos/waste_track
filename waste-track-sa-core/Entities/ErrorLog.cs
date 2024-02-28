namespace waste_track_sa_core.Entities
{
    public class ErrorLog : BaseEntity
    {
        public string? Username { get; set; }
        public DateTime LogDate { get; set; }
        public string? Method { get; set; }
        public string? Class { get; set; }
        public string? ErrorMessage { get; set; }
        public string? SourceAddress { get; set; }
    }
}