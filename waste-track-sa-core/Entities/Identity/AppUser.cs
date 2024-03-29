using Microsoft.AspNetCore.Identity;

namespace waste_track_sa_core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}