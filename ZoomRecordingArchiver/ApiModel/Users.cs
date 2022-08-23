namespace Ueshiman.ZoomRecordingArchiver.ApiModel
{
    public class Users
    {
        public int? page_count { get; set; }
        public int? page_number { get; set; }
        public int? page_size { get; set; }
        public int? total_records { get; set; }
        public string? next_page_token { get; set; }
        public User[]? users { get; set; }
    }

    public class User
    {
        public string? id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }
        public int? type { get; set; }
        public long? pmi { get; set; }
        public string? timezone { get; set; }
        public int? verified { get; set; }
        public DateTimeOffset? created_at { get; set; }
        public DateTimeOffset last_login_time { get; set; }
        public string? last_client_version { get; set; }
        public string? language { get; set; }
        public string? phone_number { get; set; }
        public string? status { get; set; }
        public string? role_id { get; set; }
        public string? pic_url { get; set; }
        public string? dept { get; set; }
    }

}
