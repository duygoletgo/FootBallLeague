using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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
        private void Teams_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Teams.xaml" , UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FileStream readStream;
            try
            {
                readStream = new FileStream("Resources/PR1.pr", FileMode.Open);
                BinaryReader readBinary = new BinaryReader(readStream);
                byte[] Buffer = new byte[4];
                int offset = 0;
                string Binastring = readBinary.ReadString();

                //string hdr = Convert.ToString(readBinary.Read(Buffer, 0, 4));

                MessageBox.Show(Binastring);
                readStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}