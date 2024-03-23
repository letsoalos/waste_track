using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class WorkSiteService : IWorkSiteService
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkSiteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<Worksite>> GetWorkSiteAsync()
        {
           return await _unitOfWork.Repository<Worksite>().GetAllAsync();
        }
    }
}