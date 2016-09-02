using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.reroll.pojo
{
    [Serializable]
    [SerializedName("com.riotgames.platform.reroll.pojo.SimpleDialogMessage")]
    public class SimpleDialogMessage : IRiotRtmpObject
    {
        [SerializedName("titleCode")]
        public String TitleCode { get; set; }

        [SerializedName("accountId")]
        public double AccountId { get; set; }

        [SerializedName("params")]
        public object Params { get; set; }

        [SerializedName("type")]
        public String Type { get; set; }
    }
}
