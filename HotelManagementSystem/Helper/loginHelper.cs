using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HotelManagementSystem.Helper
{
    class loginHelper
    {
        // Pops out when the username does not exist in the database.
        public void userDoesNotExist()
        {
            MessageBox.Show("User does not exist!", "Login Error");
        }

        // Pops out when the username and password does not match.
        public void wrongPassword()
        {
            MessageBox.Show("Username and password does not match!", "Login Error");
        }

        // For checking only. Comment this function.
        public void loginSuccess()
        {
            MessageBox.Show("Username and password match!", "Login Successful");
        }
    }
}
