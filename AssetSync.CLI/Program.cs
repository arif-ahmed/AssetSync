
using AssetSync.BrandshareDAM.Models;
using AssetSync.BrandshareDAM.Repositories;
using AssetSync.BrandshareDAMIntegration;
using AssetSync.Core;
using AssetSync.Engine;

namespace AssetSync.CLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SyncServcieResolver resolver = new SyncServcieResolver();
            //ISyncService syncService = resolver.ResolveSyncService();
            //syncService.Sync();

            BrandshareDAMDBContext context = new BrandshareDAMDBContext();
            var repository = new GenericRepository<SyncJob>(context);

            repository.GetAllAsync().Wait();


            //IBrandshareDAMService brandshareDAMService = new BrandshareDAMManager();
            //ISyncService syncService = new ForwardSyncService(brandshareDAMService, "123", "123", "123", "123", "123", "123");
        }
    }
}