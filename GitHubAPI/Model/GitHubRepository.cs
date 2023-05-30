namespace GitHubAPI.Model
{
    public class GitHubRepository
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Pushed_at { get; set; }

    }
}
