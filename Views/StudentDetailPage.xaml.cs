using NavigationServiceMAUI.ViewModels;

namespace NavigationServiceMAUI.Views;

public partial class StudentDetailPage : ContentPage
{
	public StudentDetailPage(StudentDetailPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}