
using AssetSync.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetSync.BrandshareDAMIntegration
{
    public abstract class BrandshareDAMSyncService : SyncService
    {
        protected IBrandshareDAMService BrandshareDAMService { get; }

        protected string SyncJobId { get; set; } = string.Empty;
        protected string VolumeId { get; set; } = string.Empty;
        protected string VolumePath { get; set; } = string.Empty;
        protected string LocalPath { get; set; } = string.Empty;
        protected string SyncType { get; set; } = string.Empty;
        protected string SyncDirection { get; set; } = string.Empty;

        public BrandshareDAMSyncService(IBrandshareDAMService brandshareDAMService, string syncJobId, string volumeId, string volumePath, string localPath, string syncType, string syncDirection)
        {
            BrandshareDAMService = brandshareDAMService;
            SyncJobId = syncJobId;
            VolumeId = volumeId;
            VolumePath = volumePath;
            LocalPath = localPath;
            SyncType = syncType;
            SyncDirection = syncDirection;
        }
    }
}
