﻿#pragma checksum "D:\Projects\RestaurantApplication\RestaurantApplication\TipCalculation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "70B7EE9BDA2BD39ED869B1E3D742BAB9"
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


namespace RestaurantApplication {
    
    
    public partial class TipCalculation : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid LayoutRoot_Copy;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBox txtTipAmount;
        
        internal System.Windows.Controls.Button btnOK;
        
        internal System.Windows.Controls.Button btnCancel;
        
        internal System.Windows.Controls.Slider TipSlider;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RestaurantApplication;component/TipCalculation.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.LayoutRoot_Copy = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot_Copy")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.txtTipAmount = ((System.Windows.Controls.TextBox)(this.FindName("txtTipAmount")));
            this.btnOK = ((System.Windows.Controls.Button)(this.FindName("btnOK")));
            this.btnCancel = ((System.Windows.Controls.Button)(this.FindName("btnCancel")));
            this.TipSlider = ((System.Windows.Controls.Slider)(this.FindName("TipSlider")));
        }
    }
}

