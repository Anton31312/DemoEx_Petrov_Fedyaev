﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0648568BF3295B1EF9101C33EBCD163EA7EC0BF348EA96B69E7D00F4A5A1E302"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WSR_Petrov_Fedyaev;


namespace WSR_Petrov_Fedyaev {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMaterialButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFAQ;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MaterialListView;
        
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
            System.Uri resourceLocater = new System.Uri("/WSR_Petrov_Fedyaev;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            this.AddMaterialButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\MainWindow.xaml"
            this.AddMaterialButton.Click += new System.Windows.RoutedEventHandler(this.AddMaterialButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnFAQ = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Windows\MainWindow.xaml"
            this.btnFAQ.Click += new System.Windows.RoutedEventHandler(this.btnFAQ_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Windows\MainWindow.xaml"
            this.TextBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SortComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\..\Windows\MainWindow.xaml"
            this.SortComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 69 "..\..\..\Windows\MainWindow.xaml"
            this.FilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MaterialListView = ((System.Windows.Controls.ListView)(target));
            
            #line 75 "..\..\..\Windows\MainWindow.xaml"
            this.MaterialListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MaterialListView_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\Windows\MainWindow.xaml"
            this.MaterialListView.KeyUp += new System.Windows.Input.KeyEventHandler(this.MaterialListView_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

