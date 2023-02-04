using NavigationServiceMAUI.ViewModels;

namespace NavigationServiceMAUI.Views;

public partial class StudentListPage : ContentPage
{
	public StudentListPage(StudentListPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}