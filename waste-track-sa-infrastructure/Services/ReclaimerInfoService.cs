using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_infrastructure.Services
{
    public class ReclaimerInfoService : IReclaimerInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReclaimerInfoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<ReclaimingInfo>> GetReclamersAsync()
        {
            var spec = new ReclaimerInfoWithLookUpDataSpecification();

            return await _unitOfWork.Repository<ReclaimingInfo>().ListAsync(spec);
        }
    }
}