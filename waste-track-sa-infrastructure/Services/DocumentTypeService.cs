using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;

namespace waste_track_sa_infrastructure.Services
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DocumentTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<DocumentType>> GetDocumentTypeAsync()
        {
            return await _unitOfWork.Repository<DocumentType>().GetAllAsync();
        }
    }
}