using Ueshiman.ZoomRecordingArchiver.ApiModel;

namespace ZoomRecordingArchiver.ApiModel
{
    internal class FileInformation
    {
        public User User { get; set; }
        public Meeting Meeting { get; set; }
        public Recording_File File { get; set; }
    }
}
