using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.reroll.pojo
{
    [Serializable]
    [SerializedName("com.riotgames.platform.reroll.pojo.RollResult")]
    public class RollResult : IRiotRtmpObject
    {
        [SerializedName("championId")]
        public int ChampionId { get; set; }

        [SerializedName("pointSummary")]
        public PointSummary PointSummary { get; set; }
    }
}
