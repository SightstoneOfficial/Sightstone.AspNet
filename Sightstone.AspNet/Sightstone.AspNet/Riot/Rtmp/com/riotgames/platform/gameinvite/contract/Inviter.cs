using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.gameinvite.contract
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.Inviter")]
    public class Inviter : IRiotRtmpObject
    {
        [SerializedName("previousSeasonHighestTier")]
        public string PreviousSeasonHighestTier { get; set; }

        [SerializedName("summonerName")]
        public string SummonerName { get; set; }

        [SerializedName("summonerId")]
        public int SummonerId { get; set; }
    }
}
