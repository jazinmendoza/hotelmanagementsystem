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
using System.Windows.Forms;

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
            ServiceReference1.RestServiceSoapClient a = new ServiceReference1.RestServiceSoapClient();
            GuestListDataGrid.DataContext = a.getGuestList().DefaultView;
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

        private void Button_ClickSearch(object sender, RoutedEventArgs e)
        {
            ServiceReference1.RestServiceSoapClient search = new ServiceReference1.RestServiceSoapClient();
            GuestListDataGrid.DataContext = search.getDataFromSearch(searchBox.Text).DefaultView;
        }

        private void viewBillingBtnClicked(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            Billing a = new Billing();
            a.Visibility = System.Windows.Visibility.Visible;
        }

        private void checkOutBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void GuestListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string guestId = GuestListDataGrid.SelectedItem.ToString();
            //string fname = GuestListDataGrid.CurrentRow.Cells[1].Value.ToString();
            //string lname = GuestListDataGrid.CurrentRow.Cells[2].Value.ToString();
           // string guestStatus = GuestListDataGrid.CurrentRow.Cells[6].Value.ToString();

            fName.Content = guestId;
            //lName.Content = lname;
            //status.Content = guestStatus;
        }

        
    }
}
