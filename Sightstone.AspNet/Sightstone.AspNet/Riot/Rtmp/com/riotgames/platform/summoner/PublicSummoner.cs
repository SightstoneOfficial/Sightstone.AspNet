using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.PublicSummoner")]
    public class PublicSummoner : IRiotRtmpObject
    {
        [SerializedName("publicName")]
        public String InternalName { get; set; }

        [SerializedName("acctId")]
        public double AcctId { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("profileIconId")]
        public int ProfileIconId { get; set; }

        [SerializedName("revisionDate")]
        public DateTime RevisionDate { get; set; }

        [SerializedName("revisionId")]
        public double RevisionId { get; set; }

        [SerializedName("summonerLevel")]
        public double SummonerLevel { get; set; }

        [SerializedName("summonerId")]
        public double SummonerId { get; set; }
    }
}
