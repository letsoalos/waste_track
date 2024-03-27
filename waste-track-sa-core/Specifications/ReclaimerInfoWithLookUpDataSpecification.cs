using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Specifications
{
    public class ReclaimerInfoWithLookUpDataSpecification :  BaseSpecification<ReclaimingInfo>
    {
         public ReclaimerInfoWithLookUpDataSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.WastePicker);
            AddInclude(x => x.Worksite);
            AddInclude(x => x.Municipality);
            AddInclude(x => x.IncomeMethod);
            AddInclude(x => x.SortingArea);          
        }
                
        public ReclaimerInfoWithLookUpDataSpecification()
        {
            AddInclude(x => x.WastePicker);
            AddInclude(x => x.Worksite);
            AddInclude(x => x.Municipality);
            AddInclude(x => x.IncomeMethod);
            AddInclude(x => x.SortingArea);     
        }
    }
}