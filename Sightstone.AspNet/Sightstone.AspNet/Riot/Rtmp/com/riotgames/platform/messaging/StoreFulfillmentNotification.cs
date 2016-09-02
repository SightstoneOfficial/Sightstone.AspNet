using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.messaging
{
    [Serializable]
    [SerializedName("com.riotgames.platform.messaging.StoreFulfillmentNotification")]
    public class StoreFulfillmentNotification : IRiotRtmpObject
    {
        [SerializedName("rp")]
        public double Rp { get; set; }

        [SerializedName("ip")]
        public double Ip { get; set; }

        [SerializedName("inventoryType")]
        public String InventoryType { get; set; }

        [SerializedName("data")]
        public object Data { get; set; }
    }
}
