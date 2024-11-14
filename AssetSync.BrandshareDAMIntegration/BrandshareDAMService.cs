
using AssetSync.BrandshareDAMIntegration.Models;

namespace AssetSync.BrandshareDAMIntegration
{
    public class BrandshareDAMService : IBrandshareDAMService
    {
        public void GetFiles(int pageSize, int pageLimit = 100)
        {
            throw new NotImplementedException();
        }

        public void GetSyncJob(string jobId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SyncJobDTO>> GetSyncJobs(string machineName)
        {
            var syncJobs = new List<SyncJobDTO> { };
            return await Task.FromResult(syncJobs);
        }

        public void GetVolumes(string jobId)
        {
            throw new NotImplementedException();
        }

        public void TestConnection()
        {
            Console.WriteLine("Connected..................");
        }
    }
}
