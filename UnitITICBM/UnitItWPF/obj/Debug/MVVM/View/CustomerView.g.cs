﻿#pragma checksum "..\..\..\..\MVVM\View\CustomerView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58545BF727046DD60F4D7868423F1FD3AD256E5D0270F276C6C9FB5E74BF7704"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using UnitItWPF.MVVM.View;
using UnitItWPF.MVVM.ViewModel;


namespace UnitItWPF.MVVM.View {
    
    
    /// <summary>
    /// CustomerView
    /// </summary>
    public partial class CustomerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\MVVM\View\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Datagrid_Customers;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\MVVM\View\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Ny_Komponent_Button;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\MVVM\View\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Ændre_Komponent_Button;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\MVVM\View\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Slet_Komponent_Button;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\MVVM\View\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_New_Customer;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\MVVM\View\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_New_Customer_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/UnitItWPF;component/mvvm/view/customerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\CustomerView.xaml"
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
            this.Datagrid_Customers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 43 "..\..\..\..\MVVM\View\CustomerView.xaml"
            this.Datagrid_Customers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Ny_Komponent_Button = ((System.Windows.Controls.RadioButton)(target));
            
            #line 56 "..\..\..\..\MVVM\View\CustomerView.xaml"
            this.Ny_Komponent_Button.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Ændre_Komponent_Button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.Slet_Komponent_Button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.textbox_New_Customer = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\..\MVVM\View\CustomerView.xaml"
            this.textbox_New_Customer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Textbox_New_Customer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.add_New_Customer_Button = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\..\MVVM\View\CustomerView.xaml"
            this.add_New_Customer_Button.Click += new System.Windows.RoutedEventHandler(this.Add_New_Customer_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

