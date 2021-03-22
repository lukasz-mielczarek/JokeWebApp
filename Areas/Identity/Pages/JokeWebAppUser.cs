using Microsoft.AspNetCore.Identity;

namespace JokeWebApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the JokeWebAppUser class
    public class JokeWebAppUser : IdentityUser
    {
        public bool Admin { get; set; }
    }
}
