using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Json;
using ProjetoFinal.Client.Models.BrasilApiCep;

namespace ProjetoFinal.Client.Services;

public class BrasilApiCepService
{
    public string CepInput { get; set; } = string.Empty;

    public Cep? ResultadoCep { get; private set; }

    public async Task BuscarCep(HttpClient http)
    {
        string cepLimpo = CepInput.Replace("-", "").Trim();

        if (string.IsNullOrWhiteSpace(cepLimpo) || cepLimpo.Length != 8)
        {
            throw new ArgumentException("Por favor, informe um CEP válido com 8 dígitos.");
        }

        string url = $"https://brasilapi.com.br/api/cep/v2/{cepLimpo}";

        ResultadoCep = await http.GetFromJsonAsync<Cep>(url);
    }

    public void LimparResultado()
    {
        ResultadoCep = null;
    }
}