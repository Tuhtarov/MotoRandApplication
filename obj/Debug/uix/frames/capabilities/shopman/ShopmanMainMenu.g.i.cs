﻿#pragma checksum "..\..\..\..\..\..\uix\frames\capabilities\shopman\ShopmanMainMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C9D245259C5968BF01B96364FD9751AB776C925D96AD11DA6BDD5C36C58CD4D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MotoRandApplication.uix.frames.capabilities.shopman;
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


namespace MotoRandApplication.uix.frames.capabilities.shopman {
    
    
    /// <summary>
    /// ShopmanMainMenu
    /// </summary>
    public partial class ShopmanMainMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\..\..\..\..\uix\frames\capabilities\shopman\ShopmanMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextHelpInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/MotoRandApplication;component/uix/frames/capabilities/shopman/shopmanmainmenu.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\uix\frames\capabilities\shopman\ShopmanMainMenu.xaml"
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
            
            #line 35 "..\..\..\..\..\..\uix\frames\capabilities\shopman\ShopmanMainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnClickSell);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 41 "..\..\..\..\..\..\uix\frames\capabilities\shopman\ShopmanMainMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnClickRegistration);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextHelpInfo = ((System.Windows.Controls.TextBlock)(target));
            
            #line 64 "..\..\..\..\..\..\uix\frames\capabilities\shopman\ShopmanMainMenu.xaml"
            this.TextHelpInfo.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnClickHelpInfo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

