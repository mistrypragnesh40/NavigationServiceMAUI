using CommunityToolkit.Mvvm.Input;
using NavigationServiceMAUI.Services;
using NavigationServiceMAUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServiceMAUI.ViewModels
{
    public partial class AppLaunchPageViewModel : BaseViewModel
    {

        public AppLaunchPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }


        [RelayCommand]
        public void NavigateToStudentList()
        {
            NavigationService.NavigateToAsync(nameof(StudentListPage));
        }
    }
}
