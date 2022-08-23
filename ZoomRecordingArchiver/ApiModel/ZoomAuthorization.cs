namespace Ueshiman.ZoomRecordingArchiver.ApiModel
{
    public class ZoomAuthorization
    {
        public string? access_token { get; set; }
        public string? token_type { get; set; }
        public string? refresh_token { get; set; }
        public int expires_in { get; set; }
        public string? scope { get; set; }
        public DateTimeOffset GeneratedDateTime { get; set; } = DateTimeOffset.UtcNow;
    }
}
