using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.game.message
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.message.GameNotification")]
    public class GameNotification : IRiotRtmpObject
    {
        [SerializedName("messageCode")]
        public String MessageCode { get; set; }

        [SerializedName("type")]
        public String Type { get; set; }

        [SerializedName("messageArgument")]
        public object MessageArgument { get; set; }
    }
}
