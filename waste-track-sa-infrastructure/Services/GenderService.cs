using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class GenderService : IGenderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GenderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<Gender>> GetGenderAsync()
        {
             return await _unitOfWork.Repository<Gender>().GetAllAsync();
        }
    }
}