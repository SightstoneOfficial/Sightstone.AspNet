using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PlayerChampionSelectionDTO")]
    public class PlayerChampionSelectionDTO : IRiotRtmpObject
    {
        [SerializedName("summonerInternalName")]
        public String SummonerInternalName { get; set; }

        [SerializedName("spell2Id")]
        public double Spell2Id { get; set; }

        [SerializedName("selectedSkinIndex")]
        public int SelectedSkinIndex { get; set; }

        [SerializedName("championId")]
        public int ChampionId { get; set; }

        [SerializedName("spell1Id")]
        public double Spell1Id { get; set; }
    }
}
