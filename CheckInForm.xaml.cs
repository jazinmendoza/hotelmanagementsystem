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
    /// Interaction logic for CheckInForm.xaml
    /// </summary>
    public partial class CheckInForm : Window
    {
        String userAccount;
        public CheckInForm(String uname)
        {
            InitializeComponent();
            userAccount = uname;

            //hiding the inputs for new guest
            titleName.Visibility = System.Windows.Visibility.Hidden;
            title.Visibility = System.Windows.Visibility.Hidden;
            lnameName.Visibility = System.Windows.Visibility.Hidden;
            lname.Visibility = System.Windows.Visibility.Hidden;
            fnameName.Visibility = System.Windows.Visibility.Hidden;
            fname.Visibility = System.Windows.Visibility.Hidden;
            genderName.Visibility = System.Windows.Visibility.Hidden;
            gender.Visibility = System.Windows.Visibility.Hidden;
            citizenshipName.Visibility = System.Windows.Visibility.Hidden;
            citizenship.Visibility = System.Windows.Visibility.Hidden;
            checkInStatus.Visibility = System.Windows.Visibility.Hidden;
        }

        private void backBtn_Clicked(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            Dashboard a = new Dashboard(userAccount);
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void checkInBtn(object sender, RoutedEventArgs e)
        {
            //String titleItem = this.title.GetItemText(this.title.SelectedItem);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            titleName.Visibility = System.Windows.Visibility.Visible;
            title.Visibility = System.Windows.Visibility.Visible;
            lnameName.Visibility = System.Windows.Visibility.Visible;
            lname.Visibility = System.Windows.Visibility.Visible;
            fnameName.Visibility = System.Windows.Visibility.Visible;
            fname.Visibility = System.Windows.Visibility.Visible;
            genderName.Visibility = System.Windows.Visibility.Visible;
            gender.Visibility = System.Windows.Visibility.Visible;
            citizenshipName.Visibility = System.Windows.Visibility.Visible;
            citizenship.Visibility = System.Windows.Visibility.Visible;
        }

        private void guestListBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            GuestList a = new GuestList();
            a.Visibility = System.Windows.Visibility.Visible;
        }

    }

    
}
