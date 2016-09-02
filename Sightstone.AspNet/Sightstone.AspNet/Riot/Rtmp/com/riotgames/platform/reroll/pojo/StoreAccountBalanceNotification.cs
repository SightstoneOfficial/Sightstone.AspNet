﻿using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.reroll.pojo
{
    [Serializable]
    [SerializedName("com.riotgames.platform.reroll.pojo.StoreAccountBalanceNotification")]
    public class StoreAccountBalanceNotification : IRiotRtmpObject
    {
        [SerializedName("rp")]
        public double Rp { get; set; }

        [SerializedName("ip")]
        public double Ip { get; set; }
    }
}
