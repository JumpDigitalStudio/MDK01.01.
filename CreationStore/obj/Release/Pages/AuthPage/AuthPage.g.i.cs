#pragma checksum "..\..\..\..\Pages\AuthPage\AuthPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1349A591DF043D5B70FC51A78D0FB4F34EA86F556903890EAE25A66BD2C023B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CreationStore.Pages.AuthPage;
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


namespace CreationStore.Pages.AuthPage {
    
    
    /// <summary>
    /// AuthPage
    /// </summary>
    public partial class AuthPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox userPass;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridCaptcha;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCaptcha;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userCaptcha;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAuth;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelError;
        
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
            System.Uri resourceLocater = new System.Uri("/CreationStore;component/pages/authpage/authpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
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
            this.userName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.userPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.gridCaptcha = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.labelCaptcha = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.userCaptcha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnAuth = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\Pages\AuthPage\AuthPage.xaml"
            this.btnAuth.Click += new System.Windows.RoutedEventHandler(this.btnAuth_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.labelError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

