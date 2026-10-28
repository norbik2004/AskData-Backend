using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AskData.Bootstrapper.Bootstrap;

internal static class Messaging
{
    public static IServiceCollection AddAppMessaging(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddMessaging(configuration, configurator =>
        {
            configurator.RegisterAccountsConsumers();
            configurator.RegisterEmailsConsumers();
        });
    }
}
