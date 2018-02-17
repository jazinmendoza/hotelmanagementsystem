using System;
using System.Collections.Generic;
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

namespace HotelManagementSystem.View
{
    /// <summary>
    /// Interaction logic for GuestList.xaml
    /// </summary>
    public partial class GuestList : Window
    {
        public GuestList()
        {
            InitializeComponent();
        }

        private void backBtn_Clicked(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            Dashboard a = new Dashboard();
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
