using Ueshiman.ZoomRecordingArchiver.ApiModel;

namespace Ueshiman.ZoomRecordingArchiver.ApiCall
{
    public class UserAccess
    {
        //private async Task<Users?> GetAllUsersAsync(string accessToken)
        //{
        //    var userClient = new HttpClient();

        //    userClient.DefaultRequestHeaders.Add("Host", "api.zoom.us");
        //    userClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

        //    HttpResponseMessage usersResult = await userClient.GetAsync(@$"https://api.zoom.us/v2/users?page_size=300");
        //    //HttpResponseMessage usersResult = await userClient.GetAsync(@$"https://api.zoom.us/v2/users?page_size=300/");
        //    string usersJson = await usersResult.Content.ReadAsStringAsync();
        //    Users? users = System.Text.Json.JsonSerializer.Deserialize<Users>(usersJson);

        //    return users;
        //}
        public async Task<Users?> GetAllUsersAsync(string accessToken, string? nextPageToken)
        {
            //if (nextPageToken == null)
            //{
            //    return await GetAllUsersAsync(accessToken);
            //}
            string nextPageParameter = nextPageToken == null ? string.Empty : $"&next_page_token={nextPageToken}";

            var userClient = new HttpClient();

            userClient.DefaultRequestHeaders.Add("Host", "api.zoom.us");
            userClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            HttpResponseMessage usersResult = await userClient.GetAsync(@$"https://api.zoom.us/v2/users?page_size=300{nextPageParameter}");
            //HttpResponseMessage usersResult = await userClient.GetAsync(@$"https://api.zoom.us/v2/users?page_size=300/");
            string usersJson = await usersResult.Content.ReadAsStringAsync();
            Users? users = System.Text.Json.JsonSerializer.Deserialize<Users>(usersJson);

            return users;
        }
    }
}
