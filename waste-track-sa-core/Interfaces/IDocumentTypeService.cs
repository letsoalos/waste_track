using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
    
    public interface IDocumentTypeService
    {
        Task<IReadOnlyList<DocumentType>> GetDocumentTypeAsync();
    }
}