﻿#pragma checksum "..\..\..\Menu\Afryka.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02EA94D3677F41B9C1F6BDF586EC2FFEC425CDEC"
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
using WorthVisit.Menu;


namespace WorthVisit.Menu {
    
    
    /// <summary>
    /// Afryka
    /// </summary>
    public partial class Afryka : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Menu\Afryka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image picturebox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Menu\Afryka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtkraj;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Menu\Afryka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtmiejsce;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Menu\Afryka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtopis;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Menu\Afryka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox1;
        
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
            System.Uri resourceLocater = new System.Uri("/WorthVisit;component/menu/afryka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menu\Afryka.xaml"
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
            this.txtkraj = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtmiejsce = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtopis = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.combobox1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\Menu\Afryka.xaml"
            this.combobox1.DropDownClosed += new System.EventHandler(this.combobox1_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 20 "..\..\..\Menu\Afryka.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Clcmenu);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
