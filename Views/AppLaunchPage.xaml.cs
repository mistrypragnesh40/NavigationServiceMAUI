using NavigationServiceMAUI.ViewModels;

namespace NavigationServiceMAUI.Views;

public partial class AppLaunchPage : ContentPage
{
	public AppLaunchPage(AppLaunchPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}