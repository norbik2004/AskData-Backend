using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AskData.Bootstrapper.Bootstrap;

/// <summary>
/// Explicit module composition. Add a new module by registering it here (and its consumers
/// in <see cref="Messaging"/>). No reflection/magic — the wiring stays greppable.
/// </summary>
internal static class Modules
{
    public static IServiceCollection AddModules(this IServiceCollection services, IConfiguration configuration)
    {
        /*
        services.RegisterAccountsModule();
        */
        return services;
    }
}
