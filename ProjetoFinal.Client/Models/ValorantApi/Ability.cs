using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAgentValorantAPI.Models
{
    public class Ability
    {
        public string slot { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string displayIcon { get; set; }
    }
}