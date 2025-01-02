using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.Time;

namespace Shared.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddSharedInfrastructure
            (this IServiceCollection services)
        {
            return services
                .AddTime();
        }
    }
}
