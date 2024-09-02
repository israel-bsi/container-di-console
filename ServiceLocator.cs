using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1;

public static class ServiceLocator
{
    private static IServiceProvider _serviceProvider = null!;
    public static void SetServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public static T GetService<T>()
    {
        return _serviceProvider.GetService<T>()!;
    }
}