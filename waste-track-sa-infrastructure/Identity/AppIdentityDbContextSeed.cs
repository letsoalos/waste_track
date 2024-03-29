using Microsoft.AspNetCore.Identity;
using waste_track_sa_core.Entities.Identity;

namespace waste_track_sa_infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager) 
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Sello",
                    Email = "sello@test.com",
                    UserName = "sello@test.com",
                    Address = new Address
                    {
                        FirstName = "Sello",
                        LastName = "Letsoalo",
                        Street = "24 Church Street",
                        City = "Pretoria",
                        Code = "2190"
                    }
                };

                await userManager.CreateAsync(user, "LimiT@2022");
            }
        }       
    }
}