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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public String userAccount;

        public Dashboard(string uname)
        {
            InitializeComponent();
            userAccount = uname;
        }

        private void roomMonitoringBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            RoomMonitoring a = new RoomMonitoring();
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void reservationBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            ReservationForm a = new ReservationForm(userAccount);
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void guessListBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            GuestList a = new GuestList();
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void checkInBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            CheckInForm a = new CheckInForm(userAccount);
            a.Visibility = System.Windows.Visibility.Visible;
        }


    }
}
