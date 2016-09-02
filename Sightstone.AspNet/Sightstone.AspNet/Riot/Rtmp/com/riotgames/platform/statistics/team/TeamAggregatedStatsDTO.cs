using System;
using System.Collections.Generic;
using RtmpSharp.IO;
using Sightstone.AspNet.Riot.Rtmp.com.riotgames.team;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.statistics.team
{
    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.team.TeamAggregatedStatsDTO")]
    public class TeamAggregatedStatsDTO : IRiotRtmpObject
    {
        [SerializedName("queueType")]
        public String QueueType { get; set; }

        [SerializedName("serializedToJson")]
        public String SerializedToJson { get; set; }

        [SerializedName("playerAggregatedStatsList")]
        public List<TeamPlayerAggregatedStatsDTO> PlayerAggregatedStatsList { get; set; }

        [SerializedName("teamId")]
        public TeamId TeamId { get; set; }
    }
}
