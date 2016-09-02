using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.messaging
{
    [Serializable]
    [SerializedName("com.riotgames.platform.messaging.ClientLoginKickNotification")]
    public class ClientLoginKickNotification : IRiotRtmpObject
    {
        [SerializedName("sessionToken")]		
        public string sessionToken { get; set; }		
    }
}
