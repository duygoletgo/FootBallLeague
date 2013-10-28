using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Linq;
using Coding4Fun.Toolkit.Controls;
using Windows.ApplicationModel;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

namespace FootballLeague
{
    public partial class Stadiums : PhoneApplicationPage
    {
        private BackgroundWorker _loadXMLWorker = null;
        public class Stadium
        {
            private string numbers;
            private string club;
            private string name;
            private string address;
            private string capacity;
            private string imagepath ;
            private string inauguration ;
            private string nickname ;
            private string recordattendance;
            public string Club
            {
                get { return club; }
                set { club = value; }
            }
            public string Name 
            { 
                get { return name; } set { name = value; } 
            }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            public string Capacity
            {
                get { return capacity; }
                set { capacity = value; }
            }
            public string Imagepath
            {
                get { return string.Format(@"{0}{1}", "/Resources/Stadium/",imagepath); }
                set { imagepath = value; }
            }
            public string Inauguration
            {
                get { return inauguration; }
                set { inauguration = value; }
            }
            public string Nickname
            {
                get { return nickname; }
                set { nickname = value; }
            }
            public string Recordattendance
            {
                get { return recordattendance; }
                set { recordattendance = value; }
            }
            
            public string Numbers
            {
                get { return string.Format("{0} {1}", numbers,". "); }
                set { numbers = value; }
            }
        }

        private string imageStadium;
        public string ImageStadium
        {
            get { return imageStadium; }
            set { imageStadium = value; }
        }

        [DataMember]
        public bool ListStadiumVisible { get; set; }
        public Stadiums()
        {
            InitializeComponent();
            DataContext = this;
            ReadXml();
        }

        private void Stadiums_OnBackKeyPress(object sender, CancelEventArgs e)
        {
            if (ListStadiumVisible)
            {
                HideSatdiumDetails();
                lstSatdiums.SelectedIndex = -1;
                e.Cancel = true;
            }
            else
            {
                NavigationService.GoBack();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            try
            {
                if (e.NavigationMode != NavigationMode.Back)
                {
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }

            base.OnNavigatedFrom(e);
        }

        private void ReadXml()
        {
            // StadiumXMLPath = Path.Combine(Package.Current.InstalledLocation.Path, "Resources/Stadium.xml");
            //XDocument LoadedData = XDocument.Load(StadiumXMLPath);
            var LoadedData = XElement.Load("Resources/Stadium.xml");
            var data = from query in LoadedData.Descendants("stadium")
                       select new Stadium
                                  {
                                      Numbers = (string)query.Element("number"),
                                      Club = (string)query.Element("club"),
                                      Name = (string)query.Element("name"),
                                      Address = (string)query.Element("address"),
                                      Capacity = (string)query.Element("capacity"),
                                      Imagepath = (string)query.Element("imagepath"),
                                      Inauguration = (string)query.Element("inauguration"),
                                      Nickname = (string)query.Element("nickname"),
                                      Recordattendance = (string)query.Element("recordattendance")
                                  };
            lstSatdiums.ItemsSource = data;
            HideSatdiumDetails();
        }

        private void Stadium_Tap(object sender, GestureEventArgs e)
        {            
            Stadium stadium  = (sender as Grid).DataContext as Stadium;
            TbClub.Text = stadium.Club;
            TbRecordAttendance.Text = stadium.Recordattendance;
            TbAddress.Text = stadium.Address;
            TbCapacity.Text = stadium.Capacity;
            TbInauguration.Text = stadium.Inauguration;
            TbNickname.Text = stadium.Nickname;
            StadiumImage.Source = new BitmapImage(new Uri(stadium.Imagepath, UriKind.Relative));

            ShowSatdiumDetails();
        }
        private void ShowSatdiumDetails()
        {
            //lstSatdiums.Visibility = Visibility.Collapsed;
            //srollStadiumDetail.Visibility = Visibility.Visible;
            VisualStateManager.GoToState(this, "HideListStadium", false);
            VisualStateManager.GoToState(this, "ShowSatdiumDetail", false);
            ListStadiumVisible = true;
        }

        private void HideSatdiumDetails()
        {
            VisualStateManager.GoToState(this, "HideStadiumDetail", false);
            VisualStateManager.GoToState(this, "ShowListStadium", false);
            ListStadiumVisible = false;
        }
    }
}