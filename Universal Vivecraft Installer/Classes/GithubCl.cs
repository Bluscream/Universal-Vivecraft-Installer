using Bluscream;
using Octokit;
using System;
using System.Collections.Generic;
using System.IO;

namespace UniversalVivecraftInstaller
{
    public static class GithubCl
    {
        static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static IReadOnlyList<Repository> GetAllRepositoriesForUser(GitHubClient ghClient, string login)
        {
            try
            {
                var result = ghClient.Repository.GetAllForUser(login).Result;
                new FileInfo($"github/{login}/repositories.json").WriteAllText(result.ToJson(true));
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"ERROR While retrieving Repositories for user {login}");
            }

            return new List<Repository>().AsReadOnly();
        }

        public static IReadOnlyList<Release> GetAllReleasesForRepository(GitHubClient ghClient, string owner, string name)
        {
            try
            {
                var result = ghClient.Repository.Release.GetAll(owner, name).Result;
                new FileInfo($"github/{owner}/{name}/releases.json").WriteAllText(result.ToJson(true));
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"ERROR While retrieving releases for repo {owner}/{name}");
            }

            return new List<Release>().AsReadOnly();
        }
    }
}