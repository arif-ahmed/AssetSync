using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetSync.BrandshareDAMIntegration
{
    public class ForwardSyncService : BrandshareDAMSyncService
    {
        public ForwardSyncService(IBrandshareDAMService brandshareDAMService, string syncJobId, string volumeId, string volumePath, string localPath, string syncType, string syncDirection) : base(brandshareDAMService, syncJobId, volumeId, volumePath, localPath, syncType, syncDirection)
        {
        }

        public override void SyncAlgorithm()
        {
            BrandshareDAMService.GetVolumes();
        }
    }
}
