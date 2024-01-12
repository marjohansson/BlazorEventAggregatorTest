using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CM.Micro.EventAggregator.Lib;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddEventAggregator(x=> x.AutoRefresh = true);

await builder.Build().RunAsync();
