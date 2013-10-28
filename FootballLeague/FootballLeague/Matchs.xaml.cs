using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FootballLeague
{
    public partial class Matchs : PhoneApplicationPage
    {
        public Matchs()
        {
            InitializeComponent();
        }

        private void Matchs_OnBackKeyPress(object sender, CancelEventArgs e)
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
    }
}