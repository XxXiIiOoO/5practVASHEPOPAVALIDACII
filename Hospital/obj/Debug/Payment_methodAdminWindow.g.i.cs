﻿#pragma checksum "..\..\Payment_methodAdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5A4E4D1B0F87F9C8A0FF75ECCBBCFE25AE33932DF52E87B73D147C3BA4AB3165"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Hospital;
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


namespace Hospital {
    
    
    /// <summary>
    /// Payment_methodAdminWindow
    /// </summary>
    public partial class Payment_methodAdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Payment_methodAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PaymentGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Payment_methodAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PaymentCreate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Payment_methodAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PaymentTxb;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Payment_methodAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PaymentDeleteBt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Payment_methodAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PaymentBackBt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Payment_methodAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PaymentUpdateBt;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital;component/payment_methodadminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Payment_methodAdminWindow.xaml"
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
            this.PaymentGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\Payment_methodAdminWindow.xaml"
            this.PaymentGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PaymentGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PaymentCreate = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Payment_methodAdminWindow.xaml"
            this.PaymentCreate.Click += new System.Windows.RoutedEventHandler(this.PaymentCreate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PaymentTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PaymentDeleteBt = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Payment_methodAdminWindow.xaml"
            this.PaymentDeleteBt.Click += new System.Windows.RoutedEventHandler(this.PaymentDeleteBt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PaymentBackBt = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Payment_methodAdminWindow.xaml"
            this.PaymentBackBt.Click += new System.Windows.RoutedEventHandler(this.PaymentBackBt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PaymentUpdateBt = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Payment_methodAdminWindow.xaml"
            this.PaymentUpdateBt.Click += new System.Windows.RoutedEventHandler(this.PaymentUpdateBt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

