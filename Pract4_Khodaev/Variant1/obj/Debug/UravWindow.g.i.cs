﻿#pragma checksum "..\..\UravWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20CDB541C6A5203D1DDBADEF1DFA011F8943DC21F95D4E647C83E8F88C2DF1B0"
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
using Variant1;


namespace Variant1 {
    
    
    /// <summary>
    /// UravWindow
    /// </summary>
    public partial class UravWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button res_button;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox a_textbox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox b_textbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox c_textbox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label d_label;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label res_label;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UravWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Variant1;component/uravwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UravWindow.xaml"
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
            
            #line 9 "..\..\UravWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.res_button = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\UravWindow.xaml"
            this.res_button.Click += new System.Windows.RoutedEventHandler(this.Res_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.a_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.b_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.c_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.d_label = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.res_label = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.exit_button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\UravWindow.xaml"
            this.exit_button.Click += new System.Windows.RoutedEventHandler(this.Exit_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

