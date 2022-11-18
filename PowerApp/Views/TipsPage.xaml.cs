using PowerApp.ViewModels;

namespace PowerApp.Views;

public partial class TipsPage : ContentPage
{
	public TipsPage(TipsViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
	}
}