using AssetSync.BrandshareDAMIntegration;
using AssetSync.Core;
using Microsoft.Extensions.Hosting;

namespace AssetSync.Engine
{
    public class SyncWorker : BackgroundService
    {
        protected IBrandshareDAMService brandshareDAMService;
        public SyncWorker(IBrandshareDAMService brandshareDAMService) 
        {
            this.brandshareDAMService = brandshareDAMService ?? throw new ArgumentNullException(nameof(brandshareDAMService));
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested) 
            {
                brandshareDAMService.TestConnection();

                Console.WriteLine($"Machine: {Environment.MachineName}");
                var syncJobs = await brandshareDAMService.GetSyncJobs(Environment.MachineName);
                Parallel.ForEach(syncJobs, (syncJob) =>
                {

                });

                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }

        }
    }
}
