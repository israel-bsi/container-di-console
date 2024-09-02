using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1;

public static class ConfigurationServices
{
    public static void RegisterServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<IClienteRepository, ClienteRepository>();
        services.AddTransient<IClienteService, ClienteService>();

        var serviceProvider = services.BuildServiceProvider();

        ServiceLocator.SetServiceProvider(serviceProvider);
    }
}