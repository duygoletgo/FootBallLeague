﻿#pragma checksum "C:\Users\duytrinh\Desktop\FootBallLeagueMG\FootballLeague\FootballLeague\View\Stadiums.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F997340BBF6CAA5655C1E994AA36C8E4"
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
    
    
    public partial class Stadiums : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState ShowListStadium;
        
        internal System.Windows.VisualState ShowSatdiumDetail;
        
        internal System.Windows.VisualState HideListStadium;
        
        internal System.Windows.VisualState HideStadiumDetail;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox lstSatdiums;
        
        internal System.Windows.Controls.ScrollViewer srollStadiumDetail;
        
        internal System.Windows.Controls.TextBlock TbNickname;
        
        internal System.Windows.Controls.TextBlock TbClub;
        
        internal System.Windows.Controls.TextBlock TbInauguration;
        
        internal System.Windows.Controls.TextBlock TbCapacity;
        
        internal System.Windows.Controls.TextBlock TbRecordAttendance;
        
        internal System.Windows.Controls.TextBlock TbAddress;
        
        internal System.Windows.Controls.Image StadiumImage;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FootballLeague;component/View/Stadiums.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("VisualStateGroup")));
            this.ShowListStadium = ((System.Windows.VisualState)(this.FindName("ShowListStadium")));
            this.ShowSatdiumDetail = ((System.Windows.VisualState)(this.FindName("ShowSatdiumDetail")));
            this.HideListStadium = ((System.Windows.VisualState)(this.FindName("HideListStadium")));
            this.HideStadiumDetail = ((System.Windows.VisualState)(this.FindName("HideStadiumDetail")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.lstSatdiums = ((System.Windows.Controls.ListBox)(this.FindName("lstSatdiums")));
            this.srollStadiumDetail = ((System.Windows.Controls.ScrollViewer)(this.FindName("srollStadiumDetail")));
            this.TbNickname = ((System.Windows.Controls.TextBlock)(this.FindName("TbNickname")));
            this.TbClub = ((System.Windows.Controls.TextBlock)(this.FindName("TbClub")));
            this.TbInauguration = ((System.Windows.Controls.TextBlock)(this.FindName("TbInauguration")));
            this.TbCapacity = ((System.Windows.Controls.TextBlock)(this.FindName("TbCapacity")));
            this.TbRecordAttendance = ((System.Windows.Controls.TextBlock)(this.FindName("TbRecordAttendance")));
            this.TbAddress = ((System.Windows.Controls.TextBlock)(this.FindName("TbAddress")));
            this.StadiumImage = ((System.Windows.Controls.Image)(this.FindName("StadiumImage")));
        }
    }
}

