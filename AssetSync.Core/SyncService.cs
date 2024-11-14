namespace AssetSync.Core
{
    public abstract  class SyncService : ISyncService
    {
        public void Sync()
        {

        }

        public abstract void SyncAlgorithm();
    }
}
