using Microsoft.Extensions.DependencyInjection;
using PowerApp.Views;

namespace PowerApp;

public partial class AppShell : Shell
{
    private IServiceProvider serviceProvider;

    public AppShell(IServiceProvider services)
    {
        this.serviceProvider = services;
        InitializeComponent();

        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(TipsPage), typeof(TipsPage));
        Routing.RegisterRoute(nameof(VerbruikElectriciteitPage), typeof(HomePage));
        Routing.RegisterRoute(nameof(VerbruikWaterPage), typeof(VerbruikWaterPage));
        Routing.RegisterRoute(nameof(VerbruikGasPage), typeof(VerbruikGasPage));

    }
}
