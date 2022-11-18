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
    }
}
