﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.SummonerSpell
{
    /// <summary>
    /// This object contains summoner spell list data.
    /// </summary>
    public class SummonerSpellListDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, SummonerSpellDto> Data { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
