using AssetSync.BrandshareDAMIntegration;
using AssetSync.Core;
using AssetSync.Engine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AssetSync.CLI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<IBrandshareDAMService, BrandshareDAMService>();
                    services.AddHostedService<SyncWorker>();
                })
                .Build();

            await host.RunAsync();
        }
    }
}