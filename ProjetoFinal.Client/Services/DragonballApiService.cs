using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using ProjetoFinal.Client.Models.DragonballApi;

namespace ProjetoFinal.Client.Services;

public class DragonballApiService
{
    public string Id { get; set; } = string.Empty;

    public Root? Personagem { get; private set; }

    public async Task ConsultarPersonagem(HttpClient http)
    {
        if (string.IsNullOrWhiteSpace(Id))
        {
            throw new ArgumentException("Por favor, insira um ID válido.");
        }

        string url = $"https://dragonball-api.com/api/characters/{Id.Trim()}";

        Personagem = await http.GetFromJsonAsync<Root>(url);
    }

    public void LimparPersonagem()
    {
        Personagem = null;
    }
}