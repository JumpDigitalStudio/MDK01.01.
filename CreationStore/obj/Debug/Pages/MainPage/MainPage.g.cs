#pragma checksum "..\..\..\..\Pages\MainPage\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CD2201DC069C2FF5B2745B041307E5FD39CD92A83BF9AB5FF21145CC97D6C63"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CreationStore.Pages.MainPage;
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


namespace CreationStore.Pages.MainPage {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid productsGrid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortingBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtration;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchField;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountProducts;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridTools;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditButton;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Pages\MainPage\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductList;
        
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
            System.Uri resourceLocater = new System.Uri("/CreationStore;component/pages/mainpage/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MainPage\MainPage.xaml"
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
            this.productsGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.productsGrid.Loaded += new System.Windows.RoutedEventHandler(this.productsGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SortingBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.SortingBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortingBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Filtration = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.Filtration.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Filtration_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchField = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.SearchField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchField_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CountProducts = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.gridTools = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EditButton = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.EditButton.Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\Pages\MainPage\MainPage.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ProductList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

