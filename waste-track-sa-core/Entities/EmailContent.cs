namespace waste_track_sa_core.Entities
{
    public class EmailContent : BaseEntity
    {
        public string? Content { get; set; }
        public string? Subject { get; set; }
        public int Type { get; set; }
        public string? Attachment { get; set; }
        public string? ToAddress { get; set; }
        public string? CCAddress { get; set; }
        public string? BCAddress { get; set; }
        public int StatusId { get; set; }           //cant locate associated table
        public int? Attempts { get; set; }
        public string? ErrorMessage { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}