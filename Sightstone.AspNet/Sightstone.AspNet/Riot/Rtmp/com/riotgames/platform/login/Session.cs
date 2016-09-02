using System;
using RtmpSharp.IO;
using Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.account;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.login
{
    [Serializable]
    [SerializedName("com.riotgames.platform.login.Session")]
    public class Session : IRiotRtmpObject
    {
        [SerializedName("token")]
        public String Token { get; set; }

        [SerializedName("password")]
        public String Password { get; set; }

        [SerializedName("accountSummary")]
        public AccountSummary AccountSummary { get; set; }
    }
}
