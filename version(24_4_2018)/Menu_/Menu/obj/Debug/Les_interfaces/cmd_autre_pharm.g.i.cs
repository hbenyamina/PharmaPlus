﻿#pragma checksum "..\..\..\Les_interfaces\cmd_autre_pharm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7EC8BA3D7FE81E5931399B4D6A9348C6434DD38A"
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
    /// cmd_autre_pharm
    /// </summary>
    public partial class cmd_autre_pharm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DCI;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Marque;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quant;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Forme;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dosage;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton restitue;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Menu;component/les_interfaces/cmd_autre_pharm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
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
            this.DCI = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Marque = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Quant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Forme = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.dosage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.restitue = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 7:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Les_interfaces\cmd_autre_pharm.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
