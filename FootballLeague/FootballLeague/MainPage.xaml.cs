using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

namespace FootballLeague
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.lstPickLeague.ItemsSource = Country;
        }
        String[] Country = { "Viet Nam","Japan",
                              "China","USA",
                              "Poland","Brazil",
                              "Singapore","Philipin","Malaysia"};

        private void Stadium_tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stadiums.xaml" , UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}