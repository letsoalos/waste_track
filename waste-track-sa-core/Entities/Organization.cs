namespace waste_track_sa_core.Entities
{
    public class Organization : BaseEntity
    {
        public int? OrganizationTypeId { get; set; }
        public int MunicipalityId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Contacts { get; set; }
        public string? Code { get; set; }


        public OrganizationType? OrganizationType { get; set; }
        public Municipality? Municipality { get; set; }
    }
}