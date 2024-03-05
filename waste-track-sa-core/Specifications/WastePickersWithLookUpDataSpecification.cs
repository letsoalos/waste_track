using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Specifications
{
    public class WastePickersWithLookUpDataSpecification : BaseSpecification<WastePicker>
    {
        public WastePickersWithLookUpDataSpecification()
        {
            AddInclude(x => x.Gender);
            AddInclude(x => x.Race);
            AddInclude(x => x.WastePickerStatus);
            AddInclude(x => x.DocumentType);
            AddInclude(x => x.Cooperative);
        }
    }
}