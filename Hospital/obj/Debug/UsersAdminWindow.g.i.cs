﻿#pragma checksum "..\..\UsersAdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ED317FCD8092012D42047F07D142CF59CE7BED998648A732ED21EA1AA92FED4"
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
    /// UsersAdminWindow
    /// </summary>
    public partial class UsersAdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UsersGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsersCreate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsersSurnameTxb;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsersDeleteBt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsersBackBt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsersUpdateBt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsersGenderComboBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsersNameTxb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsersMidlleNameTxb;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsersPhoneTxb;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\UsersAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsersAccountComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital;component/usersadminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UsersAdminWindow.xaml"
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
            this.UsersGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\UsersAdminWindow.xaml"
            this.UsersGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UsersGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsersCreate = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\UsersAdminWindow.xaml"
            this.UsersCreate.Click += new System.Windows.RoutedEventHandler(this.UsersCreate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UsersSurnameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UsersDeleteBt = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\UsersAdminWindow.xaml"
            this.UsersDeleteBt.Click += new System.Windows.RoutedEventHandler(this.UsersDeleteBt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UsersBackBt = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\UsersAdminWindow.xaml"
            this.UsersBackBt.Click += new System.Windows.RoutedEventHandler(this.UsersBackBt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UsersUpdateBt = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\UsersAdminWindow.xaml"
            this.UsersUpdateBt.Click += new System.Windows.RoutedEventHandler(this.UsersUpdateBt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UsersGenderComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.UsersNameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.UsersMidlleNameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.UsersPhoneTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.UsersAccountComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
