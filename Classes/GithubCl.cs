using Octokit;
using System.Collections.Generic;

namespace UniversalVivecraftInstaller
{

    public static class GithubCl
    {
        public static IReadOnlyList<Repository> GetAllRepositoriesForUser(GitHubClient ghClient, string login)
        {
            return ghClient.Repository.GetAllForUser(login).Result;
        }
        public static IReadOnlyList<Release> GetAllReleasesForRepository(GitHubClient ghClient, string owner, string name)
        {
            return ghClient.Repository.Release.GetAll(owner, name).Result;
        }
    }
}
