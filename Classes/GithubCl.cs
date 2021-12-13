using Octokit;
using System.Collections.Generic;
using System.Linq;

namespace UniversalVivecraftInstaller
{

    public static class GithubCl
    {
        public static List<Repository> GetAllRepositoriesForUser(GitHubClient ghClient, string login)
        {
            var result = new List<Repository>();
            result = ghClient.Repository.GetAllForUser(login).Result.ToList();
            return result;
        }
        public static List<Release> GetAllReleasesForRepository(GitHubClient ghClient, string owner, string name)
        {
            var result = new List<Release>();
            result = ghClient.Repository.Release.GetAll(owner, name).Result.ToList();
            return result;
        }
    }
}
