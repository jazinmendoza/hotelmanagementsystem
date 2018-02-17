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
using HotelManagementSystem.View.FloorPages;

namespace HotelManagementSystem.View
{
    /// <summary>
    /// Interaction logic for RoomMonitoring.xaml
    /// </summary>
    public partial class RoomMonitoring : Window
    {
        public RoomMonitoring()
        {
            InitializeComponent();
        }

        private void backBtn_Clicked(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            Dashboard a = new Dashboard();
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void firstBtn_Clicked(object sender, RoutedEventArgs e)
        {
            floorPage_Frame.Content = new FirstFloorView();
        }

        private void secondBtn_Clicked(object sender, RoutedEventArgs e)
        {
            floorPage_Frame.Content = new SecondFloorView();
        }

        private void thirdBtn_Clicked(object sender, RoutedEventArgs e)
        {
            floorPage_Frame.Content = new ThirdFloorView();
        }

        private void fourthBtn_Clicked(object sender, RoutedEventArgs e)
        {
            floorPage_Frame.Content = new FourthFloorView();
        }


    }
}
