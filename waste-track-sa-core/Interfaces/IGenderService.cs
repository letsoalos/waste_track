using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
    public interface IGenderService
    {
        Task<IReadOnlyList<Gender>> GetGenderAsync();
    }
}