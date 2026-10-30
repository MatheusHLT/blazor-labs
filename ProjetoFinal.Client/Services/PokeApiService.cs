using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using ProjetoFinal.Client.Models.PokeApi;

namespace ProjetoFinal.Client.Services;

public class PokeApiService
{
    public string SearchName { get; set; } = string.Empty;

    public Pokemon? Pokemon { get; private set; }

    public async Task BuscarPokemon(HttpClient http)
    {
        if (string.IsNullOrWhiteSpace(SearchName))
        {
            return;
        }

        string nome = SearchName.ToLower().Trim();

        string url = $"https://pokeapi.co/api/v2/pokemon/{nome}";

        Pokemon = await http.GetFromJsonAsync<Pokemon>(url);
    }

    public void LimparPokemon()
    {
        Pokemon = null;
        SearchName = string.Empty;
    }
}