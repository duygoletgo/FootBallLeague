﻿#pragma checksum "C:\Users\Jin\Documents\Visual Studio 2012\Projects\FootballLeague\FootballLeague\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0DAD93EAEBFF20EBAAC08F22BC102EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FootballLeague {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal Microsoft.Phone.Controls.Pivot FootBall_League;
        
        internal Microsoft.Phone.Controls.PivotItem Home;
        
        internal Microsoft.Phone.Controls.ListPicker lstPickLeague;
        
        internal Microsoft.Phone.Controls.PivotItem Menu;
        
        internal Microsoft.Phone.Controls.PivotItem Menu1;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FootballLeague;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.FootBall_League = ((Microsoft.Phone.Controls.Pivot)(this.FindName("FootBall_League")));
            this.Home = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Home")));
            this.lstPickLeague = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lstPickLeague")));
            this.Menu = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Menu")));
            this.Menu1 = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Menu1")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
        }
    }
}

