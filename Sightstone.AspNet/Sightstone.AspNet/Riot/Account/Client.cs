using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RtmpSharp.Net;

namespace Sightstone.AspNet.Riot.Account
{
    public class Client
    {
        #region RTMP
        /// <summary>
        /// Main connection to the League of Legends server
        /// </summary>
        public RtmpClient RiotConnection;

        /// <summary>
        /// Gets if user is connected to riot's server
        /// </summary>
        public bool IsConnectedToRtmp;
        #endregion RTMP
    }
}