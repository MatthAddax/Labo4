using AppLabo4.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Navigation;

namespace AppLabo4.ViewModel
{
    public class SecondViewModel
    {
        public Student SelectedStudent { get; set; }
        private INavigationService _navigationService;

        [PreferredConstructor]
        public SecondViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }

        public void OnNavigateTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student)e.Parameter;
        }

        private ICommand _backCommand;

        public ICommand BackCommand
        {
            get {
                if (_backCommand == null)
                    _backCommand = new RelayCommand(() => Back());
                return _backCommand;
            }
        }


        private void Back()
        {
            _navigationService.NavigateTo("MainPage");
        }

    }
}
