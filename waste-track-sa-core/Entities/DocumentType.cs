namespace waste_track_sa_core.Entities
{
    public class DocumentType : BaseEntity
    {
        public string DocType { get; set; }
        public int MasterCodeId { get; set; }

        public MasterCode MasterCode { get; set; }
    }
}