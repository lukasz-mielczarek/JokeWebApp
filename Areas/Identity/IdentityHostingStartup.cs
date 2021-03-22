using JokeWebApp.Areas.Identity.Data;
using JokeWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(JokeWebApp.Areas.Identity.IdentityHostingStartup))]
namespace JokeWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<JokeWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("JokeWebAppContextConnection")));

                services.AddDefaultIdentity<JokeWebAppUser>(options => options.SignIn.RequireConfirmedAccount = false)
                        .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<JokeWebAppContext>();

            });
        }
    }
}