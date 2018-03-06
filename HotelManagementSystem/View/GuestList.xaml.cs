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

        private void GuestListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecteditems = GuestListDataGrid.SelectedItem;
            var items = (System.Data.DataRowView)selecteditems;
            var counter = 0;
            foreach(var item in items.Row.ItemArray)
            {
                if(counter == 0)
                {
                    var guestId = item;
                    guestID.Content = item;
                }
                else if(counter == 1)
                {
                    var fname = item;
                    fName.Content = item;
                }
                else if(counter == 2)
                {
                    var lname = item;
                    lName.Content = item;
                }
                else if (counter == 6)
                {
                    var guestStatus = item;
                    status.Content = item;
                }
                counter++;
            }
        }

        private void checkOutBtnClick(object sender, RoutedEventArgs e)
        {
            Boolean ret;
            ServiceReference1.RestServiceSoapClient updateStatus = new ServiceReference1.RestServiceSoapClient();
            ret = updateStatus.updateGuestStatus(searchBox.Text, (System.Int32)guestID.Content, (System.String)status.Content).DefaultView;
        }


        
    }
}
