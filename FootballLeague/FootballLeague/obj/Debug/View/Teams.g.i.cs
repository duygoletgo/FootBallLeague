﻿#pragma checksum "C:\Users\duytrinh\Desktop\FootBallLeagueMG\FootballLeague\FootballLeague\View\Teams.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C90182A7EE39DF5C27159F8817F25FBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
    
    
    public partial class Teams : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState ShowlstTeam;
        
        internal System.Windows.VisualState ShowlstTeamDetail;
        
        internal System.Windows.VisualState HidelstTeam;
        
        internal System.Windows.VisualState HidelstTeamDetail;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox lstTeams;
        
        internal System.Windows.Controls.ListBox lstTeamDetail;
        
        internal System.Windows.Controls.Primitives.Popup my_popup_xaml;
        
        internal System.Windows.Controls.Image ImageSoccer;
        
        internal System.Windows.Controls.TextBlock tbName;
        
        internal System.Windows.Controls.TextBlock tbDOB;
        
        internal System.Windows.Controls.TextBlock tbPOB;
        
        internal System.Windows.Controls.TextBlock tbNationality;
        
        internal System.Windows.Controls.TextBlock tbWeight;
        
        internal System.Windows.Controls.TextBlock tbHeight;
        
        internal System.Windows.Controls.TextBlock tbLocation;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FootballLeague;component/View/Teams.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("VisualStateGroup")));
            this.ShowlstTeam = ((System.Windows.VisualState)(this.FindName("ShowlstTeam")));
            this.ShowlstTeamDetail = ((System.Windows.VisualState)(this.FindName("ShowlstTeamDetail")));
            this.HidelstTeam = ((System.Windows.VisualState)(this.FindName("HidelstTeam")));
            this.HidelstTeamDetail = ((System.Windows.VisualState)(this.FindName("HidelstTeamDetail")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.lstTeams = ((System.Windows.Controls.ListBox)(this.FindName("lstTeams")));
            this.lstTeamDetail = ((System.Windows.Controls.ListBox)(this.FindName("lstTeamDetail")));
            this.my_popup_xaml = ((System.Windows.Controls.Primitives.Popup)(this.FindName("my_popup_xaml")));
            this.ImageSoccer = ((System.Windows.Controls.Image)(this.FindName("ImageSoccer")));
            this.tbName = ((System.Windows.Controls.TextBlock)(this.FindName("tbName")));
            this.tbDOB = ((System.Windows.Controls.TextBlock)(this.FindName("tbDOB")));
            this.tbPOB = ((System.Windows.Controls.TextBlock)(this.FindName("tbPOB")));
            this.tbNationality = ((System.Windows.Controls.TextBlock)(this.FindName("tbNationality")));
            this.tbWeight = ((System.Windows.Controls.TextBlock)(this.FindName("tbWeight")));
            this.tbHeight = ((System.Windows.Controls.TextBlock)(this.FindName("tbHeight")));
            this.tbLocation = ((System.Windows.Controls.TextBlock)(this.FindName("tbLocation")));
        }
    }
}

