﻿#pragma checksum "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "554E35CE29E7B598297E2DB08A76353260555A13D4A4A548459998B92D53CF37"
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
using donttap.Viewmodels.Endurence.Settings;


namespace donttap.Viewmodels.Endurence.Settings {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTime;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxBoardSize;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxBoxSize;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSpacing;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAmountOfStartingBoxes;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonStart;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
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
            System.Uri resourceLocater = new System.Uri("/donttap;component/viewmodels/endurence/settings/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
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
            
            #line 10 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
            ((donttap.Viewmodels.Endurence.Settings.Settings)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxBoardSize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBoxBoxSize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextBoxSpacing = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextBoxAmountOfStartingBoxes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ButtonStart = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
            this.ButtonStart.Click += new System.Windows.RoutedEventHandler(this.ButtonStart_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\Viewmodels\Endurence\Settings\Settings.xaml"
            this.ButtonBack.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
