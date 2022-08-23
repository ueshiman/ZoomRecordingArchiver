using System.Text;
using Ueshiman.ZoomRecordingArchiver.ApiModel;

namespace Ueshiman.ZoomRecordingArchiver.ApiCall
{
    public class ZoomAuthorize
    {
        public async Task<ZoomAuthorization?> GetAuthorizationAsync(string accountId, string clientId, string clientSecret)
        {
            string authorization = $"{clientId}:{clientSecret}";
            string base64String = Base64Encode(authorization);

            var client = new HttpClient();
            //client.DefaultRequestHeaders.Remove("Host");
            client.DefaultRequestHeaders.Add("Host", "zoom.us");
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {base64String}");

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
            };

            string jsonString = System.Text.Json.JsonSerializer.Serialize(param);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, @"application/json");
            //POST
            HttpResponseMessage result = await client.PostAsync(@$"https://zoom.us/oauth/token?grant_type=account_credentials&account_id={accountId}", content);

            string json = await result.Content.ReadAsStringAsync();


            ZoomAuthorization? zoomAuthorization = System.Text.Json.JsonSerializer.Deserialize<ZoomAuthorization>(json);
            return zoomAuthorization;
        }

        public async Task<ZoomAuthorization?> RefreshTokenAsync(string refreshToken, string clientId, string clientSecret)
        {
            string authorization = $"{clientId}:{clientSecret}";
            string base64String = Base64Encode(authorization);

            var client = new HttpClient();
            //client.DefaultRequestHeaders.Remove("Host");
            client.DefaultRequestHeaders.Add("Host", "zoom.us");
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {base64String}");
            //client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
            };

            string jsonString = System.Text.Json.JsonSerializer.Serialize(param);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, @"application/json");
            //POST
            HttpResponseMessage result = await client.PostAsync(@$"https://zoom.us/oauth/token?grant_type=refresh_token&refresh_token={refreshToken}", content);

            string json = await result.Content.ReadAsStringAsync();


            ZoomAuthorization? zoomAuthorization = System.Text.Json.JsonSerializer.Deserialize<ZoomAuthorization>(json);
            return zoomAuthorization;
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
