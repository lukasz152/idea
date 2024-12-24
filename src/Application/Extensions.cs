using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services //mediatr znajduje pod dany query/command ,handler 
                .AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //z calego tego projektu mediatr ma zarejestrowac (deafultowa transient)
        }
    }
}
