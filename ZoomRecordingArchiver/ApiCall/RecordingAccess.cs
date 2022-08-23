using Ueshiman.ZoomRecordingArchiver.ApiModel;

namespace Ueshiman.ZoomRecordingArchiver.ApiCall
{
    public class RecordingAccess
    {
        public async Task<Recording?> GetRecordingAsync(string accessToken, string? nextPageToken, string userId, int pageNumber, DateTimeOffset from, DateTimeOffset to)
        {
            var meetingClient = new HttpClient();

            meetingClient.DefaultRequestHeaders.Add("Host", "api.zoom.us");
            meetingClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            //string nextPageParameter = nextPageToken == null ? $"&from={from:O}&to={to:O}&page_number={pageNumber}" : $"&page_number={pageNumber}&next_pate_token={nextPageToken}";
            string nextPageParameter = nextPageToken == null ? string.Empty : $"&next_page_token={nextPageToken}";

            //HttpResponseMessage recordingResponse = await meetingClient.GetAsync(@$"https://api.zoom.us/v2/users/{userId}/recordings?page_size=2&mc=false&trash=false{nextPageParameter}");
            HttpResponseMessage recordingResponse = await meetingClient.GetAsync(@$"https://api.zoom.us/v2/users/{userId}/recordings?page_size=1&mc=false&trash=false&from={from:O}&to={to:O}{ nextPageParameter}");
            //HttpResponseMessage recordingResponse = await meetingClient.GetAsync(@$"https://api.zoom.us/v2/users/{userId}/recordings?page_size=300&mc=false&trash=false&from=2020-01-01&to=2022-08-12");

            string recordingJson = await recordingResponse.Content.ReadAsStringAsync();

            Recording? recording = System.Text.Json.JsonSerializer.Deserialize<Recording>(recordingJson);
            return recording;
        }
    }
}
