using AppFinanceiro.Components;
using Application.DependenciesApp;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços MudBlazor.
builder.Services.AddMudServices();

//Registrar Serviços
builder.Services.AddApplication(builder.Configuration);

// Adicione serviços ao contêiner.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure o pipeline de solicitação HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.Run();
