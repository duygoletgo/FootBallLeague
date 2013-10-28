using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Linq;
using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

namespace FootballLeague
{
    public partial class Teams : PhoneApplicationPage
    {
        public class  Team
        {
            private string numbers;
            private string clubName;
            private Uri imagepath;
            public string Numbers
            {
                get { return string.Format("{0} {1}", numbers, ". "); }
                set { numbers = value; }
            }
            public string ClubName
            {
                get { return clubName; }
                set { clubName = value; }
            }
            public Uri Imagepath
            {
                get { return imagepath; }
                set { imagepath = value; }
            }
        }

        public class TeamDetail
        {
            private string numbersDeatil;
            private string nameDetail;
            private string doB;
            private string pOB;
            private string nationnality;
            private string weight;
            private string height;
            private string location;
            private string imagepath;

            public string NumbersDeatil
            {
                get { return string.Format("{0}{1}", numbersDeatil, ". "); }
                set { numbersDeatil = value; }
            }
            public string NameDetail
            {
                get { return nameDetail; }
                set { nameDetail = value; }
            }
            public string DOB
            {
                get { return string.Format("{0}{1}","DOB: ", doB); }
                set { doB = value; }
            }
            public string POB
            {
                get { return string.Format("{0}{1}","POB: ",pOB); }
                set { pOB = value; }
            }
            public string Nationnality
            {
                get { return string.Format("{0}{1}", "Nationnality: ", nationnality); }
                set { nationnality = value; }
            }
            public string Weight
            {
                get { return string.Format("{0}{1}", "Weight: ",weight); }
                set { weight = value; }
            }
            public string Height
            {
                get { return string.Format("{0}{1}", "Height: ",height); }
                set { height = value; }
            }
            public string Location
            {
                get { return string.Format("{0}{1}", "Location: ",location); }
                set { location = value; }
            }

            public string Imagepath
            {
                get { return string.Format(@"{0}{1}{2}", "/Resources/PlayerInfo/ImagePlayer/", imagepath,".jpg"); }
                set { imagepath = value; }
            }
        }

        public bool ListTeamsVisible { get; set; }

        private void Teams_OnBackKeyPress(object sender, CancelEventArgs e)
        {
   
            if (this.my_popup_xaml.IsOpen)
            {
                my_popup_xaml.IsOpen = false;
                lstTeamDetail.IsEnabled = true;
                e.Cancel = true;
            }
            else
            {
                if (ListTeamsVisible)
                {
                    ShowTeams();
                    lstTeams.SelectedIndex = -1;
                    e.Cancel = true;
                }
                else
                {
                    NavigationService.GoBack();
                }
            }
        }

        public Teams()
        {
            InitializeComponent();
            loadTeams();
        }

        void loadTeams()
        {
            List<Team> lstTeam = new List<Team>
                                     {
                                         new Team{Numbers = "1",ClubName = "Arsenal",Imagepath = new Uri("/Resources/Logos/Arsenal FC_logo_s.png",UriKind.RelativeOrAbsolute)},
                                         new Team{Numbers = "2",ClubName = "Liverpool",Imagepath = new Uri("/Resources/Logos/Liverpool _logo_s.png",UriKind.RelativeOrAbsolute)}
                                         
                                     };
            
            lstTeams.ItemsSource = lstTeam;
            ShowTeams();
        }

        void loadTeamDetail()
        {
            var LoadedData = XElement.Load("Resources/PlayerInfo/Arsenal.xml");
            var data = from query in LoadedData.Descendants("player")
                       select new TeamDetail()
                       {
                           NameDetail = (string)query.Element("PlayerName"),
                           DOB = (string)query.Element("NgaySinh"),
                           POB = (string)query.Element("NoiSinh"),
                           Nationnality = (string)query.Element("QuocTich"),
                           Weight = (string)query.Element("ChieuCao"),
                           Height = (string)query.Element("CanNang"),
                           Location = (string)query.Element("Vitri"),
                           Imagepath = (string)query.Element("ImgPath")
                       };
            lstTeamDetail.ItemsSource = data;
            HideTeams();
        }

        private void Teams_Tap(object sender, GestureEventArgs e)
        {
            loadTeamDetail();
        }
        private void ShowTeams()
        {
            VisualStateManager.GoToState(this, "HidelstTeamDetail", false);
            VisualStateManager.GoToState(this, "ShowlstTeam", false);
            ListTeamsVisible = false;
        }

        private void HideTeams()
        {
            VisualStateManager.GoToState(this, "HidelstTeam", false);
            VisualStateManager.GoToState(this, "ShowlstTeamDetail", false);
            ListTeamsVisible = true;
        }
        private void TeamDetail_Tap(object sender, GestureEventArgs e)
        {
            if (!my_popup_xaml.IsOpen)
            {
                my_popup_xaml.IsOpen = true;
                lstTeamDetail.IsEnabled = false;
            }
            TeamDetail teamDT = (sender as Grid).DataContext as TeamDetail;
            tbName.Text = teamDT.NameDetail;
            tbDOB.Text = teamDT.DOB;
            tbPOB.Text = teamDT.POB;
            tbNationality.Text = teamDT.Nationnality;
            tbWeight.Text = teamDT.Weight;
            tbHeight.Text = teamDT.Height;
            tbLocation.Text = teamDT.Location;
            ImageSoccer.Source = new BitmapImage(new Uri(teamDT.Imagepath, UriKind.Relative));
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            if (my_popup_xaml.IsOpen)
            {
                my_popup_xaml.IsOpen = false;
                lstTeamDetail.IsEnabled = true;
            }
        }
    }
}