using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio.Net6;
using MyPortfolio.Net6.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.DetectIncorrectUsageOfTransients();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<TransientDisposableService>();

var host = builder.Build();
host.EnableTransientDisposableDetection();
await host.RunAsync();
