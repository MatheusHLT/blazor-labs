using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAgentValorantAPI.Models
{
    public class Data
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string developerName { get; set; }
        public DateTime releaseDate { get; set; }
        public object characterTags { get; set; }
        public string displayIcon { get; set; }
        public string displayIconSmall { get; set; }
        public string bustPortrait { get; set; }
        public string fullPortrait { get; set; }
        public string fullPortraitV2 { get; set; }
        public string killfeedPortrait { get; set; }
        public string minimapPortrait { get; set; }
        public object homeScreenPromoTileImage { get; set; }
        public string background { get; set; }
        public List<string> backgroundGradientColors { get; set; }
        public string assetPath { get; set; }
        public bool isFullPortraitRightFacing { get; set; }
        public bool isPlayableCharacter { get; set; }
        public bool isAvailableForTest { get; set; }
        public bool isBaseContent { get; set; }
        public Role role { get; set; }
        public object recruitmentData { get; set; }
        public List<Ability> abilities { get; set; }
        public object voiceLine { get; set; }
    }
}