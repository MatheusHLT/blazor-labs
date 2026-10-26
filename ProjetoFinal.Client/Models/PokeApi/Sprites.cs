using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ProjetoFinal.Client.Models.PokeApi
{
    public class Sprites
    {
        [JsonPropertyName("other")]
        public Other Other { get; set; }
    }
}