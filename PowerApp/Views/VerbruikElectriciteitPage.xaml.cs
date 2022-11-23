using PowerApp.ViewModels;

namespace PowerApp.Views;

public partial class VerbruikElectriciteitPage : ContentPage
{
	public VerbruikElectriciteitPage(VerbruikElectriciteitViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
	}
}