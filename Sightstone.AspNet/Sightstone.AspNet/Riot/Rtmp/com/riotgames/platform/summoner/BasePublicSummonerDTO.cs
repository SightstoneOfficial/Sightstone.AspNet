using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.BasePublicSummonerDTO")]
    public class BasePublicSummonerDTO : IRiotRtmpObject
    {
        [SerializedName("seasonTwoTier")]
        public String SeasonTwoTier { get; set; }

        [SerializedName("publicName")]
        public String InternalName { get; set; }

        [SerializedName("seasonOneTier")]
        public String SeasonOneTier { get; set; }

        [SerializedName("acctId")]
        public double AcctId { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("sumId")]
        public double SumId { get; set; }

        [SerializedName("profileIconId")]
        public int ProfileIconId { get; set; }
    }
}
