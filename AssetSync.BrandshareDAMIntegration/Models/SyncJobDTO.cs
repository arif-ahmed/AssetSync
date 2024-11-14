
namespace AssetSync.BrandshareDAMIntegration.Models
{
    public class SyncJobDTO
    {
        public string Id { get; set; }

        public string JobName { get; set; }

        public string MachineName { get; set; }

        public string VolumeName { get; set; }

        public string VolumeId { get; set; }

        public string ListId { get; set; }

        public string SyncType { get; set; }

        public string FolderFieldId { get; set; }

        public long JobStartTime { get; set; }

        public int JobInterVal { get; set; }

        public string SyncDirection { get; set; }

        public string DestinationPath { get; set; }

        public string JobStatus { get; set; }

        public long LastRunTime { get; set; }

        public long NextRunTime { get; set; }

        public bool IsActive { get; set; }

        public string PrimaryLocation { get; set; }

        public string VolumePath { get; set; }

        public string LiveLogApi { get; set; }

        public string CurrentStatus { get; set; }

        // C# equivalent of a computed property in Java
        public string GetSyncDirection()
        {
            return SyncDirection == "D2L" ? "DAM V3 to Local" : "Local to DAM V3";
        }

        public string GetCurrentStatus()
        {
            return CurrentStatus;
        }

        public void SetCurrentStatus(string status)
        {
            CurrentStatus = status;
        }

        public string GetLiveLogApi()
        {
            return LiveLogApi;
        }
    }

}
