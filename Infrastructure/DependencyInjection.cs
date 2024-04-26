using SocialSiteClassLibrary.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SocialSiteClassLibrary.Entities;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(IUserRepository), typeof(UserRepository));

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                if (configuration["UseInMemoryDatabase"] == "true")
                    options.UseInMemoryDatabase("testDb");
                else
                    options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}