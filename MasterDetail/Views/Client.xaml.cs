using MasterDetail.ViewModels;
using MasterDetail.Views;
using MvvmSample.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MasterDetail
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : IView
    {
        List<Champ> champ = new List<Champ>();
        
        public Client()
        {
            InitializeComponent();
            DataContext = new ClientViewModel();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            stackMonProfil.Visibility = System.Windows.Visibility.Visible;
            stackMonGitHub.Visibility = System.Windows.Visibility.Hidden;
            profilPseudo1.Text = loginText.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaMusic.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaMusic.Stop();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            stackMonProfil.Visibility = System.Windows.Visibility.Hidden;
            stackMonGitHub.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
