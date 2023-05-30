using GitHubAPI.Model;
using Newtonsoft.Json;

namespace GitHubAPI.Service
{
    public class GitHubApiService
    {

        private readonly HttpClient _httpClient;

        public GitHubApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.github.com/");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Your-App-Name");
            // Add any required authentication headers here
        }
        public async Task<List<GitHubUser>> GetUsers(int since)
        {
            var response = await _httpClient.GetAsync($"users?since={since}");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<GitHubUser>>(responseBody);
            return users;
        }

        public async Task<GitHubUserDetails> GetUserDetails(string username)
        {
            var response = await _httpClient.GetAsync($"users/{username}");
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            var userDetails = JsonConvert.DeserializeObject<GitHubUserDetails>(responseContent);
            return userDetails;
        }

        public async Task<List<GitHubRepository>> GetUserRepositories(string username)
        {
            var response = await _httpClient.GetAsync($"users/{username}/repos");
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            var repositories = JsonConvert.DeserializeObject<List<GitHubRepository>>(responseContent);
            return repositories;
        }


    }
}
