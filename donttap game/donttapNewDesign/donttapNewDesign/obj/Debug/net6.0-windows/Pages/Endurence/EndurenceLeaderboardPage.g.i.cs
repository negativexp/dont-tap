﻿#pragma checksum "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6FC6A5711BB0101E6DA48D309BF220D078179C86"
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
using donttapNewDesign.Pages.Endurence;


namespace donttapNewDesign.Pages.Endurence {
    
    
    /// <summary>
    /// EndurenceLeaderboardPage
    /// </summary>
    public partial class EndurenceLeaderboardPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitle;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitleUnderText;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridMrdko;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEndurence;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/donttapNewDesign;component/pages/endurence/endurenceleaderboardpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
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
            
            #line 9 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            ((donttapNewDesign.Pages.Endurence.EndurenceLeaderboardPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 24 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBlockTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TextBlockTitleUnderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.DataGridMrdko = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.ButtonEndurence = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            this.ButtonEndurence.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            this.ButtonBack.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\Pages\Endurence\EndurenceLeaderboardPage.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

