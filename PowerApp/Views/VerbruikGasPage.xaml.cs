using PowerApp.ViewModels;

namespace PowerApp.Views;

public partial class VerbruikGasPage : ContentPage
{
	public VerbruikGasPage(VerbruikGasViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
	}
}