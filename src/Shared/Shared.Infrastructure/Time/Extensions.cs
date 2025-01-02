using Abstractions.time;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Infrastructure.Time
{
    public static class Extensions
    {
        public static IServiceCollection AddTime(this IServiceCollection services) 
        {
            return services
                .AddSingleton<IClock, UtcClock>();
        }
    }
}
