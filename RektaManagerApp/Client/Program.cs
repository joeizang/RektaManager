using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using RektaManagerApp.Client.Utils;
using Syncfusion.Blazor;
using Blazored.Toast;
using Blazored.Modal;

namespace RektaManagerApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDUzMTQ4QDMxMzkyZTMxMmUzMGhReGtSZTAzWURNVGRTVVBkbmRoNFlEQS85R3Y2Z21FbFB0NmZWYzVGNHM9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("RektaManagerApp.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("RektaManagerApp.ServerAPI"));

            builder.Services.AddApiAuthorization();

            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredModal();

            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}
