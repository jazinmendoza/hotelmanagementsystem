using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HotelManagementSystem.ViewModel;
using HotelManagementSystem.Helper;

namespace HotelManagementSystem.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class loginWindow : Window
    {
        public loginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        // Passes user inputs to LoginViewModel (function: loginUser).
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginViewModel a = new LoginViewModel();
            a.loginUser(username.Text, password.Text);
        }
    }
}
