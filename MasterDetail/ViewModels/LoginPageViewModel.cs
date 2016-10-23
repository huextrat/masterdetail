using Prism.Commands;
using Prism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using Prism.Mvvm;
using MvvmSample.Views;

namespace MasterDetail.ViewModels
{
    class LoginPageViewModel : BindableBase
    {
        private readonly IView _currentView;
        private readonly IView _viewToOpen;

        public LoginPageViewModel(IView currentView, IView viewToOpen)
        {
            _logUserInCommand = new DelegateCommand(LogUserIn, CanLogUserIn);

            _currentView = currentView;
            _viewToOpen = viewToOpen;
        }

        #region login region
        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                _logUserInCommand.RaiseCanExecuteChanged();
            }
        }

        private readonly DelegateCommand _logUserInCommand;
        public ICommand LogUserInCommand
        {
            get { return _logUserInCommand; }
        }
        private bool CanLogUserIn()
        {
            return !string.IsNullOrEmpty(Login);
        }

        private void LogUserIn()
        {
            _viewToOpen.Show();
            _currentView.Close();
        }
        #endregion
    }
}
