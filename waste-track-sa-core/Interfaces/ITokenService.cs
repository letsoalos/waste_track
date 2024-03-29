using waste_track_sa_core.Entities.Identity;

namespace waste_track_sa_core.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}