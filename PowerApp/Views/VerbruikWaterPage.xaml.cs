using PowerApp.ViewModels;

namespace PowerApp.Views;

public partial class VerbruikWaterPage : ContentPage
{
	public VerbruikWaterPage(VerbruikWaterViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
	}
}