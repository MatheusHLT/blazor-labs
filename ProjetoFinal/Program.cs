using ProjetoFinal.Client.Pages;
using ProjetoFinal.Components;
using ProjetoFinal.Client.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(sp => new HttpClient());

builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<BrasilApiCepService>();
builder.Services.AddScoped<DragonballApiService>();
builder.Services.AddScoped<JsonPlaceHolderApiService>();
builder.Services.AddScoped<PokeApiService>();
builder.Services.AddScoped<ValorantApiService>();
builder.Services.AddScoped<MediaService>();
builder.Services.AddScoped<SorteioService>();
builder.Services.AddScoped<TarefaService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(ProjetoFinal.Client._Imports).Assembly);

app.Run();
