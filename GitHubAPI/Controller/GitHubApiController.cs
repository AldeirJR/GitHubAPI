using GitHubAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace GitHubAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GitHubApiController : ControllerBase
    {
        private readonly GitHubApiService _gitHubService;

        public GitHubApiController(GitHubApiService gitHubService)
        {
            _gitHubService = gitHubService;


        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers([FromQuery] int since)
        {
            var users = await _gitHubService.GetUsers(since);
            return Ok(users);
        }

        [HttpGet("users/{username}/details")]
        public async Task<IActionResult> GetUserDetails(string username)
        {
            var userDetails = await _gitHubService.GetUserDetails(username);
            return Ok(userDetails);
        }

        [HttpGet("users/{username}/repos")]
        public async Task<IActionResult> GetUserRepositories(string username)
        {
            var userRepositories = await _gitHubService.GetUserRepositories(username);
            return Ok(userRepositories);
        }


    }
}
