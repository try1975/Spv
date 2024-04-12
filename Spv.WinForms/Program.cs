using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Spv.WinForms.Models;

namespace Spv.WinForms;

internal static class Program
{
    private static IHost host;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        host = CreateHostBuilder(args).Build();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(host.Services.GetRequiredService<MainForm>());
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("spv");
                    services.AddDbContext<SpvContext>(options => options
                        .UseSqlServer(connectionString));
                    services.AddScoped<ISpvContextProcedures, SpvContextProcedures>();
                    services.AddSingleton<MainForm>();
                })
                .ConfigureLogging((context, builder) =>
                {
                    builder.ClearProviders();
                    var logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(context.Configuration)
                        .CreateLogger();
                    builder.AddSerilog(logger);
                })
        ;
}