﻿#pragma checksum "..\..\..\AddBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2FEC40812EB60CD8C15DE0C62ED0B13258AB699C"
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
    /// AddBook
    /// </summary>
    public partial class AddBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse CloseButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Veglegesit;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox AuthorSearch;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitle;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIsbn;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImgLink;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Loanable;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaxLoanDay;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox Category;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BarcodeInput;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShortDescript;
        
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
            System.Uri resourceLocater = new System.Uri("/BookWorm;component/addbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddBook.xaml"
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
            
            #line 24 "..\..\..\AddBook.xaml"
            ((System.Windows.Controls.Menu)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\AddBook.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NavigateToMenu);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 30 "..\..\..\AddBook.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 31 "..\..\..\AddBook.xaml"
            this.CloseButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseApp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Veglegesit = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.AuthorSearch = ((System.Windows.Controls.AutoCompleteBox)(target));
            return;
            case 7:
            this.txtTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtIsbn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ImgLink = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Loanable = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.MaxLoanDay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Category = ((System.Windows.Controls.AutoCompleteBox)(target));
            return;
            case 13:
            this.BarcodeInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.ShortDescript = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
