namespace Ueshiman.ZoomRecordingArchiver.ApiModel
{
    public class Recording
    {
        public string? from { get; set; }
        public string? to { get; set; }
        public string? next_page_token { get; set; }
        public int? page_count { get; set; }
        public int? page_size { get; set; }
        public int? total_records { get; set; }
        public Meeting[]? meetings { get; set; }
    }

    public class RecordingForJson
    {
        public string? from { get; set; }
        public string? to { get; set; }
        public string? next_page_token { get; set; }
        public int? page_count { get; set; }
        public int? page_size { get; set; }
        public int? total_records { get; set; }
        public MeetingFoJson[]? meetings { get; set; }
    }

    public class Meeting
    {
        public string? userId { get; set; }
        public string? account_id { get; set; }
        public int? duration { get; set; }
        public string? host_id { get; set; }
        public long? id { get; set; }
        public int? recording_count { get; set; }
        public DateTimeOffset? start_time { get; set; }
        public string? topic { get; set; }
        public long? total_size { get; set; }
        public int? type { get; set; }
        public string? uuid { get; set; }
        public string? share_url { get; set; }
        public Recording_File[]? recording_files { get; set; }
    }

    public class MeetingFoJson
    {
        public string? userId { get; set; }
        public string? account_id { get; set; }
        public int? duration { get; set; }
        public string? host_id { get; set; }
        public long? id { get; set; }
        public int? recording_count { get; set; }
        public DateTimeOffset? start_time { get; set; }
        public string? topic { get; set; }
        public long? total_size { get; set; }
        public int? type { get; set; }
        public string? uuid { get; set; }
        public string? share_url { get; set; }
        public Recording_File_forJson[]? recording_files { get; set; }
    }

    public class Recording_File
    {
        public DateTimeOffset? deleted_time { get; set; }
        public string? download_url { get; set; }
        public string? file_path { get; set; }
        public int? file_size { get; set; }
        public string? file_type { get; set; }
        public string? file_extension { get; set; }
        public string? id { get; set; }
        public string? meeting_id { get; set; }
        public string? play_url { get; set; }
        public DateTimeOffset? recording_end { get; set; }
        public DateTimeOffset? recording_start { get; set; }
        public string? recording_type { get; set; }
        public string? status { get; set; }
    }



        public class Recording_File_forJson
    {
        public DateTimeOffset? deleted_time { get; set; }
        public string? download_url { get; set; }
        public string? file_path { get; set; }
        public int? file_size { get; set; }
        public string? file_type { get; set; }
        public string? file_extension { get; set; }
        public string? id { get; set; }
        public string? meeting_id { get; set; }
        public string? play_url { get; set; }
        public string? recording_end { get; set; }
        public DateTimeOffset? recording_start { get; set; }
        public string? recording_type { get; set; }
        public string? status { get; set; }
    }
}
