using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieFlow.Areas.Identity.Data;
using MovieFlow.Data;

[assembly: HostingStartup(typeof(MovieFlow.Areas.Identity.IdentityHostingStartup))]
namespace MovieFlow.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthorizationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthorizationDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    // options.Password.RequireLowercase = false;
                    // options.Password.RequireDigit = false;
                })
                    .AddEntityFrameworkStores<AuthorizationDbContext>();
            });
        }
    }
}