using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Specifications
{
    public class MunicipalityWithDistrict : BaseSpecification<Municipality>
    {
        public MunicipalityWithDistrict(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.District);           
        }
        
        public MunicipalityWithDistrict()
        {
            AddInclude(x => x.District);           
        }
    }
}