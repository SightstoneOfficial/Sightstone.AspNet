using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.RawStat")]
    public class RawStat : IRiotRtmpObject
    {
        [SerializedName("statType")]
        public String StatType { get; set; }

        [SerializedName("value")]
        public double Value { get; set; }
    }
}
