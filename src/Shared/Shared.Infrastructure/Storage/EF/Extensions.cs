using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Shared.Infrastructure.Storage.EF
{
    public static class Extensions
    {
        public static IApplicationBuilder MigrateDatabase<T>(this IApplicationBuilder app)
            where T : DbContext
        {
            using var scope = app.ApplicationServices.CreateScope();

            var postgreSqlOptions = scope.ServiceProvider.
                GetRequiredService<IOptions<PostgreSqlOptions>>();

            if (postgreSqlOptions.Value.MigrateAutomatically)
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<T>();
                dbContext.Database.Migrate();
            }

            return app;
        }
    }
}
