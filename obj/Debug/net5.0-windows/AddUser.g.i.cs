﻿#pragma checksum "..\..\..\AddUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0B4AA9A9719AFE1A945AE2A18DCE937A96AEE53B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookWorm;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace BookWorm {
    
    
    /// <summary>
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse CloseButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstName;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastName;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userEmail;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox postCode;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox street;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox streetNumber;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker userDateofBirth;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button userAddButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BookWorm;component/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddUser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 25 "..\..\..\AddUser.xaml"
            ((System.Windows.Controls.Menu)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\AddUser.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NavigateToMenu);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 31 "..\..\..\AddUser.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 32 "..\..\..\AddUser.xaml"
            this.CloseButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseApp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.firstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\AddUser.xaml"
            this.firstName.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.vezetekNevEvent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\AddUser.xaml"
            this.lastName.GotFocus += new System.Windows.RoutedEventHandler(this.lastNameFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.userEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\..\AddUser.xaml"
            this.userEmail.GotFocus += new System.Windows.RoutedEventHandler(this.emailFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.postCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 126 "..\..\..\AddUser.xaml"
            this.postCode.GotFocus += new System.Windows.RoutedEventHandler(this.postCodeFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.city = ((System.Windows.Controls.TextBox)(target));
            
            #line 149 "..\..\..\AddUser.xaml"
            this.city.GotFocus += new System.Windows.RoutedEventHandler(this.cityFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.street = ((System.Windows.Controls.TextBox)(target));
            
            #line 171 "..\..\..\AddUser.xaml"
            this.street.GotFocus += new System.Windows.RoutedEventHandler(this.streetFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.streetNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 192 "..\..\..\AddUser.xaml"
            this.streetNumber.GotFocus += new System.Windows.RoutedEventHandler(this.streeNumberFocus);
            
            #line default
            #line hidden
            return;
            case 12:
            this.userDateofBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 13:
            this.userAddButton = ((System.Windows.Controls.Button)(target));
            
            #line 222 "..\..\..\AddUser.xaml"
            this.userAddButton.Click += new System.Windows.RoutedEventHandler(this.UserAddButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

