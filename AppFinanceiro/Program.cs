using AppFinanceiro.Components;
using Application.DependenciesApp;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Adicione servi�os MudBlazor.
builder.Services.AddMudServices();

//Registrar Servi�os
builder.Services.AddApplication(builder.Configuration);

// Adicione servi�os ao cont�iner.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure o pipeline de solicita��o HTTP.
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
