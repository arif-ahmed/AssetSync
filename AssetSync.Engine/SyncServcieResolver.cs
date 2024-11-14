using AssetSync.Engine.Contracts;

namespace AssetSync.Engine
{
    public class SyncServcieResolver
    {
        public ISyncService ResolveSyncService()
        {
            return new SyncService();
        }
    }
}
