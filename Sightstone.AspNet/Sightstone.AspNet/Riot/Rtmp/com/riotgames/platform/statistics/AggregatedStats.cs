using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.AggregatedStats")]
    public class AggregatedStats : IRiotRtmpObject
    {
        [SerializedName("lifetimeStatistics")]
        public List<AggregatedStat> LifetimeStatistics { get; set; }

        [SerializedName("modifyDate")]
        public object ModifyDate { get; set; }

        [SerializedName("key")]
        public AggregatedStatsKey Key { get; set; }

        [SerializedName("aggregatedStatsJson")]
        public String AggregatedStatsJson { get; set; }
    }
}
