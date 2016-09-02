using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.TimeTrackedStat")]
    public class TimeTrackedStat : IRiotRtmpObject
    {
        [SerializedName("timestamp")]
        public DateTime Timestamp { get; set; }

        [SerializedName("type")]
        public String Type { get; set; }
    }
}
