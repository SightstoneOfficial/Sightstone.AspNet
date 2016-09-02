﻿using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.matchmaking
{
    [Serializable]
    [SerializedName("com.riotgames.platform.matchmaking.BustedLeaver")]
    public class BustedLeaver : QueueDodger, IRiotRtmpObject
    {
        //[SerializedName("reasonFailed")]		
        //public string ReasonFailed { get; set; }

        [SerializedName("accessToken")]		
        public string AccessToken { get; set; }

        [SerializedName("leaverPenaltyMillisRemaining")]		
        public double LeaverPenaltyMilisRemaining { get; set; }

        //[SerializedName("summoner")]		
        //public Summoner Summoner { get; set; }
    }
}
