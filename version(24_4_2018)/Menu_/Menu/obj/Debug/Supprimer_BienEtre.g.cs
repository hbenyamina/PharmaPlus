﻿#pragma checksum "..\..\Supprimer_BienEtre.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B85EA5BE3AC70C765DD76699289EC77C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Menu;
using RootLibrary.WPF.Localization;
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


namespace Menu {
    
    
    /// <summary>
    /// Supprimer_BienEtre
    /// </summary>
    public partial class Supprimer_BienEtre : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\Supprimer_BienEtre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox marque;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Supprimer_BienEtre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox type;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Supprimer_BienEtre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Supprimer_BienEtre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button supprimer1;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Supprimer_BienEtre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView view_bien_etre;
        
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
            System.Uri resourceLocater = new System.Uri("/Menu;component/supprimer_bienetre.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Supprimer_BienEtre.xaml"
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
            this.marque = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.type = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.supprimer1 = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\Supprimer_BienEtre.xaml"
            this.supprimer1.Click += new System.Windows.RoutedEventHandler(this.supprimer1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.view_bien_etre = ((System.Windows.Controls.ListView)(target));
            
            #line 83 "..\..\Supprimer_BienEtre.xaml"
            this.view_bien_etre.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.view_bien_etre_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

