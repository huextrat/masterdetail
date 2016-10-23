using MasterDetail.ViewModels;
using MvvmSample.Views;

namespace MasterDetail.Views
{
    /// <summary>
    /// Interaction logic for LoginPageView.xaml
    /// </summary>
    public partial class LoginPageView : IView
    {
        public LoginPageView()
        {
            InitializeComponent();

            DataContext = new LoginPageViewModel(this, new Client());
        }
    }
}
