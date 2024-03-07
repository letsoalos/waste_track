using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class CooperativeService : ICooperativeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CooperativeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Cooperative> GetCooperativeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Cooperative>> GetCooperativesAsync()
        {
            return await _unitOfWork.Repository<Cooperative>().GetAllAsync();
        }
    }
}