using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.summoner.runes
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.runes.SummonerRuneInventory")]
    public class SummonerRuneInventory : IRiotRtmpObject
    {
        [SerializedName("summonerRunesJson")]
        public object SummonerRunesJson { get; set; }

        [SerializedName("dateString")]
        public String DateString { get; set; }

        [SerializedName("summonerRunes")]
        public List<SummonerRune> SummonerRunes { get; set; }

        [SerializedName("summonerId")]
        public double SummonerId { get; set; }
    }
}
