using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.matchmaking
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.MatchingThrottleConfig")]
    public class MatchingThrottleConfig : IRiotRtmpObject
    {
        [SerializedName("limit")]
        public double Limit { get; set; }

        [SerializedName("matchingThrottleProperties")]
        public List<object> MatchingThrottleProperties { get; set; }

        [SerializedName("cacheName")]
        public String CacheName { get; set; }
    }
}
