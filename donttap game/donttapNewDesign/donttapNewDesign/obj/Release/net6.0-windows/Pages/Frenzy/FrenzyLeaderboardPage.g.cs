﻿#pragma checksum "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72E9A0FA7C266ABDDAE3E8B03343732D57D2EDE1"
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
using donttapNewDesign.Pages.Frenzy;


namespace donttapNewDesign.Pages.Frenzy {
    
    
    /// <summary>
    /// FrenzyLeaderboardPage
    /// </summary>
    public partial class FrenzyLeaderboardPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitle;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitleUnderText;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridMrdko;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEndurence;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DONT TAP;component/pages/frenzy/frenzyleaderboardpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
            ((donttapNewDesign.Pages.Frenzy.FrenzyLeaderboardPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
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
            this.DataGridMrdko = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.ButtonEndurence = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
            this.ButtonEndurence.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
            this.ButtonBack.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\Pages\Frenzy\FrenzyLeaderboardPage.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

