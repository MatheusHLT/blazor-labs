using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Client.Models.DragonballApi
{
    public class Root
    {
    public int? id { get; set; }
    public string? name { get; set; }
    public OriginPlanet? originPlanet { get; set; }
    public List<Transformation>? transformations { get; set; }
    }

}