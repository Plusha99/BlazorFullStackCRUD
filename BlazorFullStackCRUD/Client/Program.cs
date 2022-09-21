global using BlazorFullStackCRUD.Client.Services.SuperHeroService;
global using BlazorFullStackCRUD.Shared;
using BlazorFullStackCrud.Client.Services.SuperHeroService;
using BlazorFullStackCRUD.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ISuperHeroService, SuperHeroService> ();

await builder.Build().RunAsync();
