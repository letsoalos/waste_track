namespace waste_track_sa_core.Entities
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public string Contacts { get; set; }
        public int ProviceId { get; set; }


        //virtual properties
        public Province Province { get; set; }
    }
}