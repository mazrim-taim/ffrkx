﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ffrk_winproxy.GameData
{
    class DataDungeon
    {
        [JsonProperty("challenge_level")]
        public uint Difficulty;

        [JsonProperty("Id")]
        public uint Id;

        [JsonProperty("world_id")]
        public uint WorldId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("series_id")]
        public uint SeriesId;

        [JsonProperty("type")]
        public uint Type;

        [JsonProperty("rank")]
        public uint Rank;

        [JsonExtensionData]
        public Dictionary<string, JToken> UnknownValues;
    }
}