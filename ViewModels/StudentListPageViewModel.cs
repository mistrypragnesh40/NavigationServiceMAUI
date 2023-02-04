using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigationServiceMAUI.Models;
using NavigationServiceMAUI.Services;
using NavigationServiceMAUI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServiceMAUI.ViewModels
{
    public partial class StudentListPageViewModel : BaseViewModel
    {
        public ObservableCollection<StudentModel> StudentList { get; set; } = new ObservableCollection<StudentModel>();

        public StudentListPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            AddStudentDetails();
        }

        public StudentListPageViewModel()
        {

        }
        private void AddStudentDetails()
        {
            StudentList.Clear();
            StudentList.Add(new StudentModel
            {
                Email = "abc@gmail.com",
                Name = "Pragnesh",
                Id = 1
            });

            StudentList.Add(new StudentModel
            {
                Email = "test@gmail.com",
                Name = "Moshin",
                Id = 2
            });

            StudentList.Add(new StudentModel
            {
                Email = "test2@gmail.com",
                Name = "Hiral",
                Id = 3
            });

            StudentList.Add(new StudentModel
            {
                Email = "test3@gmail.com",
                Name = "Viral",
                Id = 4
            });
        }

        [RelayCommand]
        public void StudentSelected(StudentModel student)
        {
            NavigationService.NavigateToAsync(nameof(StudentDetailPage), new Dictionary<string, object> { { "StudentDetail", student } });
        }

        [RelayCommand]
        public void AddStudent()
        {
            StudentList.Add(new StudentModel
            {
                Email = "test4@gmail.com",
                Name = "Test",
                Id = 4
            });
        }
      
    }
}
