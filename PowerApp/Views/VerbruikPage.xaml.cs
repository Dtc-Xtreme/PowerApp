using PowerApp.ViewModels;

namespace PowerApp.Views;

public partial class VerbruikPage : ContentPage
{
	public VerbruikPage(VerbruikViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
	}
}