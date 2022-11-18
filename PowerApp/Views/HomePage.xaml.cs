using PowerApp.ViewModels;

namespace PowerApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel vm)
	{
		BindingContext = vm;
        InitializeComponent();
	}
}