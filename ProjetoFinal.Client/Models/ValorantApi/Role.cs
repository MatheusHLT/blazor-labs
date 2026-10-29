using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAgentValorantAPI.Models
{
    public class Role
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string displayIcon { get; set; }
        public string assetPath { get; set; }
    }
}