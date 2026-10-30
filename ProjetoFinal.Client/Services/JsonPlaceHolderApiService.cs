using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http.Json;
using ProjetoFinal.Client.Models.JsonPlaceHolderApi;

namespace ProjetoFinal.Client.Services;

public class JsonPlaceHolderApiService
{
    public string Id { get; set; } = string.Empty;

    public Root? Usuario { get; private set; }

    public async Task ConsultarUsuario(HttpClient http)
    {
        if (!int.TryParse(Id, out int numericId) || numericId <= 0)
        {
            throw new ArgumentException("Por favor, insira um ID numérico válido.");
        }

        string url = $"https://jsonplaceholder.typicode.com/users/{numericId}";

        Usuario = await http.GetFromJsonAsync<Root>(url);
    }

    public void LimparUsuario()
    {
        Usuario = null;
    }
}