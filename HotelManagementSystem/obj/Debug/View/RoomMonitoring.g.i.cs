﻿#pragma checksum "..\..\..\View\RoomMonitoring.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5633417FEE0DCF6C3E7E49269C15B32060530BEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace HotelManagementSystem.View {
    
    
    /// <summary>
    /// RoomMonitoring
    /// </summary>
    public partial class RoomMonitoring : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\RoomMonitoring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label backBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\RoomMonitoring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button firstFloorBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\RoomMonitoring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button secondFloorBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\RoomMonitoring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button thirdFloorBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\RoomMonitoring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fourthFloorBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\RoomMonitoring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame floorPage_Frame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HotelManagementSystem;component/view/roommonitoring.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\RoomMonitoring.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.backBtn = ((System.Windows.Controls.Label)(target));
            
            #line 10 "..\..\..\View\RoomMonitoring.xaml"
            this.backBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.firstFloorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\View\RoomMonitoring.xaml"
            this.firstFloorBtn.Click += new System.Windows.RoutedEventHandler(this.firstBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.secondFloorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\RoomMonitoring.xaml"
            this.secondFloorBtn.Click += new System.Windows.RoutedEventHandler(this.secondBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.thirdFloorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\View\RoomMonitoring.xaml"
            this.thirdFloorBtn.Click += new System.Windows.RoutedEventHandler(this.thirdBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.fourthFloorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\View\RoomMonitoring.xaml"
            this.fourthFloorBtn.Click += new System.Windows.RoutedEventHandler(this.fourthBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.floorPage_Frame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

