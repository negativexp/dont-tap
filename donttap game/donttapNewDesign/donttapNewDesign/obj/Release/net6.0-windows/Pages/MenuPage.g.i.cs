﻿#pragma checksum "..\..\..\..\Pages\MenuPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9161724373073E782D94730C9D0B103BC7D12C0B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

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
using donttapNewDesign.Pages;


namespace donttapNewDesign.Pages {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitle;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitleUnderText;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFrenzy;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEndurance;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExit;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAbout;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Pages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSettings;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DONT TAP;component/pages/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MenuPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\Pages\MenuPage.xaml"
            ((donttapNewDesign.Pages.MenuPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\Pages\MenuPage.xaml"
            ((donttapNewDesign.Pages.MenuPage)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Page_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBlockTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TextBlockTitleUnderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ButtonFrenzy = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Pages\MenuPage.xaml"
            this.ButtonFrenzy.Click += new System.Windows.RoutedEventHandler(this.ButtonFrenzy_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonEndurance = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Pages\MenuPage.xaml"
            this.ButtonEndurance.Click += new System.Windows.RoutedEventHandler(this.ButtonEndurance_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonExit = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\Pages\MenuPage.xaml"
            this.ButtonExit.Click += new System.Windows.RoutedEventHandler(this.ButtonExit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonAbout = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Pages\MenuPage.xaml"
            this.ButtonAbout.Click += new System.Windows.RoutedEventHandler(this.ButtonAbout_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonSettings = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Pages\MenuPage.xaml"
            this.ButtonSettings.Click += new System.Windows.RoutedEventHandler(this.ButtonSettings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

