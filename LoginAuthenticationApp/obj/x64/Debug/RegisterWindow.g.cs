﻿#pragma checksum "..\..\..\RegisterWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E2C0480F074D8C56B12E829AC843D5385098A870D41C4CB466B375070A7B8F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoginAuthenticationApp;
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


namespace LoginAuthenticationApp {
    
    
    /// <summary>
    /// RegisterWindow
    /// </summary>
    public partial class RegisterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fullname;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox username;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginAuthenticationApp;component/registerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RegisterWindow.xaml"
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
            this.fullname = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\RegisterWindow.xaml"
            this.fullname.GotFocus += new System.Windows.RoutedEventHandler(this.fullname_GotFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\RegisterWindow.xaml"
            this.fullname.LostFocus += new System.Windows.RoutedEventHandler(this.fullname_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.username = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\RegisterWindow.xaml"
            this.username.GotFocus += new System.Windows.RoutedEventHandler(this.username_GotFocus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\RegisterWindow.xaml"
            this.username.LostFocus += new System.Windows.RoutedEventHandler(this.username_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.email = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\RegisterWindow.xaml"
            this.email.GotFocus += new System.Windows.RoutedEventHandler(this.email_GotFocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\RegisterWindow.xaml"
            this.email.LostFocus += new System.Windows.RoutedEventHandler(this.email_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 22 "..\..\..\RegisterWindow.xaml"
            this.password.GotFocus += new System.Windows.RoutedEventHandler(this.password_GotFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\RegisterWindow.xaml"
            this.password.LostFocus += new System.Windows.RoutedEventHandler(this.password_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 24 "..\..\..\RegisterWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegisterBTN);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 25 "..\..\..\RegisterWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginBTN);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

