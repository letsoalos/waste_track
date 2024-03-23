using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class IncomeMethodService : IIncomeMethodService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IncomeMethodService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<IncomeMethod>> GetIncomeMethodAsync()
        {
           return await _unitOfWork.Repository<IncomeMethod>().GetAllAsync();
        }
    }
}