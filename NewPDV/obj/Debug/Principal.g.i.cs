﻿#pragma checksum "..\..\Principal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EEAD58031F94D8EE1A68A0C4492C6BA65337AD165F689212F76B802260A0DD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewPDV;
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


namespace NewPDV {
    
    
    /// <summary>
    /// Principal
    /// </summary>
    public partial class Principal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 109 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tab;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btnClientes;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel btnSair;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid quadroHome;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid quadroLogo;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image facebook;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Site;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnConfig;
        
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
            System.Uri resourceLocater = new System.Uri("/NewPDV;component/principal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Principal.xaml"
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
            this.tab = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.btnClientes = ((System.Windows.Controls.Border)(target));
            
            #line 119 "..\..\Principal.xaml"
            this.btnClientes.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnClientes_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSair = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.quadroHome = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.quadroLogo = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.facebook = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.Site = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.btnConfig = ((System.Windows.Controls.Image)(target));
            
            #line 203 "..\..\Principal.xaml"
            this.btnConfig.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnConfig_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
