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
    /// Interaction logic for ReservationForm.xaml
    /// </summary>
    public partial class ReservationForm : Window
    {
        String userAccount;
        public ReservationForm(String uname)
        {
            InitializeComponent();
            userAccount = uname;
            status.Visibility = System.Windows.Visibility.Hidden;
        }

        private void backBtn_Clicked(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            Dashboard a = new Dashboard(userAccount);
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void reserveBtn(object sender, RoutedEventArgs e)
        {
            Boolean ret = false;
            String cIn = "2017-03-21";
            String cOut = "2017-03-21"; 
            ServiceReference1.RestServiceSoapClient add = new ServiceReference1.RestServiceSoapClient();
            ret = add.addReservation(userAccount, fname.Text, lname.Text, roomNum.Text, remarks.Text, cIn, cOut);

            if (ret == true)
            {
                status.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
