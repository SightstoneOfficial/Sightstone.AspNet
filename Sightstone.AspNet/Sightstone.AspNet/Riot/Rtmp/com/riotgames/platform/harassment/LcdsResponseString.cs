using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.harassment
{
    [Serializable]
    [SerializedName("com.riotgames.platform.harassment.LcdsResponseString")]
    public class LcdsResponseString : IRiotRtmpObject
    {
        [SerializedName("value")]
        public String Value { get; set; }
    }
}
