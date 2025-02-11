﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChatTailorAI.Shared.Models.Audio
{
    public class SpotifyPlaylist
    {
        [JsonProperty("items")]
        public List<SpotifyPlaylistItem> Items { get; set; }
    }

    public class SpotifyPlaylistItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
