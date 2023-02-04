using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigationServiceMAUI.Models;
using NavigationServiceMAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServiceMAUI.ViewModels
{
    [QueryProperty(nameof(StudentDetail), "StudentDetail")]
    public partial class StudentDetailPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private StudentModel _studentDetail;

        public StudentDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }


        [RelayCommand]
        public void Test()
        {
            var studentListPageViewModel = NavigationService.GetPageViewModel<StudentListPageViewModel>();
            studentListPageViewModel?.AddStudentCommand.Execute(null);

        }
    }
}
