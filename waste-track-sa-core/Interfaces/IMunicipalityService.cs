using waste_track_sa_core.Entities;

namespace waste_track_sa_core.Interfaces
{
    public interface IMunicipalityService
    {
        Task<IReadOnlyList<Municipality>> GetMunicipalitiesAsync();
       
    }
}