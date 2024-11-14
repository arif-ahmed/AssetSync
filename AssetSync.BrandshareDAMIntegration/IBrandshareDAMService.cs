
using AssetSync.BrandshareDAMIntegration.Models;

namespace AssetSync.BrandshareDAMIntegration
{
    public interface IBrandshareDAMService
    {
        void TestConnection();
        Task<List<SyncJobDTO>> GetSyncJobs(string machineName);
        void GetSyncJob(string jobId);
        void GetVolumes(string jobId);
        void GetFiles(int pageSize, int pageLimit = 100);
    }
}
