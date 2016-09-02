using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.AggregatedStatsKey")]
    public class AggregatedStatsKey : IRiotRtmpObject
    {
        [SerializedName("gameMode")]
        public String GameMode { get; set; }

        [SerializedName("userId")]
        public double UserId { get; set; }

        [SerializedName("gameModeString")]
        public String GameModeString { get; set; }
    }
}
