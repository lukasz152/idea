using Core.Repositories;
using Infrastructure.PostgreSql.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure.PostgreSql
{
    internal static class Extensions
    {
        public static IServiceCollection AddPostgreSql
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
