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
            services.AddScoped<IBaseService<Friend>, FriendService>();
            services.AddScoped<IBaseService<Group>, GroupService>();
            services.AddScoped<IBaseService<GroupMember>, GroupMemberService>();
            services.AddScoped<IBaseService<Like>, LikeService>();
            services.AddScoped<IBaseService<Message>, MessageService>();
            services.AddScoped<IBaseService<Post>, PostService>();
            services.AddScoped<IBaseService<User>, UserService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
