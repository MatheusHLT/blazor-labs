using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using SearchAgentValorantAPI.Models;

namespace ProjetoFinal.Client.Services;

public class ValorantApiService
{
    public string AgentUuid { get; set; } = "e370fa57-4757-3604-3648-499e1f642d3f";

    public Data? AgentData { get; private set; }

    public async Task BuscarAgente(HttpClient http)
    {
        if (string.IsNullOrWhiteSpace(AgentUuid))
        {
            throw new ArgumentException("Por favor, digite um UUID válido.");
        }

        string url = $"https://valorant-api.com/v1/agents/{AgentUuid.Trim()}";

        var response = await http.GetFromJsonAsync<Root>(url);

        if (response != null && response.status == 200 && response.data != null)
        {
            AgentData = response.data;
        }
        else
        {
            throw new Exception("Agente não encontrado ou resposta inválida da API.");
        }
    }

    public void LimparAgente()
    {
        AgentData = null;
    }
}