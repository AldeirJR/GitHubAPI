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
        public async Task<string> GetUsers(int since)
        {
            var response = await _httpClient.GetAsync($"users?since={since}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUserDetails(string username)
        {
            var response = await _httpClient.GetAsync($"users/{username}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUserRepositories(string username)
        {
            var response = await _httpClient.GetAsync($"users/{username}/repos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }


    }
}
