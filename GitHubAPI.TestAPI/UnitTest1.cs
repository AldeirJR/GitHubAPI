using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace GitHubAPI.TestAPI
{
    [TestClass]
    public class UnitTest1
    {
        private HttpClient _httpClient;

        [TestInitialize]
        public void Initialize()
        {
            var appFactory = new WebApplicationFactory<Program>();
            _httpClient = appFactory.CreateClient();
        }

        [TestMethod]
        public async Task GetUsers_ReturnsStatusCode200()
        {
            var response = await _httpClient.GetAsync("/api/GitHubApi/users?since=1");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task GetUserDetails_ReturnsStatusCode200()
        {
            var response = await _httpClient.GetAsync("/api/GitHubApi/users?username=AldeirJR/details");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task GetUserRepositories_ReturnsStatusCode200()
        {
            var response = await _httpClient.GetAsync("/api/GitHubApi/users?username=AldeirJR/repos");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}