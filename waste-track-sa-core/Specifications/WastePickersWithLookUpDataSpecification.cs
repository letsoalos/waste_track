using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Specifications
{
    public class WastePickersWithLookUpDataSpecification : BaseSpecification<WastePicker>
    {
        public WastePickersWithLookUpDataSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Gender);
            AddInclude(x => x.Race);
            AddInclude(x => x.WastePickerStatus);
            AddInclude(x => x.DocumentType);
            AddInclude(x => x.Cooperative);            
        }
                
        public WastePickersWithLookUpDataSpecification(WastePickerSpecParams wastePickerParams)
        {
            AddInclude(x => x.Gender);
            AddInclude(x => x.Race);
            AddInclude(x => x.WastePickerStatus);
            AddInclude(x => x.DocumentType);
            AddInclude(x => x.Cooperative);
            AddOrderBy(x => x.LastName);
            ApplyPaging(wastePickerParams.PageSize * (wastePickerParams.PageIndex - 1), wastePickerParams.PageSize);

            if (!string.IsNullOrEmpty(wastePickerParams.Sort))
            {
                switch (wastePickerParams.Sort)
                {
                    case "firstNameAsc":
                        AddOrderBy(f => f.FirstName);
                        break;
                    case "firstNameDesc":
                        AddOrderByDescending(f => f.FirstName);
                        break;
                    default:
                         AddOrderBy(x => x.LastName);
                         break;                        
                }
            }
        }
    }
}