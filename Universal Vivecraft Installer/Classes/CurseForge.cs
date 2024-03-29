﻿using Bluscream;
using System;
using System.IO;
using System.Linq;

// import web api
using System.Net;

namespace UniversalVivecraftInstaller
{
    internal static class CurseForgeClient
    {
        public static string GetModInfo(int modid)
        {
            // make request to https://api.cfwidget.com/{modid} and get json
            var request = (HttpWebRequest)WebRequest.Create($"https://minecraft.curseforge.com/api/game/versions?projectId={modid}");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "UniversalVivecraftInstaller";
            request.Accept = "application/json";
            request.Headers.Add("X-Api-Token", "7e46006a-561d-46de-9132-8d1fece3a7d2");
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            var responseText = reader.ReadToEnd();
            new FileInfo($"curseforge/mods/{modid}.json").WriteAllText(responseText);
            return responseText;
        }

        public static CurseForge.Models.ModInfo GetModInfoFromWidget(int modid)
        {
            // make request to https://api.cfwidget.com/{modid} and get json
            var request = (HttpWebRequest)WebRequest.Create($"https://api.cfwidget.com/{modid}");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "UniversalVivecraftInstaller";
            request.Accept = "application/json";
            request.Headers.Add("X-Api-Token", "7e46006a-561d-46de-9132-8d1fece3a7d2");
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            var responseText = reader.ReadToEnd();
            new FileInfo($"curseforge/widgets/{modid}.json").WriteAllText(responseText);
            return CurseForge.Models.ModInfo.FromJson(responseText);
        }

        public static Tuple<Uri, string> GetDownload(this CurseForge.Models.ModInfo modInfo, Version version)
        {
            // 3044155

            foreach (var _version in modInfo.Versions)
            {
                var _parsed = new Version(_version.Key);

                if (_parsed.Major == version.Major && _parsed.Minor == version.Minor)
                {
                    return new Tuple<Uri, string>(new Uri($"https://www.curseforge.com/minecraft/mc-mods/vivecraft-forge-extensions/download/{_version.Value.Last().Id}/file"), _version.Value.Last().Name);
                }
            }

            return null;
        }
    }
}

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CurseForge.Models;
//
//    var modInfo = ModInfo.FromJson(jsonString);

namespace CurseForge.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class ModInfo
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("game", NullValueHandling = NullValueHandling.Ignore)]
        public string Game { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public Urls Urls { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("downloads", NullValueHandling = NullValueHandling.Ignore)]
        public Downloads Downloads { get; set; }

        [JsonProperty("license", NullValueHandling = NullValueHandling.Ignore)]
        public string License { get; set; }

        [JsonProperty("donate", NullValueHandling = NullValueHandling.Ignore)]
        public string Donate { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<Member> Members { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Links { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<Download> Files { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<Download>> Versions { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("last_fetch", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastFetch { get; set; }

        [JsonProperty("download", NullValueHandling = NullValueHandling.Ignore)]
        public Download Download { get; set; }
    }

    public partial class Download
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("filesize", NullValueHandling = NullValueHandling.Ignore)]
        public long? Filesize { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Versions { get; set; }

        [JsonProperty("downloads", NullValueHandling = NullValueHandling.Ignore)]
        public long? Downloads { get; set; }

        [JsonProperty("uploaded_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UploadedAt { get; set; }
    }

    public partial class Downloads
    {
        [JsonProperty("monthly", NullValueHandling = NullValueHandling.Ignore)]
        public long? Monthly { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }
    }

    public partial class Urls
    {
        [JsonProperty("curseforge", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Curseforge { get; set; }

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Project { get; set; }
    }

    public enum TypeEnum { Release };

    public partial class ModInfo
    {
        public static ModInfo FromJson(string json) => JsonConvert.DeserializeObject<ModInfo>(json, CurseForge.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ModInfo self) => JsonConvert.SerializeObject(self, CurseForge.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "release") return TypeEnum.Release;
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TypeEnum)untypedValue;

            if (value == TypeEnum.Release)
            {
                serializer.Serialize(writer, "release");
                return;
            }

            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}