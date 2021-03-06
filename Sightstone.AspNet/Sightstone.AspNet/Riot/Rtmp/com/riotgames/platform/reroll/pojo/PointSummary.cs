﻿using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.reroll.pojo
{
    [Serializable]
    [SerializedName("com.riotgames.platform.reroll.pojo.PointSummary")]
    public class PointSummary : IRiotRtmpObject
    {
        [SerializedName("pointsToNextRoll")]
        public double PointsToNextRoll { get; set; }

        [SerializedName("maxRolls")]
        public int MaxRolls { get; set; }

        [SerializedName("numberOfRolls")]
        public int NumberOfRolls { get; set; }

        [SerializedName("pointsCostToRoll")]
        public double PointsCostToRoll { get; set; }

        [SerializedName("currentPoints")]
        public double CurrentPoints { get; set; }
    }
}
