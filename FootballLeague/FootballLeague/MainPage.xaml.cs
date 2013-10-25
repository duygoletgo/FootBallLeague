using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using FootballLeague.Helper;
using FootballLeague.ViewModel;
using GalaSoft.MvvmLight.Command;
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
            GetMvvmInstance.GetInstance<TeamsViewModel>(MvvmKeys.TeamsViewModel).GoToTeamsView.Execute(null);
        }
        private void Matchs_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Matchs.xaml", UriKind.Relative));
        }
        private void History_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/History.xaml", UriKind.Relative));
        }

        public int cFileVersion = 1;
        public int cHeaderSize = 89;
        public int cTeamSize = 42;
        public int cMatchSize = 9;
        public int cLeagueNameChars = 16;
        public int cTeamNameChars = 10;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FileStream readStream;
            try
            {

                readStream = new FileStream("Resources/PR1.pr", FileMode.Open);
                BinaryReader readBinary = new BinaryReader(readStream);
                byte[] Buffer = readBinary.ReadBytes(4);
                int offset = 0;
                string hdr = System.Text.Encoding.UTF8.GetString(Buffer, offset, 4);
                offset += 5;
                byte[] Buffer2 = readBinary.ReadBytes(offset + cLeagueNameChars * 4);
                string LeagueName = System.Text.Encoding.UTF8.GetString(Buffer2, 1, cLeagueNameChars * 4);
                offset += cLeagueNameChars*4;
                byte[] mYear = readBinary.ReadBytes(offset+3);
                int Year = BitConverter.ToInt32(mYear,0);

                MessageBox.Show(hdr);
                readStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}