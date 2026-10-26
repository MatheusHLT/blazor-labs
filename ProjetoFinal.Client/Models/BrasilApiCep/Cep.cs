using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Client.Models.BrasilApiCep
{
    public class Cep
    {
        public string cep { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        public string timezoneName { get; set; }
        public Location location { get; set; }
        public Ibge ibge { get; set; }
    }
}