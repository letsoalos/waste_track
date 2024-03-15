using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class RaceService : IRaceService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RaceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IReadOnlyList<Race>> GetRaceAsync()
        {
            return await _unitOfWork.Repository<Race>().GetAllAsync();
        }
    }
}