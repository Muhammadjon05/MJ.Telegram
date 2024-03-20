using Microsoft.Extensions.DependencyInjection;

namespace MJ.Telegram;

public static class ServiceCollectionExtensions
{
    public static void AddTelegramCommands(this IServiceCollection services)
    {
        services.AddSingleton<ICommandFactory, CommandFactory>();
    }
}