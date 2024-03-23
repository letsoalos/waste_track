using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class SortingAreaService : ISortingAreaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SortingAreaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<SortingArea>> GetSortingAreaAsync()
        {
           return await _unitOfWork.Repository<SortingArea>().GetAllAsync();
        }
    }
}