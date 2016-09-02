using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.trade.api.contract
{
    [Serializable]
    [SerializedName("com.riotgames.platform.trade.api.contract.PotentialTradersDTO")]
    public class PotentialTradersDTO : IRiotRtmpObject
    {
        [SerializedName("potentialTraders")]
        public List<String> PotentialTraders { get; set; }
    }
}
