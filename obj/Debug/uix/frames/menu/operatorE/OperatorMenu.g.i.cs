﻿#pragma checksum "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45DE66B46C075EEE02ED239BEF72531821B0DEC6DD8F5F5F74AEC1B388C867C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MotoRandApplication.uix.frames.menu.operatorE;
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


namespace MotoRandApplication.uix.frames.menu.operatorE {
    
    
    /// <summary>
    /// OperatorMenu
    /// </summary>
    public partial class OperatorMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label OperatorTextEmployee;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame OperatorMenuFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/MotoRandApplication;component/uix/frames/menu/operatore/operatormenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml"
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
            
            #line 36 "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ToolbarClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.MainMenuClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OperatorTextEmployee = ((System.Windows.Controls.Label)(target));
            
            #line 60 "..\..\..\..\..\..\uix\frames\menu\operatorE\OperatorMenu.xaml"
            this.OperatorTextEmployee.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.EmployeeClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OperatorMenuFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

