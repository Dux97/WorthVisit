﻿#pragma checksum "..\..\miejsca.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3F7E4EA9E0947750A4273DF1027BD326580EC500"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using WorthVisit;


namespace WorthVisit {
    
    
    /// <summary>
    /// miejsca
    /// </summary>
    public partial class miejsca : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image picturebox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtkontynent;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtkraj;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmiejsce;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtopis;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listbox1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\miejsca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textpath;
        
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
            System.Uri resourceLocater = new System.Uri("/WorthVisit;component/miejsca.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\miejsca.xaml"
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
            this.picturebox = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.txtkontynent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtkraj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtmiejsce = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtopis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.listbox1 = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\miejsca.xaml"
            this.listbox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listbox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\miejsca.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 22 "..\..\miejsca.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dodajobraz);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 23 "..\..\miejsca.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.zapisz_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 24 "..\..\miejsca.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.usun_click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textpath = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
