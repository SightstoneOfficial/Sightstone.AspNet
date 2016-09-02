using System;
using RtmpSharp.IO;
using Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.summoner;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.matchmaking
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.QueueDodger")]
    public class QueueDodger : IRiotRtmpObject
    {
        [SerializedName("reasonFailed")]
        public string ReasonFailed { get; set; }

        [SerializedName("summoner")]
        public Summoner Summoner { get; set; }

        [SerializedName("dodgePenaltyRemainingTime")]
        public int PenaltyRemainingTime { get; set; }
    }
}
