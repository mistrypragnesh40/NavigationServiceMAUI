using CommunityToolkit.Mvvm.ComponentModel;
using NavigationServiceMAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServiceMAUI.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService NavigationService;
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public BaseViewModel()
        {

        }
    }
}
