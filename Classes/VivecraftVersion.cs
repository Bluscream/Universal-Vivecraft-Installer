﻿using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
using Bluscream;

namespace UniversalVivecraftInstaller
{
    static class VersionRegex
    {
        internal static Regex regex = new Regex(@"\d+\.\d+\.*\w*");
    }
    class VivecraftVersion
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public string Name { get; set; }
        [DisplayName("MC Version")]
        public string MCVersion { get; set; }
        [Browsable(false)]
        public Version _MCVersion { get; set; }
        public int Versions { get { return Releases.Count; } }
        [Browsable(false)]
        public Repository Repository { get; set; }
        [Browsable(false)]
        public IReadOnlyList<Release> Releases { get; set; }
        [Browsable(false)]
        public ReleaseAsset NonVRInstaller { get; set; }
        [Browsable(false)]
        public ReleaseAsset VRInstaller { get; set; }
        [Browsable(false)]
        public VivecraftVersion(Repository repository)
        {
            Repository = repository;
            Name = repository.Name;
            MCVersion = VersionRegex.regex.Match(repository.Description).Value;
            System.Version.TryParse(MCVersion.Remove(".X"), out var _ver); _MCVersion = _ver;
            Releases = GithubCl.GetAllReleasesForRepository(MainForm.ghClient, repository.Owner.Login, repository.Name);
            if (Releases.Count > 0)
            {
                foreach (var asset in Releases[0].Assets)
                {
                    if (asset.Name.Contains("non", StringComparison.OrdinalIgnoreCase)) NonVRInstaller = asset;
                    else VRInstaller = asset;
                }
                
            }
            Logger.Debug("New VivecraftVersion: %s", this.ToJson());
        }
    }
}
