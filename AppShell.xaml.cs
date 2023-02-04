using NavigationServiceMAUI.Views;

namespace NavigationServiceMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(StudentListPage), typeof(StudentListPage));
        Routing.RegisterRoute(nameof(StudentDetailPage), typeof(StudentDetailPage));

    }
}
