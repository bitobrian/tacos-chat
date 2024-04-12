using Microsoft.Extensions.DependencyInjection;
using TacosChatCore.Models;
using TacosChatCore.Services;

namespace TacosChatCore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<SettingsService>();

        return services;
    }
}