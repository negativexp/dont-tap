﻿#pragma checksum "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98167DA9A97A041C07495B69A6FAF0CAE86B8D12"
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
    /// EndurenceGame
    /// </summary>
    public partial class EndurenceGame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MainBorder;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMinimize;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPoints;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTime;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgessBarValue;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridGame;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridCountDown;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockCountDown;
        
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
            System.Uri resourceLocater = new System.Uri("/donttapNewDesign;component/pages/endurence/endurencegame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
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
            
            #line 10 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
            ((donttapNewDesign.Pages.Endurence.EndurenceGame)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            
            #line 22 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\Pages\Endurence\EndurenceGame.xaml"
            this.ButtonMinimize.Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBlockPoints = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextBlockTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ProgessBarValue = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.GridGame = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.GridCountDown = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.TextBlockCountDown = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

