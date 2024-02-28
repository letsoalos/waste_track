namespace waste_track_sa_core.Entities
{
    public class ReclaimingInfo : BaseEntity
    {
        public int WastePickerId { get; set; }
        public DateTime Year { get; set; }
        public int WorksiteId { get; set; }
        public int MunicipalityId { get; set; }
        public int IncomeMethodId { get; set; }
        public int SortingAreaId { get; set; }
        public string? Address { get; set; }
        public string? Comment { get; set; }


        public WastePicker? WastePicker { get; set; }
        public Worksite? Worksite { get; set; }
        public Municipality? Municipality { get; set; }
        public IncomeMethod? IncomeMethod { get; set; }
        public SortingArea? SortingArea { get; set; }
    }
}