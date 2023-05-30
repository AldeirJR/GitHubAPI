namespace GitHubAPI.Model
{
    public class GitHubUserDetails
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public int Public_repos { get; set; }
        public int Public_gists { get; set; }
        public  int Followers { get; set; }
        public int Following { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime updated_at { get; set; }

       
    }

}
