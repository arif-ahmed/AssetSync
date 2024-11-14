
using AssetSync.Engine;
using AssetSync.Engine.Contracts;

namespace AssetSync.CLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SyncServcieResolver resolver = new SyncServcieResolver();
            ISyncService syncService = resolver.ResolveSyncService();
            syncService.Sync();
        }
    }
}