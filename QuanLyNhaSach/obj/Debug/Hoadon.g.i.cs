﻿#pragma checksum "..\..\Hoadon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "443BF6C7C002425AB17314AD5687DD8D56386A035FF7BD4D9D10CB6853700D14"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
using quanlynhasach;


namespace quanlynhasach {
    
    
    /// <summary>
    /// Hoadon
    /// </summary>
    public partial class Hoadon : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Hoadon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchHD;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Hoadon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddHoadon;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Hoadon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChitiet;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Hoadon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHoadon;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Hoadon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
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
            System.Uri resourceLocater = new System.Uri("/quanlynhasach;component/hoadon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Hoadon.xaml"
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
            this.txtSearchHD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnAddHoadon = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Hoadon.xaml"
            this.btnAddHoadon.Click += new System.Windows.RoutedEventHandler(this.btnAddHoadon_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnChitiet = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Hoadon.xaml"
            this.btnChitiet.Click += new System.Windows.RoutedEventHandler(this.btnChitiet_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgHoadon = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\Hoadon.xaml"
            this.dgHoadon.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgHoadon_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Hoadon.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

