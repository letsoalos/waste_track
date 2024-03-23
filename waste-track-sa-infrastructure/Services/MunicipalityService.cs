using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_infrastructure.Services
{
    public class MunicipalityService : IMunicipalityService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MunicipalityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<Municipality>> GetMunicipalitiesAsync()
        {
            var spec = new MunicipalityWithDistrict();
            
             return await _unitOfWork.Repository<Municipality>().ListAsync(spec);
        }

    }
}