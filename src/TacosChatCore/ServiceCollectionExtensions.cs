using Microsoft.Extensions.DependencyInjection;
using TacosChatCore.Models;
using TacosChatCore.Repos;
using TacosChatCore.Services;

namespace TacosChatCore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<SettingsRepo>();

        return services;
    }
}