using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.catalog.runes
{
    [Serializable]
    [SerializedName("com.riotgames.platform.catalog.runes.RuneType")]
    public class RuneType : IRiotRtmpObject
    {
        [SerializedName("runeTypeId")]
        public int RuneTypeId { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }
    }
}
