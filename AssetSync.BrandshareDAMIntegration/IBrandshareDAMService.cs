
namespace AssetSync.BrandshareDAMIntegration
{
    public interface IBrandshareDAMService
    {
        void TestConnection();
        void GetSyncJobs(string machineName);
        void GetSyncJob(string jobId);
        void GetVolumes(string jobId);
        void GetFiles(int pageSize, int pageLimit = 100);
    }
}
