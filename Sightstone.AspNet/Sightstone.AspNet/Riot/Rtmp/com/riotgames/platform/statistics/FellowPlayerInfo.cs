using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.FellowPlayerInfo")]
    public class FellowPlayerInfo : IRiotRtmpObject
    {
        [SerializedName("championId")]
        public double ChampionId { get; set; }

        [SerializedName("teamId")]
        public int TeamId { get; set; }

        [SerializedName("summonerId")]
        public double SummonerId { get; set; }
    }
}
