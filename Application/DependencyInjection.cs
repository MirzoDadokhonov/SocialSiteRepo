using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using SocialSiteClassLibrary.Entities;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Comment>, CommentService>();
            services.AddScoped<IBaseService<User>, UserService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
