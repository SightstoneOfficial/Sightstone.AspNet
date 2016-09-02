using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.ChampionStatInfo")]
    public class ChampionStatInfo : IRiotRtmpObject
    {
        [SerializedName("totalGamesPlayed")]
        public int TotalGamesPlayed { get; set; }

        [SerializedName("accountId")]
        public double AccountId { get; set; }

        [SerializedName("stats")]
        public List<AggregatedStat> Stats { get; set; }

        [SerializedName("championId")]
        public double ChampionId { get; set; }
    }
}
