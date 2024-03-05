using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
    public interface ICooperativeService
    {
        Task<IReadOnlyList<Cooperative>> GetCooperativesAsync();
        Task<Cooperative> GetCooperativeByIdAsync(int id);
    }
}