﻿#pragma checksum "..\..\..\Les_interfaces\Page_bien.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8CA3053FD1F8904A3CE24189C188C473E3A08E4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Menu.Les_interfaces;
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


namespace Menu.Les_interfaces {
    
    
    /// <summary>
    /// Page_bien
    /// </summary>
    public partial class Page_bien : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Les_interfaces\Page_bien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox marquetextbox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Les_interfaces\Page_bien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox typetextbox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Les_interfaces\Page_bien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox comptextbox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Les_interfaces\Page_bien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quanttextbox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Les_interfaces\Page_bien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Renitialiser;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Les_interfaces\Page_bien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button valider;
        
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
            System.Uri resourceLocater = new System.Uri("/Menu;component/les_interfaces/page_bien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Les_interfaces\Page_bien.xaml"
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
            this.marquetextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.typetextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.comptextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.quanttextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Renitialiser = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Les_interfaces\Page_bien.xaml"
            this.Renitialiser.Click += new System.Windows.RoutedEventHandler(this.Renitialiser_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.valider = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Les_interfaces\Page_bien.xaml"
            this.valider.Click += new System.Windows.RoutedEventHandler(this.valider_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
