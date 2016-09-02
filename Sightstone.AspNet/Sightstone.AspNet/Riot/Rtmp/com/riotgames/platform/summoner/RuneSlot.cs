using System;
using RtmpSharp.IO;
using Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.catalog.runes;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.RuneSlot")]
    public class RuneSlot : IRiotRtmpObject
    {
        [SerializedName("id")]
        public int Id { get; set; }

        [SerializedName("minLevel")]
        public int MinLevel { get; set; }

        [SerializedName("runeType")]
        public RuneType RuneType { get; set; }
    }
}
