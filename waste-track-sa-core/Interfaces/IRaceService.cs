using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
    public interface IRaceService
    {
        Task<IReadOnlyList<Race>> GetRaceAsync();
    }
}