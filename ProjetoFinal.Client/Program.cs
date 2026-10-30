using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProjetoFinal.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddScoped<BrasilApiCepService>();
builder.Services.AddScoped<DragonballApiService>();
builder.Services.AddScoped<JsonPlaceHolderApiService>();
builder.Services.AddScoped<PokeApiService>();
builder.Services.AddScoped<ValorantApiService>();
builder.Services.AddScoped<MediaService>();
builder.Services.AddScoped<SorteioService>();
builder.Services.AddScoped<TarefaService>();

await builder.Build().RunAsync();
