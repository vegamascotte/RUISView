﻿#pragma checksum "C:\Users\Joris\Documents\School\P11\RUISView\RUISView\RUISView\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F29428B42B92279059CFF3D5EF37F0DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace RUISView {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage RUISView;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image imgSlideShow;
        
        internal System.Windows.Controls.Canvas cnvOverlay;
        
        internal System.Windows.Controls.Image imgPlayPause;
        
        internal System.Windows.Controls.Button btnPlayPause;
        
        internal System.Windows.Controls.Image imgSideMenu;
        
        internal System.Windows.Controls.Button btnSideMenu;
        
        internal System.Windows.Controls.Canvas cvsPopUp;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RUISView;component/MainPage.xaml", System.UriKind.Relative));
            this.RUISView = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("RUISView")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.imgSlideShow = ((System.Windows.Controls.Image)(this.FindName("imgSlideShow")));
            this.cnvOverlay = ((System.Windows.Controls.Canvas)(this.FindName("cnvOverlay")));
            this.imgPlayPause = ((System.Windows.Controls.Image)(this.FindName("imgPlayPause")));
            this.btnPlayPause = ((System.Windows.Controls.Button)(this.FindName("btnPlayPause")));
            this.imgSideMenu = ((System.Windows.Controls.Image)(this.FindName("imgSideMenu")));
            this.btnSideMenu = ((System.Windows.Controls.Button)(this.FindName("btnSideMenu")));
            this.cvsPopUp = ((System.Windows.Controls.Canvas)(this.FindName("cvsPopUp")));
        }
    }
}

