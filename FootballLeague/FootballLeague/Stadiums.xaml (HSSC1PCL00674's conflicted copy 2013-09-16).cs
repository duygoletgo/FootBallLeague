using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Xml.Linq;
using Windows.ApplicationModel;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FootballLeague
{
    public partial class Stadiums : PhoneApplicationPage
    {
        public class Stadium
        {
            private string club;
            private string name;
            public string Club { get { return club; } set { club = value; } }
            public string Name { get { return name; } set { name = value; } }
        }


        public Stadiums()
        {
            InitializeComponent();
            ReadXml();
        }

        private void Stadiums_OnBackKeyPress(object sender, CancelEventArgs e)
        {
            NavigationService.GoBack();
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
            var data = from query in LoadedData.Descendants("dict")
                       select new Stadium
                                  {
                                      Club = (string)query.Element("key"),
                                      Name = (string)query.Element("name")
                                  };
            lstSatdiums.ItemsSource = data;
        }
    }
}