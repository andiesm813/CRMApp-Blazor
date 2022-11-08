using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CRM_Final;
using CRM_Final.ECommerce;
using CRM_Final.Northwind;
using CRM_Final.CRMApp;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ECommerceService>();
builder.Services.AddScoped<NorthwindService>();
builder.Services.AddScoped<CRMAppService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule),
        typeof(IgbChipModule),
        typeof(IgbButtonModule),
        typeof(IgbInputModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbTabsModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbCheckboxModule)
    );
}